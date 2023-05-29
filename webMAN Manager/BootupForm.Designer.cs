
namespace webMAN_Manager
{
    partial class BootupForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <
        /// name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BootupForm));
            this.FormBorderlessController = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.LoadingSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.LoadingGif = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DragController = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ResizeController = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.BoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // FormBorderlessController
            // 
            this.FormBorderlessController.BorderRadius = 20;
            this.FormBorderlessController.ContainerControl = this;
            this.FormBorderlessController.DockIndicatorTransparencyValue = 0.6D;
            this.FormBorderlessController.TransparentWhileDrag = true;
            // 
            // LoadingSpinner
            // 
            this.LoadingSpinner.BackColor = System.Drawing.Color.Black;
            this.LoadingSpinner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoadingSpinner.CustomBackground = true;
            this.LoadingSpinner.Location = new System.Drawing.Point(0, 0);
            this.LoadingSpinner.Maximum = 100;
            this.LoadingSpinner.Name = "LoadingSpinner";
            this.LoadingSpinner.Size = new System.Drawing.Size(23, 24);
            this.LoadingSpinner.Speed = 2F;
            this.LoadingSpinner.Style = MetroFramework.MetroColorStyle.White;
            this.LoadingSpinner.TabIndex = 2;
            this.LoadingSpinner.Value = 20;
            this.LoadingSpinner.Click += new System.EventHandler(this.LoadingSpinner_Click);
            // 
            // LoadingGif
            // 
            this.LoadingGif.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LoadingGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingGif.Image = global::webMAN_Manager.Properties.Resources.bootupAnim;
            this.LoadingGif.ImageRotate = 0F;
            this.LoadingGif.Location = new System.Drawing.Point(0, 0);
            this.LoadingGif.MinimumSize = new System.Drawing.Size(619, 374);
            this.LoadingGif.Name = "LoadingGif";
            this.LoadingGif.Size = new System.Drawing.Size(619, 374);
            this.LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingGif.TabIndex = 4;
            this.LoadingGif.TabStop = false;
            this.LoadingGif.Click += new System.EventHandler(this.LoadingGif_Click);
            // 
            // DragController
            // 
            this.DragController.DockIndicatorTransparencyValue = 0.6D;
            this.DragController.TargetControl = this.LoadingGif;
            this.DragController.UseTransparentDrag = true;
            // 
            // ResizeController
            // 
            this.ResizeController.TargetForm = this;
            // 
            // BoxClose
            // 
            this.BoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxClose.BackColor = System.Drawing.Color.Black;
            this.BoxClose.FillColor = System.Drawing.Color.Transparent;
            this.BoxClose.IconColor = System.Drawing.Color.White;
            this.BoxClose.Location = new System.Drawing.Point(562, 12);
            this.BoxClose.Name = "BoxClose";
            this.BoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BoxClose.Size = new System.Drawing.Size(45, 29);
            this.BoxClose.TabIndex = 7;
            // 
            // BootupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(619, 374);
            this.Controls.Add(this.LoadingGif);
            this.Controls.Add(this.BoxClose);
            this.Controls.Add(this.LoadingSpinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BootupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm FormBorderlessController;
        private MetroFramework.Controls.MetroProgressSpinner LoadingSpinner;
        private Guna.UI2.WinForms.Guna2PictureBox LoadingGif;
        private Guna.UI2.WinForms.Guna2DragControl DragController;
        private Guna.UI2.WinForms.Guna2ResizeForm ResizeController;
        private Guna.UI2.WinForms.Guna2ControlBox BoxClose;
    }
}

