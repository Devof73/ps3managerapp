using PSS3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webMAN_Manager.Forms
{
    public partial class MessageForm : System.Windows.Forms.Form
    {
        private bool _prompt;
        private string _entry;

        public string Entry { get => _entry; }
        public bool IsValueInput { get => _prompt; }

        public MessageForm()
        {
            InitializeComponent();
            _prompt = false;
            _entry = "";
            StartPosition = FormStartPosition.CenterParent;
            CenterToParent();
        }

        public void PopupInfo(System.Windows.Forms.Form sender, string title, string message, string acceptText = null, EventHandler<DialogResult> onInteracted = null)
        {
            Button2.Visible = false;
            Button1.Text = acceptText ?? "OK";
            LabelMessage.Text = message;
            LabelTitle.Text = title;
            this.TopLevel = false;
            this.Location = sender.GetCenter(this);
            this.BringToFront();
            this.Focus();
            this.StartPosition = FormStartPosition.CenterParent;
            sender.Controls.Add(this);
            Button1.Click += (se, e) => onInteracted?.Invoke(null, Button1.DialogResult);
            this.Show();
        }
        public DialogResult ShowDialog(string title, string message, string acceptText)
        {
            Button2.Visible = false;
            Button1.Text = acceptText;
            LabelMessage.Text = message;
            LabelTitle.Text = title;
            InputBox.Visible = false;
            this.StartPosition = FormStartPosition.CenterParent;
            return this.ShowDialog();
        }
        public DialogResult ShowDialog(string title, string message, string acceptText, string declineText)
        {
            Button2.Visible = true;
            Button1.Text = declineText;
            Button1.Visible = true;
            Button2.Text = acceptText;
            LabelMessage.Text = message;
            LabelTitle.Text = title;
            this.StartPosition = FormStartPosition.CenterParent;
            return this.ShowDialog();
        }
        public DialogResult ShowDialog(bool userInput, string title, string message, string acceptText, string cancelText)
        {
            Button2.Visible = true;
            Button1.Text = cancelText;
            Button1.Visible = true;
            Button2.Text = acceptText;
            LabelMessage.Text = message;
            InputBox.Visible = userInput;
            InputBox.TextChanged += (s, e) =>
            {
                _entry = InputBox.Text;
            };
            LabelTitle.Text = title;
            LabelMessage.Visible = !userInput;
            Button1.DialogResult = DialogResult.OK;
            Button2.DialogResult = DialogResult.Cancel;
            this.StartPosition = FormStartPosition.CenterParent;
            return this.ShowDialog();
        }
        public void ShowTemporal(string message, string title, int delay = 3000)
        {
            Button1.Visible = Button2.Visible = false;
            LabelMessage.Text = message;
            LabelTitle.Text = title;
            InputBox.Visible = false;
            var waiter = new Thread(() =>
            {
                Thread.Sleep(delay);
                MainThread.Invoke(this, () => Close());
            });
            waiter.Start();
            ShowDialog();
        }
        public void ShowTemporal(string message, string title, string button1, Action onClicked, int delay = 3000)
        {
            Button2.Visible = false;
            LabelMessage.Text = message;
            LabelTitle.Text = title;
            this.Location = Screen.FromControl(this).Bounds.Size.GetCenter((this.Width / 2).Negate(), (this.Height / 2).Negate());
            InputBox.Visible = false;
            Button1.Text = button1;
            Button1.Click += (s, e) => onClicked();
            var waiter = new Thread(() =>
            {
                Thread.Sleep(delay);
                MainThread.Invoke(this, () => Close());
            });
            waiter.Start();
            ShowDialog();
        }
        public static void RequestResult(System.Windows.Forms.Form sender, string title, string message, EventHandler<DialogResult> OnInteracted = null, string buttonText = null)
        {
            new MessageForm().PopupInfo(sender, title, message, buttonText ?? "OK", OnInteracted);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void MessageForm_Enter(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void MessageForm_Activated(object sender, EventArgs e)
        {
            CenterToParent();
        }
    }
}
