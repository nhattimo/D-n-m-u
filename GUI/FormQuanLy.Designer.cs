namespace GUI
{
    partial class FormQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLy));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnBaoCaoThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThemPhong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_ThemDichVu1 = new GUI.All_User_Controller.UC_ThemDichVu();
            this.uS_BaoCaoThongKe1 = new GUI.All_User_Controller.US_BaoCaoThongKe();
            this.uC_ThemNhanVien1 = new GUI.All_User_Controller.UC_ThemNhanVien();
            this.uC_ThemPhong1 = new GUI.All_User_Controller.UC_ThemPhong();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.Controls.Add(this.btnDangXuat);
            this.guna2Panel1.Controls.Add(this.btnBaoCaoThongKe);
            this.guna2Panel1.Controls.Add(this.btnNhanVien);
            this.guna2Panel1.Controls.Add(this.btnDichVu);
            this.guna2Panel1.Controls.Add(this.btnThoat);
            this.guna2Panel1.Controls.Add(this.panelMoving);
            this.guna2Panel1.Controls.Add(this.btnThemPhong);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2053, 106);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.BorderRadius = 10;
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.IndianRed;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Location = new System.Drawing.Point(1780, 11);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(205, 79);
            this.btnDangXuat.TabIndex = 159;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnBaoCaoThongKe
            // 
            this.btnBaoCaoThongKe.BorderColor = System.Drawing.Color.Snow;
            this.btnBaoCaoThongKe.BorderRadius = 10;
            this.btnBaoCaoThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCaoThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCaoThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaoCaoThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoCaoThongKe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBaoCaoThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnBaoCaoThongKe.Location = new System.Drawing.Point(1079, 11);
            this.btnBaoCaoThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            this.btnBaoCaoThongKe.Size = new System.Drawing.Size(341, 79);
            this.btnBaoCaoThongKe.TabIndex = 13;
            this.btnBaoCaoThongKe.Text = "Báo cáo - Thống kê";
            this.btnBaoCaoThongKe.Click += new System.EventHandler(this.btnBaoCaoThongKe_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BorderColor = System.Drawing.Color.Snow;
            this.btnNhanVien.BorderRadius = 10;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Location = new System.Drawing.Point(731, 11);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(341, 79);
            this.btnNhanVien.TabIndex = 12;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BorderColor = System.Drawing.Color.Snow;
            this.btnDichVu.BorderRadius = 10;
            this.btnDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDichVu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnDichVu.Location = new System.Drawing.Point(383, 11);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(341, 79);
            this.btnDichVu.TabIndex = 11;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1991, 2);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(59, 101);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "X";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelMoving
            // 
            this.panelMoving.BackColor = System.Drawing.Color.Gray;
            this.panelMoving.BorderRadius = 5;
            this.panelMoving.Location = new System.Drawing.Point(35, 94);
            this.panelMoving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMoving.Name = "panelMoving";
            this.panelMoving.Size = new System.Drawing.Size(341, 9);
            this.panelMoving.TabIndex = 4;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BorderColor = System.Drawing.Color.Snow;
            this.btnThemPhong.BorderRadius = 10;
            this.btnThemPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemPhong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemPhong.ForeColor = System.Drawing.Color.Black;
            this.btnThemPhong.Location = new System.Drawing.Point(35, 11);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(341, 79);
            this.btnThemPhong.TabIndex = 2;
            this.btnThemPhong.Text = "Phòng";
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // uC_ThemDichVu1
            // 
            this.uC_ThemDichVu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ThemDichVu1.BackgroundImage")));
            this.uC_ThemDichVu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_ThemDichVu1.Location = new System.Drawing.Point(0, 111);
            this.uC_ThemDichVu1.Name = "uC_ThemDichVu1";
            this.uC_ThemDichVu1.Size = new System.Drawing.Size(2053, 960);
            this.uC_ThemDichVu1.TabIndex = 8;
            this.uC_ThemDichVu1.Load += new System.EventHandler(this.uC_ThemDichVu1_Load);
            // 
            // uS_BaoCaoThongKe1
            // 
            this.uS_BaoCaoThongKe1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uS_BaoCaoThongKe1.BackgroundImage")));
            this.uS_BaoCaoThongKe1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uS_BaoCaoThongKe1.Location = new System.Drawing.Point(0, 111);
            this.uS_BaoCaoThongKe1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uS_BaoCaoThongKe1.Name = "uS_BaoCaoThongKe1";
            this.uS_BaoCaoThongKe1.Size = new System.Drawing.Size(2053, 960);
            this.uS_BaoCaoThongKe1.TabIndex = 7;
            // 
            // uC_ThemNhanVien1
            // 
            this.uC_ThemNhanVien1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ThemNhanVien1.BackgroundImage")));
            this.uC_ThemNhanVien1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_ThemNhanVien1.Location = new System.Drawing.Point(0, 111);
            this.uC_ThemNhanVien1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_ThemNhanVien1.Name = "uC_ThemNhanVien1";
            this.uC_ThemNhanVien1.Size = new System.Drawing.Size(2053, 960);
            this.uC_ThemNhanVien1.TabIndex = 6;
            // 
            // uC_ThemPhong1
            // 
            this.uC_ThemPhong1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ThemPhong1.BackgroundImage")));
            this.uC_ThemPhong1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_ThemPhong1.Location = new System.Drawing.Point(0, 111);
            this.uC_ThemPhong1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_ThemPhong1.Name = "uC_ThemPhong1";
            this.uC_ThemPhong1.Size = new System.Drawing.Size(2053, 960);
            this.uC_ThemPhong1.TabIndex = 4;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2053, 1080);
            this.Controls.Add(this.uC_ThemDichVu1);
            this.Controls.Add(this.uS_BaoCaoThongKe1);
            this.Controls.Add(this.uC_ThemNhanVien1);
            this.Controls.Add(this.uC_ThemPhong1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuanLy_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelMoving;
        private Guna.UI2.WinForms.Guna2Button btnThemPhong;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private All_User_Controller.UC_ThemPhong uC_ThemPhong1;
        private Guna.UI2.WinForms.Guna2Button btnDichVu;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnBaoCaoThongKe;
        private All_User_Controller.US_BaoCaoThongKe uS_BaoCaoThongKe1;
        private All_User_Controller.UC_ThemNhanVien uC_ThemNhanVien1;
        private All_User_Controller.UC_ThemDichVu uC_ThemDichVu1;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
    }
}