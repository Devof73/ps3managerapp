namespace webMAN_Manager.Forms
{
    partial class MessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.BorderlessController = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.InputBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.BoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // BorderlessController
            // 
            this.BorderlessController.AnimateWindow = true;
            this.BorderlessController.BorderRadius = 20;
            this.BorderlessController.ContainerControl = this;
            this.BorderlessController.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessController.TransparentWhileDrag = true;
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.Animated = true;
            this.Button1.BorderRadius = 5;
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button1.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(279, 182);
            this.Button1.MinimumSize = new System.Drawing.Size(108, 26);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(108, 26);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Button1";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.Animated = true;
            this.Button2.BorderRadius = 5;
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button2.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(165, 182);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(108, 26);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Button2";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // LabelMessage
            // 
            this.LabelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMessage.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.ForeColor = System.Drawing.Color.White;
            this.LabelMessage.Location = new System.Drawing.Point(23, 48);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(350, 115);
            this.LabelMessage.TabIndex = 2;
            this.LabelMessage.Text = "String Text";
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitle.AutoEllipsis = true;
            this.LabelTitle.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(25, 17);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(348, 27);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "String Title";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Animated = true;
            this.InputBox.AutoSize = true;
            this.InputBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.InputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputBox.DefaultText = "";
            this.InputBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.InputBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputBox.Location = new System.Drawing.Point(23, 48);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.PasswordChar = '\0';
            this.InputBox.PlaceholderText = "";
            this.InputBox.SelectedText = "";
            this.InputBox.Size = new System.Drawing.Size(350, 115);
            this.InputBox.TabIndex = 4;
            this.InputBox.Visible = false;
            // 
            // BoxClose
            // 
            this.BoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxClose.BackColor = System.Drawing.Color.Transparent;
            this.BoxClose.FillColor = System.Drawing.Color.Transparent;
            this.BoxClose.IconColor = System.Drawing.Color.White;
            this.BoxClose.Location = new System.Drawing.Point(353, 0);
            this.BoxClose.Name = "BoxClose";
            this.BoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BoxClose.Size = new System.Drawing.Size(45, 29);
            this.BoxClose.TabIndex = 7;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(399, 220);
            this.Controls.Add(this.BoxClose);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Message";
            this.Activated += new System.EventHandler(this.MessageForm_Activated);
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.Enter += new System.EventHandler(this.MessageForm_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessController;
        private Guna.UI2.WinForms.Guna2Button Button2;
        private Guna.UI2.WinForms.Guna2Button Button1;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Label LabelTitle;
        private Guna.UI2.WinForms.Guna2TextBox InputBox;
        private Guna.UI2.WinForms.Guna2ControlBox BoxClose;
    }
}