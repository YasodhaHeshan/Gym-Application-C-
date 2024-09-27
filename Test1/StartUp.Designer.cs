namespace Test1
{
    partial class StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.btn_getStart = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_logIn1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_continuewithoutlogin = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_getStart
            // 
            this.btn_getStart.BackColor = System.Drawing.Color.Transparent;
            this.btn_getStart.BorderRadius = 14;
            this.btn_getStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_getStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_getStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_getStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_getStart.FillColor = System.Drawing.Color.Gold;
            this.btn_getStart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_getStart.ForeColor = System.Drawing.Color.Black;
            this.btn_getStart.Location = new System.Drawing.Point(313, 212);
            this.btn_getStart.Name = "btn_getStart";
            this.btn_getStart.Size = new System.Drawing.Size(202, 45);
            this.btn_getStart.TabIndex = 2;
            this.btn_getStart.Text = "Get Started";
            this.btn_getStart.UseTransparentBackground = true;
            this.btn_getStart.Click += new System.EventHandler(this.btn_getStart_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_logIn1
            // 
            this.btn_logIn1.BorderRadius = 14;
            this.btn_logIn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logIn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logIn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logIn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logIn1.FillColor = System.Drawing.Color.Gold;
            this.btn_logIn1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_logIn1.ForeColor = System.Drawing.Color.Black;
            this.btn_logIn1.Location = new System.Drawing.Point(313, 286);
            this.btn_logIn1.Name = "btn_logIn1";
            this.btn_logIn1.Size = new System.Drawing.Size(202, 45);
            this.btn_logIn1.TabIndex = 3;
            this.btn_logIn1.Text = "Log In";
            this.btn_logIn1.Click += new System.EventHandler(this.btn_logIn1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // btn_continuewithoutlogin
            // 
            this.btn_continuewithoutlogin.BorderRadius = 20;
            this.btn_continuewithoutlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_continuewithoutlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_continuewithoutlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_continuewithoutlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_continuewithoutlogin.FillColor = System.Drawing.Color.White;
            this.btn_continuewithoutlogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_continuewithoutlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_continuewithoutlogin.Location = new System.Drawing.Point(313, 360);
            this.btn_continuewithoutlogin.Name = "btn_continuewithoutlogin";
            this.btn_continuewithoutlogin.Size = new System.Drawing.Size(202, 59);
            this.btn_continuewithoutlogin.TabIndex = 5;
            this.btn_continuewithoutlogin.Text = "Continue without Log In";
            this.btn_continuewithoutlogin.Click += new System.EventHandler(this.btn_continuewithoutlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(307, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 76);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hi! Welcome To \r\nPowerFit";
            // 
            // btn_close
            // 
            this.btn_close.BorderRadius = 3;
            this.btn_close.BorderThickness = 2;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = global::Test1.Properties.Resources.icons8_close_501;
            this.btn_close.Location = new System.Drawing.Point(546, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(42, 38);
            this.btn_close.TabIndex = 7;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 20;
            this.guna2PictureBox1.Image = global::Test1.Properties.Resources.WhatsApp_Image_2023_07_23_at_09_34_45;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(22, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(239, 407);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_continuewithoutlogin);
            this.Controls.Add(this.btn_logIn1);
            this.Controls.Add(this.btn_getStart);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUp";
            this.Text = "Get Started";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_getStart;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_logIn1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btn_continuewithoutlogin;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_close;
    }
}

