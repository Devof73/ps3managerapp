using CefSharp;
using webMAN_Manager.Classes;

namespace webMAN_Manager.Forms
{
    partial class MainForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <
        /// name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat2 = new System.Drawing.StringFormat();
            this.MainBorderlessController = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.MainContainer = new System.Windows.Forms.Panel();
            this.TabContainer = new Guna.UI2.WinForms.Guna2TabControl();
            this.TabPageStatus = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LabelMin = new System.Windows.Forms.Label();
            this.PictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.LabelGameTimestamp = new System.Windows.Forms.Label();
            this.LabelProcessName = new System.Windows.Forms.Label();
            this.PictureBoxPlayerGameCover = new System.Windows.Forms.PictureBox();
            this.StatePanel2Container = new System.Windows.Forms.SplitContainer();
            this.LabelInformation = new System.Windows.Forms.Label();
            this.SubContainer1Xmb = new System.Windows.Forms.SplitContainer();
            this.PictureBoxXmbImage = new System.Windows.Forms.PictureBox();
            this.SubSplitButtons = new System.Windows.Forms.SplitContainer();
            this.ButtonSaveXmbScreenShoot = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCopyXmb = new Guna.UI2.WinForms.Guna2Button();
            this.TabPageContent = new System.Windows.Forms.TabPage();
            this.ListControlContents = new ExtendedControls.ListControl();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.TextBoxPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.TabPageNews = new System.Windows.Forms.TabPage();
            this.TabPageGAME = new System.Windows.Forms.TabPage();
            this.ListControlGames = new ExtendedControls.ListControl();
            this.TabPagePower = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ButtonShutdown = new Guna.UI2.WinForms.Guna2Button();
            this.ButonRestart = new Guna.UI2.WinForms.Guna2Button();
            this.ChroniumFanController = new CefSharp.WinForms.ChromiumWebBrowser();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.TrackbarFanSpeed = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFanSpeedPerc = new System.Windows.Forms.Label();
            this.TabPageSettings = new System.Windows.Forms.TabPage();
            this.LabelUpdatesCount = new System.Windows.Forms.Label();
            this.NumericSettingTimeout = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.CheckboxFastStart = new Guna.UI2.WinForms.Guna2CheckBox();
            this.LabelIndicator2 = new System.Windows.Forms.Label();
            this.CheckBoxSettingFullscreen = new Guna.UI2.WinForms.Guna2CheckBox();
            this.LabelIndicator1 = new System.Windows.Forms.Label();
            this.InputBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.CheckboxSettingParams = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CheckboxSettingLogging = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ButtonRestart = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonExit = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSaveConfig = new Guna.UI2.WinForms.Guna2Button();
            this.TabPageDebug = new System.Windows.Forms.TabPage();
            this.ButtonDebug2 = new Guna.UI2.WinForms.Guna2Button();
            this.DebugButtonTestItems = new Guna.UI2.WinForms.Guna2Button();
            this.NumericSettingScalePlus = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DebugContainerFetch = new System.Windows.Forms.SplitContainer();
            this.DebugTextBoxPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonDebug1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.RichTextBox();
            this.LabelIndicatorMessage = new System.Windows.Forms.Label();
            this.WindowTop = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BoxMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.IconDisplay = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LabelFormTitle = new System.Windows.Forms.Label();
            this.TopDraggerController = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MainResizeController = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.Updater = new System.Windows.Forms.Timer(this.components);
            this.PanelLoading = new System.Windows.Forms.Panel();
            this.ProgressBarLoading = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Spinner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ButtonChangeAddress = new Guna.UI2.WinForms.Guna2Button();
            this.GunaTaskBarIndicator = new Guna.UI2.WinForms.Guna2TaskBarProgress(this.components);
            this.Controller1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Controller2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ProgressBarSubProcess = new MetroFramework.Controls.MetroProgressBar();
            this.LabelSubProcessIndicator = new System.Windows.Forms.Label();
            this.PanelSubProcessIndicator = new System.Windows.Forms.Panel();
            this.MainContainer.SuspendLayout();
            this.TabContainer.SuspendLayout();
            this.TabPageStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayerGameCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatePanel2Container)).BeginInit();
            this.StatePanel2Container.Panel1.SuspendLayout();
            this.StatePanel2Container.Panel2.SuspendLayout();
            this.StatePanel2Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubContainer1Xmb)).BeginInit();
            this.SubContainer1Xmb.Panel1.SuspendLayout();
            this.SubContainer1Xmb.Panel2.SuspendLayout();
            this.SubContainer1Xmb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxXmbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubSplitButtons)).BeginInit();
            this.SubSplitButtons.Panel1.SuspendLayout();
            this.SubSplitButtons.Panel2.SuspendLayout();
            this.SubSplitButtons.SuspendLayout();
            this.TabPageContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.TabPageGAME.SuspendLayout();
            this.TabPagePower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.TabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSettingTimeout)).BeginInit();
            this.TabPageDebug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSettingScalePlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebugContainerFetch)).BeginInit();
            this.DebugContainerFetch.Panel1.SuspendLayout();
            this.DebugContainerFetch.Panel2.SuspendLayout();
            this.DebugContainerFetch.SuspendLayout();
            this.WindowTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconDisplay)).BeginInit();
            this.PanelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spinner)).BeginInit();
            this.PanelSubProcessIndicator.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBorderlessController
            // 
            this.MainBorderlessController.AnimateWindow = true;
            this.MainBorderlessController.ContainerControl = this;
            this.MainBorderlessController.DockIndicatorTransparencyValue = 0.6D;
            this.MainBorderlessController.HasFormShadow = false;
            this.MainBorderlessController.TransparentWhileDrag = true;
            // 
            // MainContainer
            // 
            this.MainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContainer.Controls.Add(this.TabContainer);
            this.MainContainer.Location = new System.Drawing.Point(12, 36);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(578, 401);
            this.MainContainer.TabIndex = 2;
            this.MainContainer.Visible = false;
            // 
            // TabContainer
            // 
            this.TabContainer.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabContainer.Controls.Add(this.TabPageStatus);
            this.TabContainer.Controls.Add(this.TabPageContent);
            this.TabContainer.Controls.Add(this.TabPageNews);
            this.TabContainer.Controls.Add(this.TabPageGAME);
            this.TabContainer.Controls.Add(this.TabPagePower);
            this.TabContainer.Controls.Add(this.TabPageSettings);
            this.TabContainer.Controls.Add(this.TabPageDebug);
            this.TabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabContainer.ItemSize = new System.Drawing.Size(180, 40);
            this.TabContainer.Location = new System.Drawing.Point(0, 0);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.SelectedIndex = 0;
            this.TabContainer.Size = new System.Drawing.Size(578, 401);
            this.TabContainer.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabContainer.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabContainer.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabContainer.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabContainer.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabContainer.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabContainer.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.TabContainer.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabContainer.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabContainer.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TabContainer.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabContainer.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TabContainer.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabContainer.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabContainer.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabContainer.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TabContainer.TabIndex = 7;
            this.TabContainer.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            // 
            // TabPageStatus
            // 
            this.TabPageStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TabPageStatus.Controls.Add(this.splitContainer1);
            this.TabPageStatus.Location = new System.Drawing.Point(184, 4);
            this.TabPageStatus.Name = "TabPageStatus";
            this.TabPageStatus.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageStatus.Size = new System.Drawing.Size(390, 393);
            this.TabPageStatus.TabIndex = 1;
            this.TabPageStatus.Text = "State";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LabelMin);
            this.splitContainer1.Panel1.Controls.Add(this.PictureBoxAvatar);
            this.splitContainer1.Panel1.Controls.Add(this.LabelUserName);
            this.splitContainer1.Panel1.Controls.Add(this.LabelGameTimestamp);
            this.splitContainer1.Panel1.Controls.Add(this.LabelProcessName);
            this.splitContainer1.Panel1.Controls.Add(this.PictureBoxPlayerGameCover);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.StatePanel2Container);
            this.splitContainer1.Size = new System.Drawing.Size(384, 387);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 0;
            // 
            // LabelMin
            // 
            this.LabelMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMin.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelMin.Location = new System.Drawing.Point(333, 38);
            this.LabelMin.Name = "LabelMin";
            this.LabelMin.Size = new System.Drawing.Size(39, 24);
            this.LabelMin.TabIndex = 11;
            this.LabelMin.Text = "Min.";
            this.LabelMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMin.Click += new System.EventHandler(this.LabelMin_Click);
            // 
            // PictureBoxAvatar
            // 
            this.PictureBoxAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxAvatar.Enabled = false;
            this.PictureBoxAvatar.Image = global::webMAN_Manager.Properties.Resources.tex_Avatar_Default;
            this.PictureBoxAvatar.Location = new System.Drawing.Point(332, 65);
            this.PictureBoxAvatar.Name = "PictureBoxAvatar";
            this.PictureBoxAvatar.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAvatar.TabIndex = 7;
            this.PictureBoxAvatar.TabStop = false;
            // 
            // LabelUserName
            // 
            this.LabelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUserName.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelUserName.Location = new System.Drawing.Point(286, 18);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelUserName.Size = new System.Drawing.Size(78, 13);
            this.LabelUserName.TabIndex = 6;
            this.LabelUserName.Text = "User1";
            this.LabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelGameTimestamp
            // 
            this.LabelGameTimestamp.AutoSize = true;
            this.LabelGameTimestamp.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameTimestamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelGameTimestamp.Location = new System.Drawing.Point(177, 81);
            this.LabelGameTimestamp.Name = "LabelGameTimestamp";
            this.LabelGameTimestamp.Size = new System.Drawing.Size(45, 13);
            this.LabelGameTimestamp.TabIndex = 4;
            this.LabelGameTimestamp.Text = "--:--:--";
            // 
            // LabelProcessName
            // 
            this.LabelProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelProcessName.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProcessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelProcessName.Location = new System.Drawing.Point(177, 25);
            this.LabelProcessName.Name = "LabelProcessName";
            this.LabelProcessName.Size = new System.Drawing.Size(125, 25);
            this.LabelProcessName.TabIndex = 3;
            this.LabelProcessName.Text = "Unknown Process";
            // 
            // PictureBoxPlayerGameCover
            // 
            this.PictureBoxPlayerGameCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxPlayerGameCover.Enabled = false;
            this.PictureBoxPlayerGameCover.Image = global::webMAN_Manager.Properties.Resources.game_tex_default_ps3;
            this.PictureBoxPlayerGameCover.Location = new System.Drawing.Point(17, 25);
            this.PictureBoxPlayerGameCover.Name = "PictureBoxPlayerGameCover";
            this.PictureBoxPlayerGameCover.Size = new System.Drawing.Size(154, 78);
            this.PictureBoxPlayerGameCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPlayerGameCover.TabIndex = 1;
            this.PictureBoxPlayerGameCover.TabStop = false;
            // 
            // StatePanel2Container
            // 
            this.StatePanel2Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatePanel2Container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.StatePanel2Container.Location = new System.Drawing.Point(0, 0);
            this.StatePanel2Container.Name = "StatePanel2Container";
            this.StatePanel2Container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // StatePanel2Container.Panel1
            // 
            this.StatePanel2Container.Panel1.Controls.Add(this.LabelInformation);
            // 
            // StatePanel2Container.Panel2
            // 
            this.StatePanel2Container.Panel2.Controls.Add(this.SubContainer1Xmb);
            this.StatePanel2Container.Size = new System.Drawing.Size(384, 267);
            this.StatePanel2Container.SplitterDistance = 131;
            this.StatePanel2Container.TabIndex = 9;
            // 
            // LabelInformation
            // 
            this.LabelInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelInformation.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelInformation.Location = new System.Drawing.Point(0, 0);
            this.LabelInformation.Name = "LabelInformation";
            this.LabelInformation.Size = new System.Drawing.Size(384, 131);
            this.LabelInformation.TabIndex = 8;
            this.LabelInformation.Text = "No information available yet.";
            // 
            // SubContainer1Xmb
            // 
            this.SubContainer1Xmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubContainer1Xmb.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SubContainer1Xmb.Location = new System.Drawing.Point(0, 0);
            this.SubContainer1Xmb.Name = "SubContainer1Xmb";
            this.SubContainer1Xmb.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SubContainer1Xmb.Panel1
            // 
            this.SubContainer1Xmb.Panel1.Controls.Add(this.PictureBoxXmbImage);
            // 
            // SubContainer1Xmb.Panel2
            // 
            this.SubContainer1Xmb.Panel2.Controls.Add(this.SubSplitButtons);
            this.SubContainer1Xmb.Size = new System.Drawing.Size(384, 132);
            this.SubContainer1Xmb.SplitterDistance = 85;
            this.SubContainer1Xmb.TabIndex = 1;
            // 
            // PictureBoxXmbImage
            // 
            this.PictureBoxXmbImage.BackColor = System.Drawing.Color.Black;
            this.PictureBoxXmbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxXmbImage.Image = global::webMAN_Manager.Properties.Resources.tex_user1;
            this.PictureBoxXmbImage.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxXmbImage.Name = "PictureBoxXmbImage";
            this.PictureBoxXmbImage.Size = new System.Drawing.Size(384, 85);
            this.PictureBoxXmbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxXmbImage.TabIndex = 0;
            this.PictureBoxXmbImage.TabStop = false;
            this.PictureBoxXmbImage.Click += new System.EventHandler(this.PictureBoxXmbImage_Click);
            // 
            // SubSplitButtons
            // 
            this.SubSplitButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubSplitButtons.Location = new System.Drawing.Point(0, 0);
            this.SubSplitButtons.Name = "SubSplitButtons";
            // 
            // SubSplitButtons.Panel1
            // 
            this.SubSplitButtons.Panel1.Controls.Add(this.ButtonSaveXmbScreenShoot);
            // 
            // SubSplitButtons.Panel2
            // 
            this.SubSplitButtons.Panel2.Controls.Add(this.ButtonCopyXmb);
            this.SubSplitButtons.Size = new System.Drawing.Size(384, 43);
            this.SubSplitButtons.SplitterDistance = 194;
            this.SubSplitButtons.TabIndex = 0;
            // 
            // ButtonSaveXmbScreenShoot
            // 
            this.ButtonSaveXmbScreenShoot.Animated = true;
            this.ButtonSaveXmbScreenShoot.BorderRadius = 5;
            this.ButtonSaveXmbScreenShoot.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonSaveXmbScreenShoot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveXmbScreenShoot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveXmbScreenShoot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSaveXmbScreenShoot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSaveXmbScreenShoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSaveXmbScreenShoot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonSaveXmbScreenShoot.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveXmbScreenShoot.ForeColor = System.Drawing.Color.White;
            this.ButtonSaveXmbScreenShoot.Image = global::webMAN_Manager.Properties.Resources.updated;
            this.ButtonSaveXmbScreenShoot.ImageSize = new System.Drawing.Size(29, 29);
            this.ButtonSaveXmbScreenShoot.Location = new System.Drawing.Point(0, 0);
            this.ButtonSaveXmbScreenShoot.Name = "ButtonSaveXmbScreenShoot";
            this.ButtonSaveXmbScreenShoot.Size = new System.Drawing.Size(194, 43);
            this.ButtonSaveXmbScreenShoot.TabIndex = 3;
            this.ButtonSaveXmbScreenShoot.Click += new System.EventHandler(this.ButtonSaveXmbScreenShoot_Click);
            // 
            // ButtonCopyXmb
            // 
            this.ButtonCopyXmb.Animated = true;
            this.ButtonCopyXmb.BorderRadius = 5;
            this.ButtonCopyXmb.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonCopyXmb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCopyXmb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCopyXmb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCopyXmb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCopyXmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCopyXmb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonCopyXmb.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCopyXmb.ForeColor = System.Drawing.Color.White;
            this.ButtonCopyXmb.Image = global::webMAN_Manager.Properties.Resources.tex_temporary_icon;
            this.ButtonCopyXmb.ImageSize = new System.Drawing.Size(29, 29);
            this.ButtonCopyXmb.Location = new System.Drawing.Point(0, 0);
            this.ButtonCopyXmb.Name = "ButtonCopyXmb";
            this.ButtonCopyXmb.Size = new System.Drawing.Size(186, 43);
            this.ButtonCopyXmb.TabIndex = 4;
            this.ButtonCopyXmb.Click += new System.EventHandler(this.ButtonCopyXmb_Click);
            // 
            // TabPageContent
            // 
            this.TabPageContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.TabPageContent.Controls.Add(this.ListControlContents);
            this.TabPageContent.Controls.Add(this.splitContainer5);
            this.TabPageContent.Location = new System.Drawing.Point(184, 4);
            this.TabPageContent.Name = "TabPageContent";
            this.TabPageContent.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageContent.Size = new System.Drawing.Size(390, 393);
            this.TabPageContent.TabIndex = 4;
            this.TabPageContent.Text = "Contents";
            // 
            // ListControlContents
            // 
            this.ListControlContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ListControlContents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ListControlContents.DefaultIcon = ((System.Drawing.Icon)(resources.GetObject("ListControlContents.DefaultIcon")));
            this.ListControlContents.DefaultImage = ((System.Drawing.Image)(resources.GetObject("ListControlContents.DefaultImage")));
            this.ListControlContents.DefaultItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ListControlContents.Dock = System.Windows.Forms.DockStyle.Fill;
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.FormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.FitBlackBox | System.Drawing.StringFormatFlags.LineLimit) 
            | System.Drawing.StringFormatFlags.NoClip)));
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat1.Trimming = System.Drawing.StringTrimming.None;
            this.ListControlContents.DrawStringFormat = stringFormat1;
            this.ListControlContents.ForeColor = System.Drawing.Color.White;
            this.ListControlContents.FormattingEnabled = true;
            this.ListControlContents.IconDrawLocation = new System.Drawing.Point(0, 0);
            this.ListControlContents.IconDrawSize = new System.Drawing.Size(32, 32);
            this.ListControlContents.IconList = new System.Drawing.Icon[0];
            this.ListControlContents.IsFileList = true;
            this.ListControlContents.ItemColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))))};
            this.ListControlContents.Items.AddRange(new object[] {
            "DebugItem.bin",
            "DebugItem.sprx",
            "DebugItem.png",
            "DebugItem.mp4",
            "DebugItem.mp3",
            "DebugItem.arc"});
            this.ListControlContents.Location = new System.Drawing.Point(3, 34);
            this.ListControlContents.Logging = false;
            this.ListControlContents.Name = "ListControlContents";
            this.ListControlContents.RowHeight = 32;
            this.ListControlContents.Size = new System.Drawing.Size(384, 356);
            this.ListControlContents.TabIndex = 17;
            this.ListControlContents.TextDrawLocationOffset = new System.Drawing.Point(40, 8);
            this.ListControlContents.TextFont = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListControlContents.WhileDrawing = null;
            this.ListControlContents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListControlContents_MouseDoubleClick);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.TextBoxPath);
            this.splitContainer5.Panel1.Controls.Add(this.guna2Button2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.guna2Button1);
            this.splitContainer5.Panel2.Controls.Add(this.ButtonRefresh);
            this.splitContainer5.Size = new System.Drawing.Size(384, 31);
            this.splitContainer5.SplitterDistance = 281;
            this.splitContainer5.TabIndex = 16;
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Animated = true;
            this.TextBoxPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.TextBoxPath.BorderRadius = 2;
            this.TextBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPath.DefaultText = "/dev_hdd0";
            this.TextBoxPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.TextBoxPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPath.Location = new System.Drawing.Point(53, 0);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.PasswordChar = '\0';
            this.TextBoxPath.PlaceholderText = "/dev_hdd0";
            this.TextBoxPath.SelectedText = "";
            this.TextBoxPath.Size = new System.Drawing.Size(228, 31);
            this.TextBoxPath.TabIndex = 14;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button2.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::webMAN_Manager.Properties.Resources.upleft;
            this.guna2Button2.Location = new System.Drawing.Point(0, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(53, 31);
            this.guna2Button2.TabIndex = 15;
            this.guna2Button2.Click += new System.EventHandler(this.ButtonBackDirectoryClicked);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button1.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::webMAN_Manager.Properties.Resources.tex_user;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(-5, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(51, 31);
            this.guna2Button1.TabIndex = 12;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Animated = true;
            this.ButtonRefresh.BorderRadius = 5;
            this.ButtonRefresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonRefresh.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.ForeColor = System.Drawing.Color.White;
            this.ButtonRefresh.Image = global::webMAN_Manager.Properties.Resources.tex_update;
            this.ButtonRefresh.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonRefresh.Location = new System.Drawing.Point(46, 0);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(53, 31);
            this.ButtonRefresh.TabIndex = 11;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // TabPageNews
            // 
            this.TabPageNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.TabPageNews.Location = new System.Drawing.Point(184, 4);
            this.TabPageNews.Name = "TabPageNews";
            this.TabPageNews.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNews.Size = new System.Drawing.Size(390, 393);
            this.TabPageNews.TabIndex = 7;
            this.TabPageNews.Text = "News";
            // 
            // TabPageGAME
            // 
            this.TabPageGAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabPageGAME.Controls.Add(this.ListControlGames);
            this.TabPageGAME.Location = new System.Drawing.Point(184, 4);
            this.TabPageGAME.Name = "TabPageGAME";
            this.TabPageGAME.Size = new System.Drawing.Size(390, 393);
            this.TabPageGAME.TabIndex = 6;
            this.TabPageGAME.Text = "Games";
            // 
            // ListControlGames
            // 
            this.ListControlGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ListControlGames.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ListControlGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListControlGames.DefaultIcon = ((System.Drawing.Icon)(resources.GetObject("ListControlGames.DefaultIcon")));
            this.ListControlGames.DefaultImage = global::webMAN_Manager.Properties.Resources.game_tex_default_ps3;
            this.ListControlGames.DefaultItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ListControlGames.Dock = System.Windows.Forms.DockStyle.Fill;
            stringFormat2.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat2.FormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.FitBlackBox | System.Drawing.StringFormatFlags.LineLimit) 
            | System.Drawing.StringFormatFlags.NoClip)));
            stringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat2.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat2.Trimming = System.Drawing.StringTrimming.None;
            this.ListControlGames.DrawStringFormat = stringFormat2;
            this.ListControlGames.ForeColor = System.Drawing.Color.White;
            this.ListControlGames.FormattingEnabled = true;
            this.ListControlGames.IconDrawLocation = new System.Drawing.Point(0, 0);
            this.ListControlGames.IconDrawSize = new System.Drawing.Size(129, 69);
            this.ListControlGames.IconList = new System.Drawing.Icon[0];
            this.ListControlGames.IsFileList = false;
            this.ListControlGames.ItemColors = new System.Drawing.Color[0];
            this.ListControlGames.ItemHeight = 50;
            this.ListControlGames.Items.AddRange(new object[] {
            "Not implemented yet! Coming soon."});
            this.ListControlGames.Location = new System.Drawing.Point(0, 0);
            this.ListControlGames.Logging = false;
            this.ListControlGames.Name = "ListControlGames";
            this.ListControlGames.RowHeight = 90;
            this.ListControlGames.Size = new System.Drawing.Size(390, 393);
            this.ListControlGames.TabIndex = 0;
            this.ListControlGames.TextDrawLocationOffset = new System.Drawing.Point(129, 20);
            this.ListControlGames.TextFont = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListControlGames.WhileDrawing = null;
            // 
            // TabPagePower
            // 
            this.TabPagePower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TabPagePower.Controls.Add(this.splitContainer2);
            this.TabPagePower.Location = new System.Drawing.Point(184, 4);
            this.TabPagePower.Name = "TabPagePower";
            this.TabPagePower.Size = new System.Drawing.Size(390, 393);
            this.TabPagePower.TabIndex = 2;
            this.TabPagePower.Text = "Power Menu";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ChroniumFanController);
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(390, 393);
            this.splitContainer2.SplitterDistance = 51;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ButtonShutdown);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ButonRestart);
            this.splitContainer3.Size = new System.Drawing.Size(390, 51);
            this.splitContainer3.SplitterDistance = 130;
            this.splitContainer3.TabIndex = 0;
            // 
            // ButtonShutdown
            // 
            this.ButtonShutdown.Animated = true;
            this.ButtonShutdown.BorderRadius = 5;
            this.ButtonShutdown.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonShutdown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonShutdown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonShutdown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonShutdown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonShutdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonShutdown.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonShutdown.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShutdown.ForeColor = System.Drawing.Color.White;
            this.ButtonShutdown.Image = global::webMAN_Manager.Properties.Resources.shutdown;
            this.ButtonShutdown.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonShutdown.Location = new System.Drawing.Point(0, 0);
            this.ButtonShutdown.Name = "ButtonShutdown";
            this.ButtonShutdown.Size = new System.Drawing.Size(130, 51);
            this.ButtonShutdown.TabIndex = 2;
            this.ButtonShutdown.Click += new System.EventHandler(this.ButtonShutdown_Click);
            // 
            // ButonRestart
            // 
            this.ButonRestart.Animated = true;
            this.ButonRestart.BorderColor = System.Drawing.Color.White;
            this.ButonRestart.BorderRadius = 5;
            this.ButonRestart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButonRestart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButonRestart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButonRestart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButonRestart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButonRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButonRestart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButonRestart.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonRestart.ForeColor = System.Drawing.Color.White;
            this.ButonRestart.Image = global::webMAN_Manager.Properties.Resources.Rst;
            this.ButonRestart.ImageSize = new System.Drawing.Size(40, 40);
            this.ButonRestart.Location = new System.Drawing.Point(0, 0);
            this.ButonRestart.Name = "ButonRestart";
            this.ButonRestart.Size = new System.Drawing.Size(256, 51);
            this.ButonRestart.TabIndex = 3;
            this.ButonRestart.Click += new System.EventHandler(this.ButonRestart_Click);
            // 
            // ChroniumFanController
            // 
            this.ChroniumFanController.ActivateBrowserOnCreation = false;
            this.ChroniumFanController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChroniumFanController.Location = new System.Drawing.Point(0, 44);
            this.ChroniumFanController.Name = "ChroniumFanController";
            this.ChroniumFanController.Size = new System.Drawing.Size(390, 294);
            this.ChroniumFanController.TabIndex = 3;
            this.ChroniumFanController.FrameLoadStart += new System.EventHandler<CefSharp.FrameLoadStartEventArgs>(this.ChroniumFanController_FrameLoadStart);
            this.ChroniumFanController.IsBrowserInitializedChanged += new System.EventHandler(this.ChroniumFanController_IsBrowserInitializedChanged);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.TrackbarFanSpeed);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.LabelFanSpeedPerc);
            this.splitContainer4.Size = new System.Drawing.Size(390, 44);
            this.splitContainer4.SplitterDistance = 312;
            this.splitContainer4.TabIndex = 2;
            // 
            // TrackbarFanSpeed
            // 
            this.TrackbarFanSpeed.DisplayFocus = true;
            this.TrackbarFanSpeed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrackbarFanSpeed.IndicateFocus = true;
            this.TrackbarFanSpeed.LargeChange = 2;
            this.TrackbarFanSpeed.Location = new System.Drawing.Point(0, 21);
            this.TrackbarFanSpeed.Name = "TrackbarFanSpeed";
            this.TrackbarFanSpeed.Size = new System.Drawing.Size(312, 23);
            this.TrackbarFanSpeed.TabIndex = 0;
            this.TrackbarFanSpeed.ThumbColor = System.Drawing.SystemColors.MenuHighlight;
            this.TrackbarFanSpeed.Value = 0;
            this.TrackbarFanSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackbarFanSpeed_MouseUp);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fan Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelFanSpeedPerc
            // 
            this.LabelFanSpeedPerc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFanSpeedPerc.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFanSpeedPerc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LabelFanSpeedPerc.Location = new System.Drawing.Point(0, 0);
            this.LabelFanSpeedPerc.Name = "LabelFanSpeedPerc";
            this.LabelFanSpeedPerc.Size = new System.Drawing.Size(74, 44);
            this.LabelFanSpeedPerc.TabIndex = 2;
            this.LabelFanSpeedPerc.Text = "0%";
            this.LabelFanSpeedPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPageSettings
            // 
            this.TabPageSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.TabPageSettings.Controls.Add(this.LabelUpdatesCount);
            this.TabPageSettings.Controls.Add(this.NumericSettingTimeout);
            this.TabPageSettings.Controls.Add(this.CheckboxFastStart);
            this.TabPageSettings.Controls.Add(this.LabelIndicator2);
            this.TabPageSettings.Controls.Add(this.CheckBoxSettingFullscreen);
            this.TabPageSettings.Controls.Add(this.LabelIndicator1);
            this.TabPageSettings.Controls.Add(this.InputBoxAddress);
            this.TabPageSettings.Controls.Add(this.CheckboxSettingParams);
            this.TabPageSettings.Controls.Add(this.CheckboxSettingLogging);
            this.TabPageSettings.Controls.Add(this.ButtonRestart);
            this.TabPageSettings.Controls.Add(this.ButtonExit);
            this.TabPageSettings.Controls.Add(this.ButtonSaveConfig);
            this.TabPageSettings.Location = new System.Drawing.Point(184, 4);
            this.TabPageSettings.Name = "TabPageSettings";
            this.TabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSettings.Size = new System.Drawing.Size(390, 393);
            this.TabPageSettings.TabIndex = 3;
            this.TabPageSettings.Text = "Settings";
            // 
            // LabelUpdatesCount
            // 
            this.LabelUpdatesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelUpdatesCount.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUpdatesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelUpdatesCount.Location = new System.Drawing.Point(8, 286);
            this.LabelUpdatesCount.Name = "LabelUpdatesCount";
            this.LabelUpdatesCount.Size = new System.Drawing.Size(241, 25);
            this.LabelUpdatesCount.TabIndex = 12;
            this.LabelUpdatesCount.Text = "! Twelfth Clock Has Ticked 0 Times.";
            this.LabelUpdatesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumericSettingTimeout
            // 
            this.NumericSettingTimeout.BackColor = System.Drawing.Color.Transparent;
            this.NumericSettingTimeout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.NumericSettingTimeout.BorderRadius = 2;
            this.NumericSettingTimeout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericSettingTimeout.DecimalPlaces = 2;
            this.NumericSettingTimeout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumericSettingTimeout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.NumericSettingTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericSettingTimeout.ForeColor = System.Drawing.Color.Gray;
            this.NumericSettingTimeout.IndicateFocus = true;
            this.NumericSettingTimeout.Location = new System.Drawing.Point(205, 49);
            this.NumericSettingTimeout.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            65536});
            this.NumericSettingTimeout.Name = "NumericSettingTimeout";
            this.NumericSettingTimeout.Size = new System.Drawing.Size(164, 23);
            this.NumericSettingTimeout.TabIndex = 7;
            this.NumericSettingTimeout.ThousandsSeparator = true;
            this.NumericSettingTimeout.UpDownButtonFillColor = System.Drawing.Color.DimGray;
            this.NumericSettingTimeout.UseTransparentBackground = true;
            // 
            // CheckboxFastStart
            // 
            this.CheckboxFastStart.AutoSize = true;
            this.CheckboxFastStart.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckboxFastStart.CheckedState.BorderRadius = 0;
            this.CheckboxFastStart.CheckedState.BorderThickness = 0;
            this.CheckboxFastStart.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckboxFastStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CheckboxFastStart.Location = new System.Drawing.Point(18, 190);
            this.CheckboxFastStart.Name = "CheckboxFastStart";
            this.CheckboxFastStart.Size = new System.Drawing.Size(71, 17);
            this.CheckboxFastStart.TabIndex = 11;
            this.CheckboxFastStart.Text = "Fast-Start";
            this.CheckboxFastStart.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckboxFastStart.UncheckedState.BorderRadius = 0;
            this.CheckboxFastStart.UncheckedState.BorderThickness = 0;
            this.CheckboxFastStart.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // LabelIndicator2
            // 
            this.LabelIndicator2.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIndicator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelIndicator2.Location = new System.Drawing.Point(15, 48);
            this.LabelIndicator2.Name = "LabelIndicator2";
            this.LabelIndicator2.Size = new System.Drawing.Size(184, 25);
            this.LabelIndicator2.TabIndex = 8;
            this.LabelIndicator2.Text = "Connection Timeout (secs)";
            this.LabelIndicator2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBoxSettingFullscreen
            // 
            this.CheckBoxSettingFullscreen.AutoSize = true;
            this.CheckBoxSettingFullscreen.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxSettingFullscreen.CheckedState.BorderRadius = 0;
            this.CheckBoxSettingFullscreen.CheckedState.BorderThickness = 0;
            this.CheckBoxSettingFullscreen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxSettingFullscreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CheckBoxSettingFullscreen.Location = new System.Drawing.Point(18, 169);
            this.CheckBoxSettingFullscreen.Name = "CheckBoxSettingFullscreen";
            this.CheckBoxSettingFullscreen.Size = new System.Drawing.Size(74, 17);
            this.CheckBoxSettingFullscreen.TabIndex = 6;
            this.CheckBoxSettingFullscreen.Text = "Fullscreen";
            this.CheckBoxSettingFullscreen.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxSettingFullscreen.UncheckedState.BorderRadius = 0;
            this.CheckBoxSettingFullscreen.UncheckedState.BorderThickness = 0;
            this.CheckBoxSettingFullscreen.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // LabelIndicator1
            // 
            this.LabelIndicator1.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIndicator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelIndicator1.Location = new System.Drawing.Point(15, 15);
            this.LabelIndicator1.Name = "LabelIndicator1";
            this.LabelIndicator1.Size = new System.Drawing.Size(184, 25);
            this.LabelIndicator1.TabIndex = 4;
            this.LabelIndicator1.Text = "Initial IP Address";
            this.LabelIndicator1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputBoxAddress
            // 
            this.InputBoxAddress.Animated = true;
            this.InputBoxAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.InputBoxAddress.BorderRadius = 2;
            this.InputBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputBoxAddress.DefaultText = "";
            this.InputBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputBoxAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.InputBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputBoxAddress.Location = new System.Drawing.Point(205, 17);
            this.InputBoxAddress.Name = "InputBoxAddress";
            this.InputBoxAddress.PasswordChar = '\0';
            this.InputBoxAddress.PlaceholderText = "";
            this.InputBoxAddress.SelectedText = "";
            this.InputBoxAddress.Size = new System.Drawing.Size(164, 23);
            this.InputBoxAddress.TabIndex = 3;
            // 
            // CheckboxSettingParams
            // 
            this.CheckboxSettingParams.AutoSize = true;
            this.CheckboxSettingParams.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckboxSettingParams.CheckedState.BorderRadius = 0;
            this.CheckboxSettingParams.CheckedState.BorderThickness = 0;
            this.CheckboxSettingParams.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckboxSettingParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CheckboxSettingParams.Location = new System.Drawing.Point(18, 146);
            this.CheckboxSettingParams.Name = "CheckboxSettingParams";
            this.CheckboxSettingParams.Size = new System.Drawing.Size(99, 17);
            this.CheckboxSettingParams.TabIndex = 2;
            this.CheckboxSettingParams.Text = "Disable Params";
            this.CheckboxSettingParams.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckboxSettingParams.UncheckedState.BorderRadius = 0;
            this.CheckboxSettingParams.UncheckedState.BorderThickness = 0;
            this.CheckboxSettingParams.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // CheckboxSettingLogging
            // 
            this.CheckboxSettingLogging.AutoSize = true;
            this.CheckboxSettingLogging.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckboxSettingLogging.CheckedState.BorderRadius = 0;
            this.CheckboxSettingLogging.CheckedState.BorderThickness = 0;
            this.CheckboxSettingLogging.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckboxSettingLogging.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CheckboxSettingLogging.Location = new System.Drawing.Point(18, 123);
            this.CheckboxSettingLogging.Name = "CheckboxSettingLogging";
            this.CheckboxSettingLogging.Size = new System.Drawing.Size(102, 17);
            this.CheckboxSettingLogging.TabIndex = 1;
            this.CheckboxSettingLogging.Text = "Disable Logging";
            this.CheckboxSettingLogging.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckboxSettingLogging.UncheckedState.BorderRadius = 0;
            this.CheckboxSettingLogging.UncheckedState.BorderThickness = 0;
            this.CheckboxSettingLogging.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ButtonRestart
            // 
            this.ButtonRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRestart.Animated = true;
            this.ButtonRestart.BorderRadius = 5;
            this.ButtonRestart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonRestart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRestart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRestart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRestart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRestart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonRestart.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRestart.ForeColor = System.Drawing.Color.White;
            this.ButtonRestart.Image = global::webMAN_Manager.Properties.Resources.tex_update;
            this.ButtonRestart.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonRestart.Location = new System.Drawing.Point(6, 317);
            this.ButtonRestart.Name = "ButtonRestart";
            this.ButtonRestart.Size = new System.Drawing.Size(132, 32);
            this.ButtonRestart.TabIndex = 10;
            this.ButtonRestart.Text = "Restart";
            this.ButtonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonExit.Animated = true;
            this.ButtonExit.BorderRadius = 5;
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonExit.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Image = global::webMAN_Manager.Properties.Resources.tex_quit;
            this.ButtonExit.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonExit.Location = new System.Drawing.Point(6, 355);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(132, 32);
            this.ButtonExit.TabIndex = 9;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonSaveConfig
            // 
            this.ButtonSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveConfig.Animated = true;
            this.ButtonSaveConfig.BorderRadius = 5;
            this.ButtonSaveConfig.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonSaveConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSaveConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSaveConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonSaveConfig.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveConfig.ForeColor = System.Drawing.Color.White;
            this.ButtonSaveConfig.Image = global::webMAN_Manager.Properties.Resources.tex_pointer_pen;
            this.ButtonSaveConfig.ImageSize = new System.Drawing.Size(29, 29);
            this.ButtonSaveConfig.Location = new System.Drawing.Point(286, 346);
            this.ButtonSaveConfig.Name = "ButtonSaveConfig";
            this.ButtonSaveConfig.Size = new System.Drawing.Size(98, 41);
            this.ButtonSaveConfig.TabIndex = 5;
            this.ButtonSaveConfig.Text = "Save";
            this.ButtonSaveConfig.Visible = false;
            this.ButtonSaveConfig.Click += new System.EventHandler(this.ButtonSaveConfig_Click);
            // 
            // TabPageDebug
            // 
            this.TabPageDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.TabPageDebug.Controls.Add(this.ButtonDebug2);
            this.TabPageDebug.Controls.Add(this.DebugButtonTestItems);
            this.TabPageDebug.Controls.Add(this.NumericSettingScalePlus);
            this.TabPageDebug.Controls.Add(this.label3);
            this.TabPageDebug.Controls.Add(this.DebugContainerFetch);
            this.TabPageDebug.Controls.Add(this.label2);
            this.TabPageDebug.Location = new System.Drawing.Point(184, 4);
            this.TabPageDebug.Name = "TabPageDebug";
            this.TabPageDebug.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDebug.Size = new System.Drawing.Size(390, 393);
            this.TabPageDebug.TabIndex = 5;
            this.TabPageDebug.Text = "Debug Menu";
            // 
            // ButtonDebug2
            // 
            this.ButtonDebug2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDebug2.Animated = true;
            this.ButtonDebug2.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDebug2.BorderRadius = 5;
            this.ButtonDebug2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonDebug2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDebug2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDebug2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDebug2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDebug2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonDebug2.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDebug2.ForeColor = System.Drawing.Color.White;
            this.ButtonDebug2.Image = global::webMAN_Manager.Properties.Resources.tex_notification_settings;
            this.ButtonDebug2.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonDebug2.Location = new System.Drawing.Point(156, 95);
            this.ButtonDebug2.Name = "ButtonDebug2";
            this.ButtonDebug2.Size = new System.Drawing.Size(132, 32);
            this.ButtonDebug2.TabIndex = 19;
            this.ButtonDebug2.Text = "DebugAvatar";
            this.ButtonDebug2.UseTransparentBackground = true;
            this.ButtonDebug2.Click += new System.EventHandler(this.ButtonDebug2_Click);
            // 
            // DebugButtonTestItems
            // 
            this.DebugButtonTestItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DebugButtonTestItems.Animated = true;
            this.DebugButtonTestItems.BackColor = System.Drawing.Color.Transparent;
            this.DebugButtonTestItems.BorderRadius = 5;
            this.DebugButtonTestItems.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DebugButtonTestItems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DebugButtonTestItems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DebugButtonTestItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DebugButtonTestItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DebugButtonTestItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DebugButtonTestItems.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugButtonTestItems.ForeColor = System.Drawing.Color.White;
            this.DebugButtonTestItems.Image = global::webMAN_Manager.Properties.Resources.tex_notification_settings;
            this.DebugButtonTestItems.ImageSize = new System.Drawing.Size(40, 40);
            this.DebugButtonTestItems.Location = new System.Drawing.Point(13, 95);
            this.DebugButtonTestItems.Name = "DebugButtonTestItems";
            this.DebugButtonTestItems.Size = new System.Drawing.Size(132, 32);
            this.DebugButtonTestItems.TabIndex = 18;
            this.DebugButtonTestItems.Text = "Test Control";
            this.DebugButtonTestItems.UseTransparentBackground = true;
            this.DebugButtonTestItems.Click += new System.EventHandler(this.DebugButtonTestItems_Click);
            // 
            // NumericSettingScalePlus
            // 
            this.NumericSettingScalePlus.BackColor = System.Drawing.Color.Transparent;
            this.NumericSettingScalePlus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.NumericSettingScalePlus.BorderRadius = 2;
            this.NumericSettingScalePlus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericSettingScalePlus.DecimalPlaces = 2;
            this.NumericSettingScalePlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumericSettingScalePlus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.NumericSettingScalePlus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericSettingScalePlus.ForeColor = System.Drawing.Color.Gray;
            this.NumericSettingScalePlus.IndicateFocus = true;
            this.NumericSettingScalePlus.Location = new System.Drawing.Point(217, 40);
            this.NumericSettingScalePlus.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.NumericSettingScalePlus.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147418112});
            this.NumericSettingScalePlus.Name = "NumericSettingScalePlus";
            this.NumericSettingScalePlus.Size = new System.Drawing.Size(164, 23);
            this.NumericSettingScalePlus.TabIndex = 16;
            this.NumericSettingScalePlus.ThousandsSeparator = true;
            this.NumericSettingScalePlus.UpDownButtonFillColor = System.Drawing.Color.DimGray;
            this.NumericSettingScalePlus.UseTransparentBackground = true;
            this.NumericSettingScalePlus.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Font Size Plus: 0(default) ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // DebugContainerFetch
            // 
            this.DebugContainerFetch.Dock = System.Windows.Forms.DockStyle.Top;
            this.DebugContainerFetch.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.DebugContainerFetch.IsSplitterFixed = true;
            this.DebugContainerFetch.Location = new System.Drawing.Point(3, 3);
            this.DebugContainerFetch.Name = "DebugContainerFetch";
            // 
            // DebugContainerFetch.Panel1
            // 
            this.DebugContainerFetch.Panel1.Controls.Add(this.DebugTextBoxPath);
            // 
            // DebugContainerFetch.Panel2
            // 
            this.DebugContainerFetch.Panel2.Controls.Add(this.ButtonDebug1);
            this.DebugContainerFetch.Size = new System.Drawing.Size(384, 31);
            this.DebugContainerFetch.SplitterDistance = 285;
            this.DebugContainerFetch.TabIndex = 15;
            // 
            // DebugTextBoxPath
            // 
            this.DebugTextBoxPath.Animated = true;
            this.DebugTextBoxPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.DebugTextBoxPath.BorderRadius = 2;
            this.DebugTextBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DebugTextBoxPath.DefaultText = "/dev_hdd0";
            this.DebugTextBoxPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DebugTextBoxPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DebugTextBoxPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DebugTextBoxPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DebugTextBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugTextBoxPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.DebugTextBoxPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DebugTextBoxPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DebugTextBoxPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DebugTextBoxPath.Location = new System.Drawing.Point(0, 0);
            this.DebugTextBoxPath.Name = "DebugTextBoxPath";
            this.DebugTextBoxPath.PasswordChar = '\0';
            this.DebugTextBoxPath.PlaceholderText = "/dev_hdd0";
            this.DebugTextBoxPath.SelectedText = "";
            this.DebugTextBoxPath.Size = new System.Drawing.Size(285, 31);
            this.DebugTextBoxPath.TabIndex = 14;
            // 
            // ButtonDebug1
            // 
            this.ButtonDebug1.Animated = true;
            this.ButtonDebug1.BorderRadius = 5;
            this.ButtonDebug1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonDebug1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDebug1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDebug1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDebug1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDebug1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDebug1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonDebug1.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDebug1.ForeColor = System.Drawing.Color.White;
            this.ButtonDebug1.Image = global::webMAN_Manager.Properties.Resources.tex_update;
            this.ButtonDebug1.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonDebug1.Location = new System.Drawing.Point(0, 0);
            this.ButtonDebug1.Name = "ButtonDebug1";
            this.ButtonDebug1.Size = new System.Drawing.Size(95, 31);
            this.ButtonDebug1.TabIndex = 11;
            this.ButtonDebug1.Text = "fetch";
            this.ButtonDebug1.Click += new System.EventHandler(this.ButtonDebug1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 248);
            this.label2.TabIndex = 13;
            this.label2.Text = "200, 200, 200";
            // 
            // LabelIndicatorMessage
            // 
            this.LabelIndicatorMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelIndicatorMessage.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIndicatorMessage.ForeColor = System.Drawing.Color.White;
            this.LabelIndicatorMessage.Location = new System.Drawing.Point(0, 136);
            this.LabelIndicatorMessage.Name = "LabelIndicatorMessage";
            this.LabelIndicatorMessage.Size = new System.Drawing.Size(293, 71);
            this.LabelIndicatorMessage.TabIndex = 3;
            this.LabelIndicatorMessage.Text = "Please wait...";
            this.LabelIndicatorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindowTop
            // 
            this.WindowTop.Controls.Add(this.guna2ControlBox1);
            this.WindowTop.Controls.Add(this.BoxMaximize);
            this.WindowTop.Controls.Add(this.BoxClose);
            this.WindowTop.Controls.Add(this.IconDisplay);
            this.WindowTop.Controls.Add(this.LabelFormTitle);
            this.WindowTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowTop.Location = new System.Drawing.Point(0, 0);
            this.WindowTop.Name = "WindowTop";
            this.WindowTop.Size = new System.Drawing.Size(602, 30);
            this.WindowTop.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(467, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // BoxMaximize
            // 
            this.BoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.BoxMaximize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BoxMaximize.IconColor = System.Drawing.Color.White;
            this.BoxMaximize.Location = new System.Drawing.Point(512, 1);
            this.BoxMaximize.Name = "BoxMaximize";
            this.BoxMaximize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BoxMaximize.Size = new System.Drawing.Size(45, 29);
            this.BoxMaximize.TabIndex = 7;
            // 
            // BoxClose
            // 
            this.BoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BoxClose.IconColor = System.Drawing.Color.White;
            this.BoxClose.Location = new System.Drawing.Point(557, 1);
            this.BoxClose.Name = "BoxClose";
            this.BoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BoxClose.Size = new System.Drawing.Size(45, 29);
            this.BoxClose.TabIndex = 6;
            // 
            // IconDisplay
            // 
            this.IconDisplay.FillColor = System.Drawing.Color.Black;
            this.IconDisplay.Image = global::webMAN_Manager.Properties.Resources.tex_user1;
            this.IconDisplay.ImageRotate = 0F;
            this.IconDisplay.Location = new System.Drawing.Point(6, 5);
            this.IconDisplay.Name = "IconDisplay";
            this.IconDisplay.Size = new System.Drawing.Size(20, 20);
            this.IconDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconDisplay.TabIndex = 5;
            this.IconDisplay.TabStop = false;
            // 
            // LabelFormTitle
            // 
            this.LabelFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFormTitle.AutoEllipsis = true;
            this.LabelFormTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFormTitle.ForeColor = System.Drawing.Color.White;
            this.LabelFormTitle.Location = new System.Drawing.Point(35, 7);
            this.LabelFormTitle.Name = "LabelFormTitle";
            this.LabelFormTitle.Size = new System.Drawing.Size(426, 18);
            this.LabelFormTitle.TabIndex = 0;
            this.LabelFormTitle.Text = "multiMAN";
            // 
            // TopDraggerController
            // 
            this.TopDraggerController.DockIndicatorTransparencyValue = 0.6D;
            this.TopDraggerController.TargetControl = this.WindowTop;
            this.TopDraggerController.UseTransparentDrag = true;
            // 
            // Updater
            // 
            this.Updater.Interval = 12000;
            this.Updater.Tick += new System.EventHandler(this.Updater_Tick);
            // 
            // PanelLoading
            // 
            this.PanelLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelLoading.Controls.Add(this.LabelIndicatorMessage);
            this.PanelLoading.Controls.Add(this.ProgressBarLoading);
            this.PanelLoading.Controls.Add(this.Spinner);
            this.PanelLoading.Controls.Add(this.ButtonChangeAddress);
            this.PanelLoading.Location = new System.Drawing.Point(152, 94);
            this.PanelLoading.Name = "PanelLoading";
            this.PanelLoading.Size = new System.Drawing.Size(293, 248);
            this.PanelLoading.TabIndex = 5;
            // 
            // ProgressBarLoading
            // 
            this.ProgressBarLoading.AutoRoundedCorners = true;
            this.ProgressBarLoading.BorderRadius = 4;
            this.ProgressBarLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBarLoading.Location = new System.Drawing.Point(0, 207);
            this.ProgressBarLoading.Name = "ProgressBarLoading";
            this.ProgressBarLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.ProgressBarLoading.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.ProgressBarLoading.Size = new System.Drawing.Size(293, 10);
            this.ProgressBarLoading.TabIndex = 5;
            this.ProgressBarLoading.Text = "guna2ProgressBar1";
            this.ProgressBarLoading.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressBarLoading.Value = 2;
            // 
            // Spinner
            // 
            this.Spinner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spinner.BackColor = System.Drawing.Color.Transparent;
            this.Spinner.Image = global::webMAN_Manager.Properties.Resources.tex_loading_icon2;
            this.Spinner.ImageRotate = 0F;
            this.Spinner.Location = new System.Drawing.Point(99, 30);
            this.Spinner.MaximumSize = new System.Drawing.Size(105, 92);
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(105, 92);
            this.Spinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Spinner.TabIndex = 4;
            this.Spinner.TabStop = false;
            this.Spinner.UseTransparentBackground = true;
            // 
            // ButtonChangeAddress
            // 
            this.ButtonChangeAddress.Animated = true;
            this.ButtonChangeAddress.BorderColor = System.Drawing.Color.Gray;
            this.ButtonChangeAddress.BorderRadius = 2;
            this.ButtonChangeAddress.BorderThickness = 2;
            this.ButtonChangeAddress.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonChangeAddress.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonChangeAddress.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonChangeAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonChangeAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonChangeAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonChangeAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonChangeAddress.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChangeAddress.ForeColor = System.Drawing.Color.White;
            this.ButtonChangeAddress.ImageSize = new System.Drawing.Size(29, 29);
            this.ButtonChangeAddress.Location = new System.Drawing.Point(0, 217);
            this.ButtonChangeAddress.Name = "ButtonChangeAddress";
            this.ButtonChangeAddress.Size = new System.Drawing.Size(293, 31);
            this.ButtonChangeAddress.TabIndex = 6;
            this.ButtonChangeAddress.Text = "Change Address...";
            this.ButtonChangeAddress.Click += new System.EventHandler(this.ButtonChangeAddress_Click);
            // 
            // GunaTaskBarIndicator
            // 
            this.GunaTaskBarIndicator.TargetForm = this;
            // 
            // Controller1
            // 
            this.Controller1.DockIndicatorTransparencyValue = 0.6D;
            this.Controller1.TargetControl = this.LabelFormTitle;
            this.Controller1.UseTransparentDrag = true;
            // 
            // Controller2
            // 
            this.Controller2.DockIndicatorTransparencyValue = 0.6D;
            this.Controller2.TargetControl = this.IconDisplay;
            this.Controller2.UseTransparentDrag = true;
            // 
            // ProgressBarSubProcess
            // 
            this.ProgressBarSubProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBarSubProcess.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.ProgressBarSubProcess.HideProgressText = false;
            this.ProgressBarSubProcess.Location = new System.Drawing.Point(0, 78);
            this.ProgressBarSubProcess.Name = "ProgressBarSubProcess";
            this.ProgressBarSubProcess.Size = new System.Drawing.Size(174, 22);
            this.ProgressBarSubProcess.Style = MetroFramework.MetroColorStyle.Teal;
            this.ProgressBarSubProcess.TabIndex = 18;
            this.ProgressBarSubProcess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProgressBarSubProcess.Value = 1;
            // 
            // LabelSubProcessIndicator
            // 
            this.LabelSubProcessIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelSubProcessIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelSubProcessIndicator.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubProcessIndicator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelSubProcessIndicator.Location = new System.Drawing.Point(0, 0);
            this.LabelSubProcessIndicator.Name = "LabelSubProcessIndicator";
            this.LabelSubProcessIndicator.Size = new System.Drawing.Size(174, 78);
            this.LabelSubProcessIndicator.TabIndex = 9;
            this.LabelSubProcessIndicator.Text = "Unknown Process";
            this.LabelSubProcessIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelSubProcessIndicator
            // 
            this.PanelSubProcessIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelSubProcessIndicator.Controls.Add(this.LabelSubProcessIndicator);
            this.PanelSubProcessIndicator.Controls.Add(this.ProgressBarSubProcess);
            this.PanelSubProcessIndicator.Location = new System.Drawing.Point(16, 329);
            this.PanelSubProcessIndicator.Name = "PanelSubProcessIndicator";
            this.PanelSubProcessIndicator.Size = new System.Drawing.Size(174, 100);
            this.PanelSubProcessIndicator.TabIndex = 19;
            this.PanelSubProcessIndicator.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(602, 449);
            this.Controls.Add(this.PanelSubProcessIndicator);
            this.Controls.Add(this.WindowTop);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.PanelLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(602, 449);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.TextChanged += new System.EventHandler(this.MainForm_TextChanged);
            this.MainContainer.ResumeLayout(false);
            this.TabContainer.ResumeLayout(false);
            this.TabPageStatus.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayerGameCover)).EndInit();
            this.StatePanel2Container.Panel1.ResumeLayout(false);
            this.StatePanel2Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatePanel2Container)).EndInit();
            this.StatePanel2Container.ResumeLayout(false);
            this.SubContainer1Xmb.Panel1.ResumeLayout(false);
            this.SubContainer1Xmb.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubContainer1Xmb)).EndInit();
            this.SubContainer1Xmb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxXmbImage)).EndInit();
            this.SubSplitButtons.Panel1.ResumeLayout(false);
            this.SubSplitButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubSplitButtons)).EndInit();
            this.SubSplitButtons.ResumeLayout(false);
            this.TabPageContent.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.TabPageGAME.ResumeLayout(false);
            this.TabPagePower.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.TabPageSettings.ResumeLayout(false);
            this.TabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSettingTimeout)).EndInit();
            this.TabPageDebug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericSettingScalePlus)).EndInit();
            this.DebugContainerFetch.Panel1.ResumeLayout(false);
            this.DebugContainerFetch.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DebugContainerFetch)).EndInit();
            this.DebugContainerFetch.ResumeLayout(false);
            this.WindowTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconDisplay)).EndInit();
            this.PanelLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spinner)).EndInit();
            this.PanelSubProcessIndicator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm MainBorderlessController;
        private System.Windows.Forms.PictureBox PictureBoxPlayerGameCover;
        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.Label LabelProcessName;
        private System.Windows.Forms.Label LabelGameTimestamp;
        private System.Windows.Forms.Label LabelIndicatorMessage;
        private System.Windows.Forms.Panel WindowTop;
        private Guna.UI2.WinForms.Guna2PictureBox IconDisplay;
        private System.Windows.Forms.Label LabelFormTitle;
        private Guna.UI2.WinForms.Guna2DragControl TopDraggerController;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox BoxMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox BoxClose;
        private System.Windows.Forms.Label LabelUserName;
        private Guna.UI2.WinForms.Guna2ResizeForm MainResizeController;
        private System.Windows.Forms.Timer Updater;
        private Guna.UI2.WinForms.Guna2TabControl TabContainer;
        private System.Windows.Forms.TabPage TabPageStatus;
        private System.Windows.Forms.TabPage TabPagePower;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox PictureBoxAvatar;
        private System.Windows.Forms.Panel PanelLoading;
        private Guna.UI2.WinForms.Guna2PictureBox Spinner;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBarLoading;
        private Guna.UI2.WinForms.Guna2TaskBarProgress GunaTaskBarIndicator;
        private System.Windows.Forms.TabPage TabPageSettings;
        private System.Windows.Forms.Label LabelInformation;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Guna.UI2.WinForms.Guna2Button ButtonShutdown;
        private Guna.UI2.WinForms.Guna2Button ButonRestart;
        private Guna.UI2.WinForms.Guna2TrackBar TrackbarFanSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label LabelFanSpeedPerc;
        private CefSharp.WinForms.ChromiumWebBrowser ChroniumFanController;
        private System.Windows.Forms.SplitContainer StatePanel2Container;
        private System.Windows.Forms.SplitContainer SubContainer1Xmb;
        private System.Windows.Forms.PictureBox PictureBoxXmbImage;
        private System.Windows.Forms.SplitContainer SubSplitButtons;
        private Guna.UI2.WinForms.Guna2Button ButtonSaveXmbScreenShoot;
        private Guna.UI2.WinForms.Guna2Button ButtonCopyXmb;
        private Guna.UI2.WinForms.Guna2CheckBox CheckboxSettingParams;
        private Guna.UI2.WinForms.Guna2CheckBox CheckboxSettingLogging;
        private System.Windows.Forms.Label LabelIndicator1;
        private Guna.UI2.WinForms.Guna2TextBox InputBoxAddress;
        private Guna.UI2.WinForms.Guna2Button ButtonSaveConfig;
        private System.Windows.Forms.TabPage TabPageContent;
        private Guna.UI2.WinForms.Guna2DragControl Controller1;
        private Guna.UI2.WinForms.Guna2DragControl Controller2;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBoxSettingFullscreen;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericSettingTimeout;
        private System.Windows.Forms.Label LabelIndicator2;
        private Guna.UI2.WinForms.Guna2Button ButtonRestart;
        private Guna.UI2.WinForms.Guna2Button ButtonExit;
        private System.Windows.Forms.Label LabelMin;
        private Guna.UI2.WinForms.Guna2CheckBox CheckboxFastStart;
        private Guna.UI2.WinForms.Guna2Button ButtonChangeAddress;
        private System.Windows.Forms.TabPage TabPageDebug;
        private Guna.UI2.WinForms.Guna2Button ButtonDebug1;
        private System.Windows.Forms.RichTextBox label2;
        private System.Windows.Forms.SplitContainer DebugContainerFetch;
        private Guna.UI2.WinForms.Guna2TextBox DebugTextBoxPath;
        private System.Windows.Forms.Label LabelUpdatesCount;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPath;
        private Guna.UI2.WinForms.Guna2Button ButtonRefresh;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericSettingScalePlus;
        private System.Windows.Forms.Label label3;
        private ExtendedControls.ListControl ListControlProtocolContents;
        private Guna.UI2.WinForms.Guna2Button DebugButtonTestItems;
        private ExtendedControls.ListControl ListControlContents;
        private System.Windows.Forms.TabPage TabPageGAME;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel PanelSubProcessIndicator;
        private System.Windows.Forms.Label LabelSubProcessIndicator;
        private MetroFramework.Controls.MetroProgressBar ProgressBarSubProcess;
        private Guna.UI2.WinForms.Guna2Button ButtonDebug2;
        private ExtendedControls.ListControl ListControlGames;
        private System.Windows.Forms.TabPage TabPageNews;
    }
}