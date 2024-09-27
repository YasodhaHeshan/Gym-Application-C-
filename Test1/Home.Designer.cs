namespace Test1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1_head = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_minmized = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_getStarted = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logIn = new Guna.UI2.WinForms.Guna2Button();
            this.panle2_buttun = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_aboutUs = new Guna.UI2.WinForms.Guna2Button();
            this.btn_reports = new Guna.UI2.WinForms.Guna2Button();
            this.btn_trainers = new Guna.UI2.WinForms.Guna2Button();
            this.btn_schedule = new Guna.UI2.WinForms.Guna2Button();
            this.btn_membership = new Guna.UI2.WinForms.Guna2Button();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panle2_buttun.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panel1_head
            // 
            this.panel1_head.BackColor = System.Drawing.Color.Gold;
            this.panel1_head.Controls.Add(this.label1);
            this.panel1_head.Controls.Add(this.btn_minmized);
            this.panel1_head.Controls.Add(this.btn_close);
            this.panel1_head.Controls.Add(this.guna2PictureBox1);
            this.panel1_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_head.Location = new System.Drawing.Point(0, 0);
            this.panel1_head.Name = "panel1_head";
            this.panel1_head.Size = new System.Drawing.Size(1241, 100);
            this.panel1_head.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Power Fit";
            // 
            // btn_minmized
            // 
            this.btn_minmized.BorderRadius = 2;
            this.btn_minmized.BorderThickness = 1;
            this.btn_minmized.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minmized.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minmized.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minmized.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minmized.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_minmized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minmized.ForeColor = System.Drawing.Color.White;
            this.btn_minmized.Image = global::Test1.Properties.Resources.icons8_minimize_501;
            this.btn_minmized.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_minmized.IndicateFocus = true;
            this.btn_minmized.Location = new System.Drawing.Point(1115, 12);
            this.btn_minmized.Name = "btn_minmized";
            this.btn_minmized.Size = new System.Drawing.Size(51, 37);
            this.btn_minmized.TabIndex = 3;
            this.btn_minmized.Click += new System.EventHandler(this.btn_minmized_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.BorderRadius = 2;
            this.btn_close.BorderThickness = 1;
            this.btn_close.CheckedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::Test1.Properties.Resources.icons8_close_501;
            this.btn_close.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_close.Location = new System.Drawing.Point(1172, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(51, 37);
            this.btn_close.TabIndex = 2;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Test1.Properties.Resources.WhatsApp_Image_2023_07_23_at_09_34_45;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(160, 94);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btn_getStarted
            // 
            this.btn_getStarted.BackColor = System.Drawing.Color.Transparent;
            this.btn_getStarted.BorderRadius = 15;
            this.btn_getStarted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_getStarted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_getStarted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_getStarted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_getStarted.FillColor = System.Drawing.Color.Gold;
            this.btn_getStarted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getStarted.ForeColor = System.Drawing.Color.Black;
            this.btn_getStarted.Location = new System.Drawing.Point(882, 395);
            this.btn_getStarted.Name = "btn_getStarted";
            this.btn_getStarted.Size = new System.Drawing.Size(135, 50);
            this.btn_getStarted.TabIndex = 6;
            this.btn_getStarted.Text = "Get Strated";
            this.btn_getStarted.Click += new System.EventHandler(this.btn_getStarted_Click);
            // 
            // btn_logIn
            // 
            this.btn_logIn.BackColor = System.Drawing.Color.Transparent;
            this.btn_logIn.BorderRadius = 15;
            this.btn_logIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logIn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_logIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logIn.ForeColor = System.Drawing.Color.White;
            this.btn_logIn.Location = new System.Drawing.Point(1052, 395);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(126, 50);
            this.btn_logIn.TabIndex = 5;
            this.btn_logIn.Text = "Log In";
            this.btn_logIn.UseTransparentBackground = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // panle2_buttun
            // 
            this.panle2_buttun.BackColor = System.Drawing.Color.Gold;
            this.panle2_buttun.Controls.Add(this.btn_aboutUs);
            this.panle2_buttun.Controls.Add(this.btn_reports);
            this.panle2_buttun.Controls.Add(this.btn_trainers);
            this.panle2_buttun.Controls.Add(this.btn_schedule);
            this.panle2_buttun.Controls.Add(this.btn_membership);
            this.panle2_buttun.Controls.Add(this.btn_home);
            this.panle2_buttun.Dock = System.Windows.Forms.DockStyle.Left;
            this.panle2_buttun.Location = new System.Drawing.Point(0, 100);
            this.panle2_buttun.Name = "panle2_buttun";
            this.panle2_buttun.Size = new System.Drawing.Size(246, 463);
            this.panle2_buttun.TabIndex = 1;
            // 
            // btn_aboutUs
            // 
            this.btn_aboutUs.BorderRadius = 3;
            this.btn_aboutUs.BorderThickness = 1;
            this.btn_aboutUs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_aboutUs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_aboutUs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_aboutUs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_aboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_aboutUs.FillColor = System.Drawing.Color.Gold;
            this.btn_aboutUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_aboutUs.ForeColor = System.Drawing.Color.Black;
            this.btn_aboutUs.Image = global::Test1.Properties.Resources.icons8_about_us_501;
            this.btn_aboutUs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_aboutUs.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_aboutUs.Location = new System.Drawing.Point(0, 345);
            this.btn_aboutUs.Name = "btn_aboutUs";
            this.btn_aboutUs.Size = new System.Drawing.Size(246, 69);
            this.btn_aboutUs.TabIndex = 7;
            this.btn_aboutUs.Text = "About Us";
            this.btn_aboutUs.Click += new System.EventHandler(this.btn_aboutUs_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.BorderRadius = 3;
            this.btn_reports.BorderThickness = 1;
            this.btn_reports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reports.FillColor = System.Drawing.Color.Gold;
            this.btn_reports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_reports.ForeColor = System.Drawing.Color.Black;
            this.btn_reports.Image = global::Test1.Properties.Resources.icons8_reports_581;
            this.btn_reports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_reports.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_reports.Location = new System.Drawing.Point(0, 276);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(246, 69);
            this.btn_reports.TabIndex = 6;
            this.btn_reports.Text = "Reports";
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_trainers
            // 
            this.btn_trainers.BorderRadius = 3;
            this.btn_trainers.BorderThickness = 1;
            this.btn_trainers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_trainers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_trainers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_trainers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_trainers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_trainers.FillColor = System.Drawing.Color.Gold;
            this.btn_trainers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_trainers.ForeColor = System.Drawing.Color.Black;
            this.btn_trainers.Image = global::Test1.Properties.Resources.icons8_trainers_641;
            this.btn_trainers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_trainers.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_trainers.Location = new System.Drawing.Point(0, 207);
            this.btn_trainers.Name = "btn_trainers";
            this.btn_trainers.Size = new System.Drawing.Size(246, 69);
            this.btn_trainers.TabIndex = 5;
            this.btn_trainers.Text = "Trainers";
            this.btn_trainers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_trainers.Click += new System.EventHandler(this.btn_trainers_Click);
            // 
            // btn_schedule
            // 
            this.btn_schedule.BorderRadius = 3;
            this.btn_schedule.BorderThickness = 1;
            this.btn_schedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_schedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_schedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_schedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_schedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_schedule.FillColor = System.Drawing.Color.Gold;
            this.btn_schedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_schedule.ForeColor = System.Drawing.Color.Black;
            this.btn_schedule.Image = global::Test1.Properties.Resources.icons8_schedules_681;
            this.btn_schedule.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_schedule.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_schedule.Location = new System.Drawing.Point(0, 138);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(246, 69);
            this.btn_schedule.TabIndex = 4;
            this.btn_schedule.Text = "Schedules";
            this.btn_schedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // btn_membership
            // 
            this.btn_membership.BorderRadius = 3;
            this.btn_membership.BorderThickness = 1;
            this.btn_membership.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_membership.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_membership.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_membership.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_membership.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_membership.FillColor = System.Drawing.Color.Gold;
            this.btn_membership.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_membership.ForeColor = System.Drawing.Color.Black;
            this.btn_membership.Image = global::Test1.Properties.Resources.icons8_membership_card_501;
            this.btn_membership.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_membership.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_membership.Location = new System.Drawing.Point(0, 69);
            this.btn_membership.Name = "btn_membership";
            this.btn_membership.Size = new System.Drawing.Size(246, 69);
            this.btn_membership.TabIndex = 3;
            this.btn_membership.Text = "Membership Plans";
            this.btn_membership.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_membership.Click += new System.EventHandler(this.btn_membership_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.White;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.BorderRadius = 3;
            this.btn_home.BorderThickness = 1;
            this.btn_home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FillColor = System.Drawing.Color.Gold;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_home.ForeColor = System.Drawing.Color.Black;
            this.btn_home.Image = global::Test1.Properties.Resources.icons8_home_501;
            this.btn_home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_home.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(246, 69);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(685, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to Power Fit.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(741, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 72);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sri Lanka\'s best gym is now\r\n at your own finger tips";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test1.Properties.Resources._124353_popular_gym_background_1920x1110_for_android_tablet1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 563);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.btn_getStarted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panle2_buttun);
            this.Controls.Add(this.panel1_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1_head.ResumeLayout(false);
            this.panel1_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panle2_buttun.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel panle2_buttun;
        private Guna.UI2.WinForms.Guna2Panel panel1_head;
        private Guna.UI2.WinForms.Guna2Button btn_aboutUs;
        private Guna.UI2.WinForms.Guna2Button btn_reports;
        private Guna.UI2.WinForms.Guna2Button btn_trainers;
        private Guna.UI2.WinForms.Guna2Button btn_schedule;
        private Guna.UI2.WinForms.Guna2Button btn_membership;
        private Guna.UI2.WinForms.Guna2Button btn_home;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2Button btn_minmized;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_getStarted;
        private Guna.UI2.WinForms.Guna2Button btn_logIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}