
using webMAN_Manager.Classes.PS3;
using System;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webMAN_Manager.Classes
{
    [DebuggerDisplay("Initialized: {IsInitialized} | Busy: {IsBusy} | {AccessUrl}")]
    public class PS3System
    {
        private Ps3SystemUser[] _users;
        private PS3MAPI _manager;
        private PS3WMM _webMAN;
        private Ps3Games _games;
        private Command _commander;
        public event EventHandler<Exception> Error;
        public Ps3SaveData[] SaveDatasCurrentUser { get; private set; }
        public Ps3SystemUser CurrentUser { get; private set; }
        public string SystemName { get; private set; }
        public event EventHandler<ReceivedParamEventArgs> OnParamReceived;
        public event EventHandler<DataUpdatedEventArgs> OnValuesUpdated;
        public event EventHandler<object[]> OnNewFriendDetected;
        public event EventHandler<Ps3SystemUser> OnUserChanged;
        public static PS3System FromIpAddress(IPAddress address) => new PS3System(address.ToString());
        private string _url;
        public string AccessUrl { get => _url; }
        public string IP { get; set; }
        public int PORT { get; set; }
        public bool IsInitialized { get; private set; }
        public bool IsBusy { get; private set; }
        public NetworkCredential Credentials { get; set; }
        public PS3System()
        {
            IsInitialized = false;
        }
        public PS3System(string ip, int? port = null,
            NetworkCredential credentials = null,
            EventHandler OnInit = null,
            EventHandler OnInitFinish = null,
            EventHandler<int> onInitProgress = null,
            EventHandler<ReceivedParamEventArgs> OnParamReceived = null,
              EventHandler<object[]> OnNewFriend = null,
              EventHandler<DataUpdatedEventArgs> OnValuesUpdated = null,
              EventHandler<Ps3SaveData> OnSaveDataDetected = null,
              EventHandler<Exception> OnExceptionCaught = null)
        {
            try
            {
                this.OnParamReceived = OnParamReceived;
                this.OnNewFriendDetected = OnNewFriend;
                this.OnValuesUpdated = OnValuesUpdated;
                Init(ip, port, credentials, OnInit, OnInitFinish, onInitProgress, OnSaveDataDetected, OnExceptionCaught);
            }
            catch (Exception ee)
            {
                Error?.Invoke(this, ee);
                throw new InvalidOperationException("An error ocurred.");
            }

        }
        public void Init(string ip, int? port = null, NetworkCredential credentials = null, EventHandler OnInit = null, EventHandler OnInitFinish = null, EventHandler<int> onInitProgress = null, EventHandler<Ps3SaveData> OnSaveDataDetected = null,
            EventHandler<Exception> OnExceptionCaught = null)
        {
            IPAddress ipa;
            IPAddress.TryParse(ip, out ipa);
            PORT = port ?? 7887;
            Data.Log("Internal initialization");
            Credentials = credentials ?? new NetworkCredential("", "");
            Console.WriteLine("[!] Ps3 Initializing...");

            if (ipa != null)
            {
                OnInit?.Invoke(this, new EventArgs());
                var T1 = new Thread(() =>
                {
                    try
                    {
                        _url = $"ftp://{ipa}";
                        IP = ip;
                        _webMAN = new PS3WMM(IP);
                        _webMAN.Retrieve(null);
                        _manager = new PS3MAPI();
                        _manager.ConnectTarget(ip, PORT);
                        Data.Log("Connecting to target.");
                        SystemName = GetPS3Name(); Data.Log("System name: " + SystemName);
                        Data.Log("Updating values.");
                        UpdateValues(null, null, OnSaveDataDetected);
                        Data.Log("Initialized users and ftp.");
                        //_users = Ps3SystemUser.FromSystem(this); onInitProgress?.Invoke(this, 25);
                        _commander = Command.Instance(this);
                        onInitProgress?.Invoke(this, 35);
                        Data.Log("Initialized commands and manager...");
                        _games = Ps3Games.FromSystem(this); onInitProgress?.Invoke(this, 90);
                        if (CurrentUser != null & (Ps3Flags.DoNotParsedSaveData is false)) SaveDatasCurrentUser = Ps3SaveData.FromSystem(this, CurrentUser.USERID, OnSaveDataDetected);
                        Data.Log("Operation about to finish..."); onInitProgress?.Invoke(this, 70);
                        Data.Log("Operation finished..."); onInitProgress?.Invoke(this, 100);
                        OnInitFinish?.Invoke(this, new EventArgs());
                        IsInitialized = true;
                    }
                    catch (Exception ex)
                    {
                        string exmsg = $"\r ! Exception caught at {ex.Source}\r-{ex.Message}\rT: {ex.GetType().FullName}\rStack: {ex.StackTrace}";
                        Data.Log(exmsg);
                        if (Debugger.IsAttached)
                        {
                            throw;
                        }
                        else OnExceptionCaught?.Invoke(this, ex);
                    }

                })
                {
                };
                T1.Start();
            }
            else throw new ArgumentException("Invalid IP.");
        }
        public void RequestNotify(String message, int icon = 0)
        {
            string cmd = $"/popup.ps3?{message}&icon={icon}";
            _commander.Do(cmd);
        }
        public void FetchPrxCollection(EventHandler<object[]> onReceived)
        {

            new Thread(() =>
            {
                for (int i = 0; i < 6; i++)
                {
                    _manager.VSH_Plugin.GetInfoBySlot((uint)i, out string name, out string path);
                    onReceived?.Invoke(this, new object[] { name, path });
                }
            }).Start();
        }

        public void RefreshUser(Ps3SystemUser old, Ps3SystemUser @new, EventHandler requestToClean, EventHandler OnFinished, EventHandler<Ps3SaveData> OnSaveDataDetected = null)
        {
            var t1 = new Thread(() =>
            {
                if (old != null)
                {
                    Data.Log($"User {old.LocalUserName} logged out. Current user now is {@new.LocalUserName}");
                    requestToClean?.Invoke(this, null);
                    SaveDatasCurrentUser = Ps3SaveData.FromSystem(this, CurrentUser.USERID, OnSaveDataDetected);
                    OnUserChanged?.Invoke(this, @new);
                    OnFinished?.Invoke(this, null);
                }
                else
                {
                    Data.Log($"Current user now is {@new.LocalUserName}");
                }

            });
            t1.Start();

        }
        public void SendCommand(string command) => _commander.Do(command);
        internal void OnParamReceivedEvent(object sender, in PS3ParamSfo e)
        {
            Data.Log("Param received with title: " + e.Title);
            OnParamReceived?.Invoke(sender, new ReceivedParamEventArgs(e));
        }
        internal void OnValuesUpdatedEvent(object sender, Ps3SystemUser user, object[] values)
        {
            OnValuesUpdated?.Invoke(sender, new DataUpdatedEventArgs(user, values));
        }
        public string[] GetFriendimNames()
        {
            if (CurrentUser == null || CurrentUser.FriendNames == null || CurrentUser.FriendNames.Length == 0)
            {
                return new string[0];
            }
            else return CurrentUser.FriendNamesString;
        }
        internal void OnFriendDetected(object sender, string name, Bitmap Icon)
        {
            if (CurrentUser == null)
            {
                OnNewFriendDetected?.Invoke(sender ?? this, new object[] { name, Icon });
                return;
            }
            else if (!CurrentUser.FriendNames.Contains(new Ps3Property("text", "friend", Icon)))
            {
                OnNewFriendDetected?.Invoke(sender ?? this, new object[] { name, Icon });
            }
        }
        public Ps3SystemUser[] Users { get => _users; }

        /// <summary>
        /// WebMan client of this system.
        /// </summary>
        /// <summary>
        /// WEBMANs Manager API Client of this system.
        /// </summary>
        public PS3MAPI Manager { get => _manager; }
        /// <summary>
        /// List of dev_hdd0 games on this system.
        /// </summary>
        public Ps3Games PsnGames { get => _games; }
        /// <summary>
        /// List of packages 
        /// </summary>
        public PS3WMM Client { get => _webMAN; }
        public static bool IsTitleId(in string titleId)
        {
            var flag1 = titleId.Length == 8;
            if (!flag1) return false;
            bool flag2 = true;

            foreach (char c in titleId.Substring(4))
            {
                if (char.IsNumber(c)) return false;
            }
            return flag1 & flag2;
        }
        internal bool _firstUpdate = true;
        public void UpdateValues(EventHandler SdCleanRequest, EventHandler UserRefreshingFinished, EventHandler<Ps3SaveData> OnSaveDataDetected = null)
        {
            IsBusy = true;
            try
            {
                _webMAN.Retrieve((S, E) =>
                {
                    if (!_manager.IsConnected) _manager.ConnectTarget(IP, PORT);
                    var dir = _webMAN.CurrentUserDirectory;
                    Console.WriteLine("Current userdir is " + dir);
                    var newuser = Ps3SystemUser.ParseFromDirectory(dir, this);
                    var olduser = CurrentUser;
                    CurrentUser = newuser;
                    var id = (CurrentUser?.USERID) ?? 0;

                    if (newuser != null & newuser.USERID != id & olduser != null)
                    {
                        this.OnUserChanged?.Invoke(null, newuser);
                        RefreshUser(olduser, newuser, UserRefreshingFinished, SdCleanRequest, OnSaveDataDetected);
                    }
                    else if (olduser == null & _firstUpdate)
                    {
                        RefreshUser(olduser, newuser, UserRefreshingFinished, SdCleanRequest, OnSaveDataDetected);
                    }
                    _firstUpdate = false;
                    IsBusy = false;

                });


            }
            catch (Exception ee)
            {
                Error?.Invoke(this, ee);
                IsBusy = false;
            }
        }
        public class ReceivedParamEventArgs : EventArgs
        {
            public PS3ParamSfo SFO { get; private set; }
            public ReceivedParamEventArgs(PS3ParamSfo sfo)
            {
                SFO = sfo;
            }
        }
        public class DataUpdatedEventArgs : EventArgs
        {
            public object[] values;
            public Ps3SystemUser _user;
            public DataUpdatedEventArgs(Ps3SystemUser user, object[] values)
            {
                _user = user;
                this.values = values;
            }
        }
        private string GetPS3Name()
        {
            try
            {
                var key = "/setting/system/nickname";
                var location = "/dev_flash2/etc/xRegistry.sys";
                byte[] xreg = Data.Download($"http://{IP}{location}");
                var dir = Environment.GetEnvironmentVariable("TEMP");
                var local = dir + "\\p3manager.sys";
                File.WriteAllBytes(local, xreg);

                var regr = new PS3RegRead();
                regr.Load(local);
                foreach (var entry in regr.DataEntries)
                {
                    if (entry.FileNameEntry != null)
                    {
                        if (entry.FileNameEntry.Setting == key)
                        {
                            return entry.ValueString;
                        }
                    }
                }
                return null;
            }
            catch
            {
                return $"UNK_PS3{new Random().Next(10000000)}";
            }

        }
        public static string StaticGetPS3Name(string ps3Ip)
        {
            try
            {
                var key = "/setting/system/nickname";
                var location = "/dev_flash2/etc/xRegistry.sys";
                byte[] xreg = Data.Download($"http://{ps3Ip}{location}");
                var dir = Environment.GetEnvironmentVariable("TEMP");
                var local = dir + "\\p3manager.sys";
                File.WriteAllBytes(local, xreg);

                var regr = new PS3RegRead();
                regr.Load(local);
                foreach (var entry in regr.DataEntries)
                {
                    if (entry.FileNameEntry != null)
                    {
                        if (entry.FileNameEntry.Setting == key)
                        {
                            return entry.ValueString;
                        }
                    }
                }
                return null;
            }
            catch
            {
                return $"UNK_PS3{new Random().Next(10000000)}";
            }

        }
        public static string FormatUserId(int userid)
        {
            var s = "00000000";
            var usts = userid.ToString();
            s = s.Substring(0, s.Length - usts.Length);
            return s + usts;
        }
        public static bool IsWebMAN(string ip)
        {
            string url = $"ftp://{ip}/dev_hdd0/tmp/wm_config.bin";
            return Data.Download(url) != null;
        }

        public static bool IsWebMAN(string ip, out Exception error)
        {
            try
            {
                string url = $"ftp://{ip}/dev_hdd0/tmp/wm_config.bin";
                error = null;
                return Data.Download(url) != null;
            }
            catch (Exception ex)
            {
                error = ex;
                return false;
            }
        }
    }
}