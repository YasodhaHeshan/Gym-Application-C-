namespace Test1
{
    partial class ScheduleReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_load = new Guna.UI2.WinForms.Guna2Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cmb_sPlan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Plan Report";
            // 
            // btn_load
            // 
            this.btn_load.BorderRadius = 20;
            this.btn_load.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_load.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_load.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_load.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_load.FillColor = System.Drawing.Color.Gold;
            this.btn_load.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_load.ForeColor = System.Drawing.Color.Black;
            this.btn_load.Location = new System.Drawing.Point(600, 53);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(152, 45);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load Report";
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(54, 116);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(743, 384);
            this.reportViewer1.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // cmb_sPlan
            // 
            this.cmb_sPlan.AutoRoundedCorners = true;
            this.cmb_sPlan.BackColor = System.Drawing.Color.Transparent;
            this.cmb_sPlan.BorderRadius = 17;
            this.cmb_sPlan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_sPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sPlan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_sPlan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_sPlan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_sPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_sPlan.ItemHeight = 30;
            this.cmb_sPlan.Items.AddRange(new object[] {
            "Plan 1",
            "Plan 2",
            "Plan 3",
            "Plan 4"});
            this.cmb_sPlan.Location = new System.Drawing.Point(215, 62);
            this.cmb_sPlan.Name = "cmb_sPlan";
            this.cmb_sPlan.Size = new System.Drawing.Size(140, 36);
            this.cmb_sPlan.TabIndex = 10;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.BorderRadius = 5;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = global::Test1.Properties.Resources.icons8_close_501;
            this.btn_close.Location = new System.Drawing.Point(832, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 42);
            this.btn_close.TabIndex = 9;
            this.btn_close.UseTransparentBackground = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(60, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Type";
            // 
            // ScheduleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(902, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_sPlan);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScheduleReport";
            this.Text = "ScheduleReport";
            this.Load += new System.EventHandler(this.ScheduleReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_load;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_sPlan;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label2;
    }
}