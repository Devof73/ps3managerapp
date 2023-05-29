using CefSharp;
using CefSharp.DevTools.Page;
using CefSharp.Internals;
using Microsoft.Win32;
using PPB.classes;
using PSS3.Classes;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.WinForms;
using webMAN_Manager.Classes;
using webMAN_Manager.Classes.PS3;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using ListBox = System.Windows.Forms.ListBox;
namespace webMAN_Manager.Forms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        PS3System _playstation3;
        string _address;
        bool _disconnected = false;
        DiscordRPC.DiscordRpcClient _rpcImp;
        private const string NewsSrc = "https://www.psx-place.com/articles/playstation-3-ps3.2/category";
        public event EventHandler OnInitializationBegin;
        public event EventHandler OnInitializationFinished;
        public event EventHandler<int> OnInitializationProgression;
        public event EventHandler<PS3System.ReceivedParamEventArgs> OnSfoReceived;
        public event EventHandler<object[]> OnFriendDownloaded;
        public event EventHandler<Classes.PS3.Ps3SaveData> OnSavedataDownloaded;
        public event EventHandler<string> OnLog;
        private Dictionary<string, Bitmap> _friends;
        private long _sizeTrace = 0;
        private int _elapsedUpdatedTwelfths = 0;
        private int _toPlayingAlert = 0;
        private string _uiExplorerPath = "/dev_hdd0";
        private bool _busyDownloader = false;
        public MainForm() => InitializeComponent();
        public void WSize()
            => Data.Log("used data length: " + _sizeTrace.ToBytesRepresentationString());
        public void UIT(Action perform)
        {
            new Thread(() => MainThread.Invoke(this, perform)).Start();
        }
        public void DUI(Action perform) => MainThread.Invoke(this, perform);
        internal void SetScalePlus(decimal plus)
        {
            foreach (Control c in Controls)
            {
                c.Font =
                    new Font(c.Font.FontFamily.Name, c.Font.Size + ((float)plus));
            }
        }
        public void T(Action perform) => new Thread(() => perform()).Start();
        public void SetAddress(string addr)
        {
            if (IPAddress.TryParse(addr, out _))
            {
                this._address = addr;
            }
            else throw new FormatException("Address string is on invalid format, or contains invalid chars.");
        }
        internal int GetFan
        {
            get
            {
                var strspd = _playstation3.Client.FanSpeedPercentage;
                var perc = strspd.IndexOf('%');
                var val = strspd.Substring(perc - 3, 3);
                return int.Parse(val);
            }
        }
        public string GetAddress() => _address?.Clone() as string;
        public void SpinnerShow() => MainThread.Invoke(this, () => ReportSpinner(2));
        public void SpinnerHide() => MainThread.Invoke(this, () => ReportSpinner(100));
        private void UIpdate()
        {
            _playstation3.Client.Retrieve(
               (s, ee) =>
               {

                   Thread.Sleep(1000);
                   Data.Log("Finished retrieving info again.");
                   if (_disconnected is true)
                   {
                       if (_playstation3.Client.IsOnline)
                       {
                           Data.Log("Server reconnected.");
                           _disconnected = false;
                           SpinnerHide();
                           if (_playstation3.Manager.IsConnected is false)
                           {
                               try
                               {
                                   _playstation3.Manager.ConnectTarget(_playstation3.IP);
                                   if (_playstation3.Manager.IsConnected)
                                   {
                                       _disconnected = false;
                                       UiConnection(true);
                                   }
                               }
                               catch (Exception error)
                               {
                                   _disconnected = true;
                                   ReportSpinner(20);
                                   UIT(() => UiConnection(false));
                                   new MessageForm().ShowTemporal(
                                       $"Server disconnected with message: {error.Message}", "Information", 5000);
                               }
                           }
                       }

                   }
                   if (_playstation3.Client.IsOnline & _playstation3.IsInitialized & (!_playstation3.IsBusy) & (_disconnected is false))
                   {
                       UIT(UiPlot);
                       UIT(RPC);
                       SpinnerHide();
                       DynamicPlayingAlert();
                   }
                   else
                   {
                       SetGuiWaitOfflineMode();
                   }
               });
            _elapsedUpdatedTwelfths++;
        }
        private void Updater_Tick(object sender, EventArgs e)
        {
            T(async () =>
            {
                Data.Log($"Server updater fired twelfth heartbeat this {_elapsedUpdatedTwelfths} time.");
                var reached = await Reach(_playstation3.AccessUrl.Replace("ftp", "http"), 2000);
                if (reached)
                {
                    UIpdate();
                }
                else SetGuiWaitOfflineMode();
                DUI(() => LabelUpdatesCount.Text = $"! Twelfth Clock Has Ticked {_elapsedUpdatedTwelfths} Times.");
            });
        }
        internal void SetGuiWaitOfflineMode()
        {
            _disconnected = true;
            SpinnerShow();
            Data.Log("Server is offline. Wait for it.");
        }
        internal void ding() => SystemSounds.Asterisk.Play();
        internal void ReportOperation(string statusMessage, int progress = 1)
        {
            ProgressBarSubProcess.Value = progress > -1 ? progress : 0;
            LabelSubProcessIndicator.Text = statusMessage;
        }
        internal void ReportOperation(bool visible)
        {
            ProgressBarSubProcess.Value = visible ? ProgressBarSubProcess.Value : 0;
            PanelSubProcessIndicator.Visible = visible;
            if (visible) PanelSubProcessIndicator.BringToFront();
            else PanelSubProcessIndicator.SendToBack();
        }
        internal void ReportSpinner(int pg)
        {
            DUI(() =>
            {
                LabelIndicatorMessage.Visible = ProgressBarLoading.Visible = pg < 100 & pg > 0;
                ProgressBarLoading.Value = pg <= 0 ? 0 : pg;
                ProgressBarLoading.Visible = pg > 1 & pg < 99;
                ProgressBarLoading.Location = this.GetCenter(ProgressBarLoading);
                MainContainer.Visible = !ProgressBarLoading.Visible;
                if (PanelLoading.Visible = !MainContainer.Visible)
                {
                    PanelLoading.BringToFront();
                }
                else PanelLoading.SendToBack();
                LabelIndicatorMessage.Text = "Please wait...";
                if (_playstation3 != null & _playstation3.Client != null)
                {
                    var online = _playstation3.Client.IsOnline;
                    UiConnection(online);
                }
            });
        }
        internal void UiConnection(bool toggle)
        {
            DUI(() =>
            {
                switch (toggle)
                {
                    case true:
                        {
                            PanelLoading.Visible = false;
                            MainContainer.Show();
                            MainContainer.BringToFront();
                            break;
                        }
                    case false:
                        {
                            MainContainer.Visible = false;
                            PanelLoading.Show();
                            PanelLoading.BringToFront();
                            break;
                        }
                }
            });

        }
        internal void ExplorerRequestToDownload()
        {
            if (_busyDownloader) new MessageForm().ShowTemporal("Cant download multiple files simultaneosly, not implemented yet.", "Cannot download", 3000);
            else
            {
                var selected = ListControlContents.SelectedIndex;
                if (selected != -1)
                {
                    var item = ListControlContents.Items[selected] as string;
                    if (item != null & item is string)
                    {
                        if (Path.HasExtension(item))
                        {
                            var ext = Path.GetExtension(item);
                            var sfd = new SaveFileDialog()
                            {
                                Title = $"Select where to download {item}",
                                Filter = $"{ext.Replace('.', '\0').ToUpper()}|*{ext}",
                                AddExtension = true,
                                FileName = item.GetFileName()
                            };
                            var response = sfd.ShowDialog();
                            if (response is DialogResult.OK)
                            {
                                ReportOperation(true);
                                var url = $"{_playstation3.AccessUrl}/{_uiExplorerPath}/{item}";
                                Debug.WriteLine($"DOWNLOADING {url}", "DL");
                                ding();
                                FTP.Download(sfd.FileName, url, "", "", OnContentDownloadProgression(item), ThreadPriority.BelowNormal);
                            }
                            sfd.Dispose();
                        }
                    }


                }

            }
        }
        internal EventHandler<System.Pair<int>> OnContentDownloadProgression(string name)
        {
            return (s, e) =>
            {
                var position = (e.X / 1024) / 1024;
                var size = (e.Y / 1024) / 1024;

                if (position.BetweenAnd(0, size))
                {
                    DUI(() =>
                    {
                        ReportOperation($"Downloading: {name} ({position}|{size})", (position * 100 / size));
                    });
                    if (position == size)
                    {
                        new MessageForm().ShowTemporal("The file \"{name}\" has been downloaded sucessfully.", "Finished", 5000);
                    }
                }

            };
        }
        internal void DynamicPlayingAlert()
        {
            if (_toPlayingAlert >= 20)
            {
                NotificationPlayState();
                _toPlayingAlert = 0;
            }
            else _toPlayingAlert++;
        }
        internal void NotificationPlayState()
        {
            var r = "You re playing {0} for already {1} minutes";
            var client = _playstation3.Client;
            if (client.IsInGame)
            {
                var time = client.SystemInGameTime;
                var playedHour = time.Hours > 0;
                var playedMin = time.Minutes > 5;
                var pnameShort = client.ProcessName.ToAcronymous();
                if (playedMin & (!playedHour))
                {
                    r = string.Format(r, pnameShort, time.Minutes);
                    client.Notification(r, WmmIcons.playerIcon, 5);
                }
                else if (playedHour)
                {
                    r = "You re playing {0} for already {1} hour and {2} minutes!";
                    r = string.Format(r, pnameShort, time.Hours, time.Minutes);
                    client.Notification(r, WmmIcons.playerIcon, 5);
                }

            }
            else return;

        }
        /// <summary>
        /// Loads the UI and system structure.
        /// </summary>
        /// <param name="address">The target ip address reference of a external ps3 system on the network to connect.</param>
        public void LoadThis(string address)
        {
            GunaTaskBarIndicator.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Indeterminate;
            SetAddress(address);
            Properties.Settings.Default.PropertyChanged += (s, e) => ButtonSaveConfig.Visible = true;
            Data.OnWarningMessage += OnLogMessage;
            _friends = new Dictionary<string, Bitmap>();
            _playstation3 =
                new PS3System(
                address,
                7887,
                credentials: new NetworkCredential("", ""),
                (s, e) => OnInitializationBegin?.Invoke(s, e),
                (s, e) => OnInitializationFinish(s, e),
                (s, e) => OnInitializationProgress(e),
                (s, e) => OnParamSfoReceived(e),
                (s, e) => OnFriendUpdated(e),
                null,
                (s, e) => OnSavedataFetched(e),
                (s, e) => OnExceptionCaught(this, e));
            GunaTaskBarIndicator.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Normal;
        }
        /// <summary>
        /// Redraws all UI information, displaying new content of the updated structure.
        /// </summary>
        private void UiPlot()
        {

            var server = _playstation3.Client;
            MainContainer.Visible = true;
            LabelFanSpeedPerc.Text = $"{GetFan}%";
            GunaTaskBarIndicator.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Indeterminate;
            LabelProcessName.Text = (server.ProcessName != "" & server.IsInGame) ? server.ProcessName : "XMB";
            var s1 = (server.IsInGame ? "InGame" : "XMB");
            var s2 = server.CurrentUser ?? server.CurrentUserPSN ?? Environment.UserName;
            var s3 = (server.IsInGame ? server.SystemInGameTime : server.SystemStartupTime).ToString();
            LabelGameTimestamp.Text = s3;
            LabelUserName.Text = s2;
            uint tmpCpu, tmpRsx = 0;

            _playstation3.Manager.PS3.GetTemperature(out tmpCpu, out tmpRsx);
            var infoString = $"CPU: {tmpCpu} | RSX: {tmpRsx}\n" +
            _playstation3.PsnGames.TitlesSfo.Length + " Games.\n" +
            $"PSN: {server.CurrentUserPSN}\n{server.HardDiskString}\n{server.FanSpeedPercentage}\n{server.MemoryString}\nPID: {server.ProcessId}\n" +
            $"System Name: {_playstation3.SystemName}";
            this.LabelInformation.Text = infoString;
            this.Text = $"mmCM Manager for PlayStation 3 | {s1} | {s2} | {s3} | powered by Guna.";
            WSize();
            if (server.CurrentUserDirectory != "")
            {
                T(() =>
                {
                    Reach(server.CurrentUserDirectory + "/localusername", 10000).ContinueWith(
                        (s) =>
                        {
                            if (s.Result is true)
                            {
                                Console.WriteLine("Reached usdir!.");
                                var avatar = Data.DownloadBitmap(server.CurrentUserDirectory + "/friendim/avatar/me.png");
                                UIT(() => PictureBoxAvatar.Image = avatar);
                            }
                        });
                });

            }
            try
            {
                if (server.IsInGame)
                {
                    if (server.ProcessPath != "")
                    {
                        var icon = $"http://{_address}" + server.ProcessPath + "/ICON0.PNG";
                        var bmp = Data.DownloadBitmap(icon);
                        if (bmp != null)
                        {
                            UIT(() => PictureBoxPlayerGameCover.Image = bmp);
                        }
                    }
                }
            }
            catch
            { }
            GunaTaskBarIndicator.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Normal;


        }
        #region Events
        internal void OnExceptionCaught(object sender, Exception arg)
        {
            Data.Log((sender != null).ToString());
            MainThread.Invoke(this, () =>
            {
                Data.Log("Exception caught while initialization process running. ");
                var t = arg.GetType();
                var props = t.GetProperties();
                string propStrings = "";
                foreach (var prop in props)
                {
                    if (prop.CanRead)
                    {
                        try
                        {
                            propStrings += $"{prop.Name} => {prop.GetValue(prop)}\n";
                        }
                        catch { }
                    }
                    // do some things
                }
                Data.Log(propStrings);
                var r = new MessageForm().ShowDialog("Error. Cannot initialize.",
                    $"Exception produced of type {t.Name}. Message: {arg.Message}", "Retry", "Exit");
                if (r == DialogResult.OK)
                {
                    Application.Exit(); Application.Restart();
                }
                else this.Close();

            });
        }

        internal void OnInitializationFinish(object sender, EventArgs e)
        {
            Data.Log(sender.ToString());
            Data.Log(e.ToString());
            Console.WriteLine(GetFan);
            // do some things
            UIT(UiPlot);
            UIT(RPC);
            UIT(() => ExplorerUpdate("/dev_hdd0"));
            UIT(() => Updater.Start());
            UIT(() =>
            {
                CheckboxSettingLogging.Checked = Properties.Settings.Default.DisableLogging;
                CheckboxSettingParams.Checked = Properties.Settings.Default.DownloadParams;
                NumericSettingTimeout.Value = Properties.Settings.Default.ConTimeout;
                CheckBoxSettingFullscreen.Checked = Properties.Settings.Default.Fullscreen;
                InputBoxAddress.Text = Properties.Settings.Default.initIpString;
                CheckboxFastStart.Checked = Properties.Settings.Default.FastStart;
                NumericSettingTimeout.ValueChanged += (s, ee) => Properties.Settings.Default.ConTimeout = NumericSettingTimeout.Value;
                NumericSettingScalePlus.ValueChanged += (s, ee) =>
                {
                    SetScalePlus(Properties.Settings.Default.ScalePlus = NumericSettingScalePlus.Value);
                };
                CheckBoxSettingFullscreen.CheckedChanged += (s, ee) => Properties.Settings.Default.Fullscreen = CheckBoxSettingFullscreen.Checked;
                InputBoxAddress.TextChanged += (s, ee) => Properties.Settings.Default.initIpString = InputBoxAddress.Text;
                CheckboxSettingParams.CheckedChanged += (x, y) => Properties.Settings.Default.DownloadParams = CheckboxSettingParams.Checked;
                CheckboxSettingLogging.CheckedChanged += (x, y) => Properties.Settings.Default.DisableLogging = CheckboxSettingLogging.Checked;
                CheckboxFastStart.CheckedChanged += (x, y) => Properties.Settings.Default.FastStart = CheckboxFastStart.Checked;
            });
            UIT(() => ChroniumFanController.Load(_playstation3.Client.GetRoot() + "/tempc.html"));
            OnInitializationFinished?.Invoke(sender, e);
        }
        private void RPC()
        {
            var client = _playstation3.Client;
            var time = client.SystemStartupTime;
            var details = $"{(client.IsInGame ? $"In Game | 🎮 {client.CurrentUserPSN}" : "XMB")} {(time != null ? time.ToString() : "")}";
            var state = (client.IsInGame) ? $"Playing {client.ProcessName} ({client.ProcessTitleId})" : $"{client.CurrentUserPSN}";
            state = _disconnected ? $"{client.CurrentUserPSN} is offline." : state;
            details = _disconnected ? $"Waiting reconnection. | {time} ago." : details;
            DiscordRPC.RichPresence get()
            {

                return
                    new DiscordRPC.RichPresence()
                    {
                        Assets = new DiscordRPC.Assets()
                        {
                            LargeImageKey = "https://avatars.githubusercontent.com/u/974897?v=4",
                            SmallImageKey = GetAvatarOrDefaultIconUrl(),
                            LargeImageText = $"commonname: {_playstation3.SystemName}, pid: {client.ProcessId}" +
                            $"{client.HardDiskString}, {client.SystemStartupTime}"
                        },
                        Details = details,
                        State = state,

                    };
            }
            if (_rpcImp is null) _rpcImp = new DiscordRPC.DiscordRpcClient("998078320350605333");
            if (!_rpcImp.IsInitialized)
            {
                _rpcImp.Initialize();
                _rpcImp.SetPresence(get());
            }
            if (_rpcImp.IsInitialized)
            {
                _rpcImp.ClearPresence();
                _rpcImp.SetPresence(get());
            }
        }
        internal void OnLogMessage(object sender, string arg)
        {
            MainThread.Invoke(this, () => LabelIndicatorMessage.Text = arg);
            MainThread.Invoke(this, () => label1.Text = Data.GetTrace());
            OnLog?.Invoke(this, arg);
        }
        internal void OnInitializationProgress(int perc)
        {
            OnInitializationProgression?.Invoke(null, perc);
            // do some things
            MainThread.Invoke(this, () => ReportSpinner(perc));
        }
        internal void OnParamSfoReceived(PS3System.ReceivedParamEventArgs arg)
        {
            OnSfoReceived?.Invoke(this, arg);
            // do some things
        }
        internal void OnFriendUpdated(in object[] arg)
        {
            OnFriendDownloaded?.Invoke(this, arg);
            if (arg.Length is 0) return;
            if (arg.Length < 2) return;
            if (!(arg[1] is string)) return;
            var data = (arg[1] as string);
            var len = Encoding.Default.GetBytes(data).Length;
            _sizeTrace += len;
            // do some things
            var name = arg[0] as string;
            var avatar = arg[1] as Bitmap;
            if (!_friends.ContainsKey(name))
            {
                _friends.Add(name, avatar);
            }

        }
        internal void OnSavedataFetched(in Classes.PS3.Ps3SaveData arg)
        {
            OnSavedataDownloaded?.Invoke(this, arg);
            // do some things
        }
        #endregion
        private async Task<bool> Reach(string url, int timeout = 5000)
        {
            try
            {
                using (var http = new HttpClient())
                {
                    http.Timeout = new TimeSpan(0, 0, 0, 0, timeout);
                    var resp = await http.GetAsync(url);
                    if (resp.StatusCode == HttpStatusCode.OK) return true;
                    else Console.WriteLine($"Reached url response code returned: [{resp.StatusCode}] ");
                    return false;
                }

            }
            catch { return false; }
        }

        private void WebManagerController_FrameLoadStart(object sender, CefSharp.FrameLoadStartEventArgs e)
        {
            MainThread.Invoke(this, () =>
            {
                var current = e.Url.GetUrlHost();
                if (current != _address)
                {
                    e.Browser.StopLoad();
                    e.Browser.MainFrame.LoadUrl(_playstation3.Client.GetHDD0());
                }
            });
        }
        private void MainForm_TextChanged(object sender, EventArgs e) => LabelFormTitle.Text = Text;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logout(() => { });
        }

        private void ButtonShutdown_Click(object sender, EventArgs e)
        {
            _playstation3.Client.SendCmd("shutdown.ps3");
        }

        private void ButonRestart_Click(object sender, EventArgs e)
        {
            _playstation3.Client.SendCmd("restart.ps3");
        }

        private void TrackbarFanSpeed_MouseUp(object sender, MouseEventArgs e)
        {
            _playstation3.Client.SendCmd($"cpursx.ps3?fan={TrackbarFanSpeed.Value}");
        }

        private void ChroniumFanController_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {
            if (e.Url.GetUrlHost() != _playstation3.IP) e.Browser.Back();
        }

        private void ChroniumFanController_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            this.ChroniumFanController.SetZoomLevel(0.6);
        }

        private void ButtonCopyXmb_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(PictureBoxXmbImage.Image);
            PictureBoxXmbImage_Click(null, null);
        }

        private void ButtonSaveXmbScreenShoot_Click(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\screenshoot_" +
                DateTime.Now.ToString("dd-MM-y  HH-mm-ss") + ".bmp";
            PictureBoxXmbImage.Image.Save(path);
            Process.Start(path);
        }

        private void PictureBoxXmbImage_Click(object sender, EventArgs e)
        {
            void SetXmb(System.Drawing.Image display) => MainThread.Invoke(this, () => PictureBoxXmbImage.Image = display);
            T(() =>
            {
                if (!_playstation3.Client.IsInGame)
                {
                    _playstation3.Client.Notification(string.Empty, WmmIcons.photo, 4);
                    try
                    {
                        var bmp = Data.DownloadBitmap(_playstation3.Client.GetRoot() + "/xmb.ps3$screenshot?show");
                        SetXmb(bmp);
                    }
                    catch
                    {
                        SetXmb(Properties.Resources.tex_broken_icon);
                    }

                }
            });
        }

        private void ButtonSaveConfig_Click(object sender, EventArgs e)
        {
            ButtonSaveConfig.Visible = false;
            Properties.Settings.Default.Save();
        }
        private void Logout(Action finish)
        {
            SpinnerShow();
            StaticOutput.Play(Properties.Resources.close);
            LabelIndicatorMessage.Text = "Disposing session and closing..\nHave a great day.";
            Thread.Sleep(1000);
            T(() =>
            {
                if (_rpcImp != null)
                {
                    _rpcImp.ClearPresence();
                    _rpcImp.Deinitialize();
                    _rpcImp.Dispose();
                }
                UIT(() => ReportSpinner(50));
                if (_playstation3.IsInitialized)
                {
                    _playstation3.RequestNotify("webMAN Listener is offline. Have a good day.", WmmIcons.offline);
                    _playstation3.Manager.DisconnectTarget();
                    Thread.Sleep(2000);
                }
                StaticOutput.Dispose();
                finish();
            });
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Logout(this.Close);
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            Logout(() =>
            {
                Application.Exit(); Application.Restart();
            });
        }

        private void LabelMin_Click(object sender, EventArgs e) => this.Size = this.MinimumSize;
        private void MainForm_SizeChanged(object sender, EventArgs e) => PanelLoading.Location = this.GetCenter(PanelLoading);
        private void ButtonChangeAddress_Click(object sender, EventArgs e)
        {
            var s = new MessageForm();
            var r = s.ShowDialog(true, "Set New Client IP Address.", "", "OK", "CANCEL");
            var parseable = IPAddress.TryParse(s.Entry, out _);
            if (r is DialogResult.OK & parseable)
            {
                Properties.Settings.Default.initIpString = s.Entry;
                Properties.Settings.Default.Save();
                Logout(() =>
                {
                    MainThread.Invoke(this, () =>
                    {
                        Updater.Stop();
                        var t = new BootupForm(true);
                        t.FormClosed += (se, ee) => this.Close();
                        this.Hide();
                        t.Show();
                    });
                });
            }
            else if (r is DialogResult.Cancel & parseable is false)
            {
                s.ShowDialog("Invalid format.", "Cannot parse input value, because doesnt have the correct format for an IPAddress.", "OK");
            }
            s.Dispose();
        }

        private void ButtonDebug1_Click(object sender, EventArgs e)
        {
            var data = PS3Data.PS3Directory.FromSystem(_playstation3, DebugTextBoxPath.Text);
            label2.Text = string.Join("\n", data.GetListing());
            label2.Text = string.Join("\n", data.GetListing());
        }
        private void ExplorerUpdate()
            => ExplorerUpdate(TextBoxPath.Text);
        private void ExplorerUpdate(string path = "/dev_hdd0")
        {
            try
            {
                var data = PS3Data.PS3Directory.FromSystem(_playstation3, path);
                var lst = data.GetListing();
                if (lst.Count() > 0) this.ListControlContents.Items.Clear();
                this.ListControlContents.Items.AddRange(lst.ToArray());
                this._uiExplorerPath = path.TrimEnd('/');
                this.TextBoxPath.Text = path;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: {err}\nAt {err.Source}\n({(uint)err.HResult})");
            }
        }
        private void ButtonRefresh_Click(object sender, EventArgs e) => ExplorerUpdate();
        private void DebugButtonTestItems_Click(object sender, EventArgs e)
        {
            PS3DirGame.FromSystem(_playstation3);
        }
        private string GetHtml(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        string result = content.ReadAsStringAsync().Result;

                        return result;
                    }
                }
            }
        }
        private void ListControlContents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selection = this.ListControlContents.SelectedIndex;
            if (selection != -1)
            {
                var dir = ListControlContents.Items[selection] as string;
                dir = dir.Trim('/', '\\');
                var curr = _uiExplorerPath.TrimEnd('/');
                if (Path.GetExtension(dir) == "")
                {
                    ExplorerUpdate(curr + "/" + dir);
                }
                else ExplorerRequestToDownload();
            }
        }

        private void ButtonBackDirectoryClicked(object sender, EventArgs e)
        {
            UIT(() =>
            {
                var dirs = _uiExplorerPath.Split('/').ToList();
                if (dirs.Count > 2)
                {
                    if (dirs.Remove(dirs.Last()))
                    {
                        var newPath = string.Join("/", dirs.ToArray());
                        Console.WriteLine(newPath);
                        ExplorerUpdate(newPath);
                    }
                }
            });
        }
        private string GetAvatarOrDefaultIconUrl()
        {
            try
            {
                var usdir = _playstation3.Client.CurrentUserDirectory;
                if (usdir != "")
                {
                    var id = usdir.Split('/').Last();
                    var avatardata = _playstation3.Client.GetHDD0() + $"/home/{id}/np_cache.dat";
                    if (FTP.GetLength(avatardata, "", "") != 0x404)
                    {
                        var txtx = Data.DownloadText(avatardata).Replace('\0', ' ');
                        txtx = txtx.TrimEnd(' ');
                        txtx = txtx.Substring(txtx.LastIndexOf(' ')).Trim();
                        return txtx;
                    }
                    else return "sony_ps";
                }
                else return "sony_ps";
            }
            catch { return "sony_ps"; }
        }
        private void ButtonDebug2_Click(object sender, EventArgs e)
        {

        }

    }
}
