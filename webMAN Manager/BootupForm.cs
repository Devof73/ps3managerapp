using PSS3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using webMAN_Manager.Classes;
using webMAN_Manager.Classes.PS3;
using webMAN_Manager.Forms;

namespace webMAN_Manager
{
    public partial class BootupForm : System.Windows.Forms.Form
    {
        public bool Noquick { get; private set; }
        public BootupForm(bool noquick = false)
        {
            InitializeComponent();
            // this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            // this.Location = new Point(0, 0);
            if (!DebugCommandsMenu.InitializedCmd) DebugCommandsMenu.Initialize();
            Noquick = noquick;
        }

        void T(Action ac)
        {
            var t = new Thread(() => ac());
            t.Priority = ThreadPriority.Normal;
            t.IsBackground = true;
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CheckProcessExistency() is true)
            {
                var r = new MessageForm().ShowDialog("You already have running MMCM on this system. Do you wanna close it?", "Kill", "Cancel");

            }
            Begin();

        }
        private bool CheckProcessExistency()
        {
            var exName = Application.ExecutablePath.GetFileName();
            var process = Process.GetProcesses().Where((S) => S.StartInfo.FileName == exName);
            return process.ToArray().Length > 5;
        }
        private void Begin()
        {
            WindowState = Properties.Settings.Default.Fullscreen ? FormWindowState.Maximized : FormWindowState.Normal;

            T(() =>
            {

                if (Properties.Settings.Default.FastStart &
                IPAddress.TryParse(Properties.Settings.Default.initIpString, out _) & (Noquick is false))
                {
                    StaticOutput.Play(Properties.Resources.boot);
                    ShowManager(Properties.Settings.Default.initIpString);
                }
                else
                {
                    Thread.Sleep(5000);
                    StaticOutput.Play(Properties.Resources.boot);
                    Thread.Sleep(2000);
                    MainThread.Invoke(this, () =>
                    {
                        if (Properties.Settings.Default.Fullscreen is false) this.Size = this.MinimumSize;
                        this.LoadingGif.Image = Properties.Resources.mmcmStatic;
                    });

                    BeginConnection();

                }


            });
        }
        private void BeginConnection()
        {
            MainThread.Invoke(this, () =>
            {


                var path = Res.WorkPath();
                var root = Res.CreateTmpDirectory("mmcm");
                var sfile = $"{root}\\settings.ini";
                bool has = File.Exists(sfile);
                if (!has) new MessageForm().ShowDialog("Information", "multiMAN will create a configuration file. Do not exit, or shutdown this computer.", "OK");
                string ip = has ? File.ReadAllLines(sfile)[0].Split(':')[1] : "no";
                bool hasno = false;
                hasno = !File.Exists(sfile);

                void GetResult(string url, int timeout, EventHandler begin, EventHandler<bool> finished)
                {
                    begin.Invoke(null, null);
                    bool ok = true;
                    var t = new Thread(() =>
                    {
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                        request.Timeout = timeout;
                        request.Method = "GET";
                        Data.Log($"Getting result for {url}");
                        try
                        {
                            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                            {
                                ok = response.StatusCode == HttpStatusCode.OK;
                            }
                        }
                        catch (Exception ex)
                        {
                            ok = false;
                            Data.Log(ex.ToString());
                            Data.Log("Response caughts an exception.");
                        }
                        finished.Invoke(this, ok);
                    });
                    t.Start();

                }
                void Connect()
                {

                    GetResult($"http://{ip}/cpursx.ps3", 2000, (s, e) =>
                    {
                        var dialog = new MessageForm();
                        dialog.ShowTemporal("Manager is trying to reach the specified address. Do not shutdown the devices.", "Please wait", "Cancel", () => dialog.Close(), 3000);
                    },
                        (s, e) =>
                        {
                            if (e)
                            {
                                Data.Log($"Bounded sucessfully to {ip}");
                                File.WriteAllText(sfile, $"ip:{ip}");
                                var msg = new MessageForm();
                                msg.FormClosed += (ss, ee) => ShowManager(ip);
                                msg.Location = this.GetCenter(msg);
                                msg.ShowTemporal($"Sucessfully connected to bound {ip}", "OK");
                            }
                            else
                            {
                                var diag = new MessageForm();
                                diag.Location = this.GetCenter(diag);
                                var r = diag.ShowDialog(true, "Cannot connect to server.", "Server is offline. Retry with another IP.", "OK", "Cancel");
                                if (r is DialogResult.Cancel)
                                {
                                    ip = diag.Entry;
                                    bool flag = IPAddress.TryParse(ip, out _);
                                    if (!flag)
                                    {
                                        new MessageForm().ShowDialog(
                                          "Error", "URI can't be parsed retry.", "OK");
                                        RequestIp();
                                    }
                                    else
                                    {
                                        Connect();
                                    }
                                }
                                else if (r == DialogResult.OK)
                                {
                                    BeginConnection();
                                }
                            }

                        });

                }
                void RequestIp()
                {
                    var ipPopup = new MessageForm();
                    var result = ipPopup.ShowDialog(true, "Login with PS3 IP Address", "", "Login", "Cancel");
                    bool flag = Uri.TryCreate(ipPopup.Entry, UriKind.RelativeOrAbsolute, out _);
                    ip = ipPopup.Entry;
                    if (flag is false)
                    {
                        new MessageForm().ShowDialog(
                       "Error", "URI can't be parsed retry.", "OK");
                        RequestIp();
                    }
                    if (result is DialogResult.OK)
                    {
                        Connect();
                    }
                    else
                    {
                        new MessageForm().ShowDialog(
                        "Error", "Cannot log in without ip", "OK");
                        Close();
                    }
                }

                if (IPAddress.TryParse(Properties.Settings.Default.initIpString, out _))
                {
                    ip = Properties.Settings.Default.initIpString;
                    Connect();
                }
                else if (hasno & ip is "no")
                {
                    RequestIp();
                }
                else if (ip != "no")
                {
                    bool flag = IPAddress.TryParse(ip, out _);
                    if (!flag)
                    {
                        new MessageForm().ShowDialog(
                          "Error", "URI can't be parsed retry.", "OK");
                        RequestIp();
                    }
                    else
                    {
                        Connect();
                    }
                }


            });

            /*
            MainThread.Invoke(this, () =>
              MessageForm.RequestResult(this, "multiMAN will create a configuration file. Do not exit, or shutdown this computer.",
                  (s, e) => MainThread.Invoke(this, () => FadeOut()), "Accept"
              ));*/
        }
        private void ShowManager(string ip)
        {
            MainThread.Invoke(this, () =>
            {
                var frm = new MainForm();
                frm.Location = this.Location;
                frm.Size = this.Size;
                frm.LoadThis(ip);
                this.Hide();
                frm.FormClosed += (s, e) => this.Close();
                frm.Show();
            });

        }
        private void FadeOut()
        {
            System.Windows.Forms.Timer fo = new System.Windows.Forms.Timer();
            fo.Tick += (S, E) =>
            {
                if (this.Opacity < 0) { fo.Dispose(); Close(); }
                this.Opacity -= 0.1;
            };
            fo.Interval = 12;
            fo.Start();

        }
        /// <summary>  
        /// method for changing the opacity of an image  
        /// </summary>  
        /// <param name="image">image to set opacity on</param>  
        /// <param name="opacity">percentage of opacity</param>  
        /// <returns></returns>  
        public Image SetImageOpacity(Image image, float opacity)
        {
            try
            {
                //create a Bitmap the size of the image provided  
                Bitmap bmp = new Bitmap(image.Width, image.Height);

                //create a graphics object from the image  
                using (Graphics gfx = Graphics.FromImage(bmp))
                {

                    //create a color matrix object  
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity  
                    matrix.Matrix33 = opacity;

                    //create image attributes  
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void LoadingSpinner_Click(object sender, EventArgs e)
        {

            DebugCommandsMenu.Show(this, false);
        }

        private void LoadingGif_Click(object sender, EventArgs e)
        {
            Process.Start("https://paypal.me/WEBPLUGINS");
        }
    }
}
