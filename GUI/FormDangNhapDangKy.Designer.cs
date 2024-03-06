namespace GUI
{
    partial class FormDangNhapDangKy
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
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnBanDaCoTK = new Guna.UI2.WinForms.Guna2Button();
            this.btnChuaCoTK = new Guna.UI2.WinForms.Guna2Button();
            this.uC_DangKy11 = new GUI.All_User_Controller.UC_DangKy1();
            this.uC_DangNhap1 = new GUI.All_User_Controller.UC_DangNhap();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.Transparent;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoat.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnThoat.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnThoat.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Location = new System.Drawing.Point(0, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(2560, 1329);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnBanDaCoTK
            // 
            this.btnBanDaCoTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBanDaCoTK.BorderColor = System.Drawing.Color.Transparent;
            this.btnBanDaCoTK.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBanDaCoTK.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnBanDaCoTK.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnBanDaCoTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBanDaCoTK.FillColor = System.Drawing.Color.Transparent;
            this.btnBanDaCoTK.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBanDaCoTK.ForeColor = System.Drawing.Color.Black;
            this.btnBanDaCoTK.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnBanDaCoTK.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.btnBanDaCoTK.Location = new System.Drawing.Point(1153, 766);
            this.btnBanDaCoTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBanDaCoTK.Name = "btnBanDaCoTK";
            this.btnBanDaCoTK.PressedColor = System.Drawing.Color.Transparent;
            this.btnBanDaCoTK.Size = new System.Drawing.Size(256, 44);
            this.btnBanDaCoTK.TabIndex = 20;
            this.btnBanDaCoTK.Text = "Bạn đã có tài khoản!";
            this.btnBanDaCoTK.Visible = false;
            this.btnBanDaCoTK.Click += new System.EventHandler(this.btnBanDaCoTK_Click_1);
            // 
            // btnChuaCoTK
            // 
            this.btnChuaCoTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnChuaCoTK.BorderColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuaCoTK.FillColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChuaCoTK.ForeColor = System.Drawing.Color.Black;
            this.btnChuaCoTK.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.btnChuaCoTK.Location = new System.Drawing.Point(1220, 743);
            this.btnChuaCoTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChuaCoTK.Name = "btnChuaCoTK";
            this.btnChuaCoTK.PressedColor = System.Drawing.Color.Transparent;
            this.btnChuaCoTK.Size = new System.Drawing.Size(241, 41);
            this.btnChuaCoTK.TabIndex = 21;
            this.btnChuaCoTK.Text = "Bạn chưa có tài khoản!";
            this.btnChuaCoTK.Click += new System.EventHandler(this.btnChuaCoTK_Click);
            // 
            // uC_DangKy11
            // 
            this.uC_DangKy11.Location = new System.Drawing.Point(433, 240);
            this.uC_DangKy11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_DangKy11.Name = "uC_DangKy11";
            this.uC_DangKy11.Size = new System.Drawing.Size(1200, 601);
            this.uC_DangKy11.TabIndex = 17;
            // 
            // uC_DangNhap1
            // 
            this.uC_DangNhap1.Location = new System.Drawing.Point(433, 240);
            this.uC_DangNhap1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_DangNhap1.Name = "uC_DangNhap1";
            this.uC_DangNhap1.Size = new System.Drawing.Size(1200, 601);
            this.uC_DangNhap1.TabIndex = 16;
            // 
            // FormDangNhapDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnBanDaCoTK);
            this.Controls.Add(this.btnChuaCoTK);
            this.Controls.Add(this.uC_DangKy11);
            this.Controls.Add(this.uC_DangNhap1);
            this.Controls.Add(this.btnThoat);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDangNhapDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhapDangKy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDangNhapDangKy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnBanDaCoTK;
        private Guna.UI2.WinForms.Guna2Button btnChuaCoTK;
        private All_User_Controller.UC_DangKy1 uC_DangKy11;
        private All_User_Controller.UC_DangNhap uC_DangNhap1;
    }
}