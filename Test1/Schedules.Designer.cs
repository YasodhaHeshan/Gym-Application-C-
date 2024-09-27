namespace Test1
{
    partial class Schedules
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fatLoss = new Guna.UI2.WinForms.Guna2Button();
            this.btn_MassGain = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedules";
            // 
            // btn_fatLoss
            // 
            this.btn_fatLoss.BackColor = System.Drawing.Color.Transparent;
            this.btn_fatLoss.BorderRadius = 10;
            this.btn_fatLoss.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_fatLoss.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_fatLoss.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fatLoss.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_fatLoss.FillColor = System.Drawing.Color.Tan;
            this.btn_fatLoss.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_fatLoss.ForeColor = System.Drawing.Color.Black;
            this.btn_fatLoss.Location = new System.Drawing.Point(287, 466);
            this.btn_fatLoss.Name = "btn_fatLoss";
            this.btn_fatLoss.Size = new System.Drawing.Size(172, 48);
            this.btn_fatLoss.TabIndex = 1;
            this.btn_fatLoss.Text = "Fat Loss";
            this.btn_fatLoss.UseTransparentBackground = true;
            this.btn_fatLoss.Click += new System.EventHandler(this.btn_fatLoss_Click);
            // 
            // btn_MassGain
            // 
            this.btn_MassGain.BackColor = System.Drawing.Color.Transparent;
            this.btn_MassGain.BorderRadius = 10;
            this.btn_MassGain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_MassGain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_MassGain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_MassGain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_MassGain.FillColor = System.Drawing.Color.Tan;
            this.btn_MassGain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_MassGain.ForeColor = System.Drawing.Color.Black;
            this.btn_MassGain.Location = new System.Drawing.Point(74, 466);
            this.btn_MassGain.Name = "btn_MassGain";
            this.btn_MassGain.Size = new System.Drawing.Size(172, 48);
            this.btn_MassGain.TabIndex = 1;
            this.btn_MassGain.Text = "Mass Gain";
            this.btn_MassGain.UseTransparentBackground = true;
            this.btn_MassGain.Click += new System.EventHandler(this.btn_MassGain_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderRadius = 10;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = global::Test1.Properties.Resources.icons8_close_501;
            this.btn_close.Location = new System.Drawing.Point(1033, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(46, 43);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseTransparentBackground = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test1.Properties.Resources._124364_best_gym_background_1920x1200_for_windows_71;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 598);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_MassGain);
            this.Controls.Add(this.btn_fatLoss);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Schedules";
            this.Text = "Schedules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_MassGain;
        private Guna.UI2.WinForms.Guna2Button btn_fatLoss;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}