namespace GUI
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangKiKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaNV = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.panelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThongTinPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.uC_Phong1 = new GUI.All_User_Controller.UC_Phong();
            this.uC_DichVu1 = new GUI.All_User_Controller.UC_DichVu();
            this.uC_NV_DatPhong1 = new GUI.All_User_Controller.UC_NV_DatPhong();
            this.uC_KhachHang1 = new GUI.All_User_Controller.UC_KhachHang();
            this.uC_NV_DangKyKhachHang1 = new GUI.All_User_Controller.UC_NV_DangKyKhachHang();
            this.uC_NV_ThanhToan1 = new GUI.All_User_Controller.UC_NV_ThanhToan();
            this.uC_US_NV1 = new GUI.All_User_Controller.UC_US_NV();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.Controls.Add(this.btnDangKiKhachHang);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.btnThanhToan);
            this.guna2Panel1.Controls.Add(this.btnKhachHang);
            this.guna2Panel1.Controls.Add(this.btnDatPhong);
            this.guna2Panel1.Controls.Add(this.panelMoving);
            this.guna2Panel1.Controls.Add(this.btnThongTinPhong);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1540, 78);
            this.guna2Panel1.TabIndex = 5;
            // 
            // btnDangKiKhachHang
            // 
            this.btnDangKiKhachHang.BorderColor = System.Drawing.Color.Snow;
            this.btnDangKiKhachHang.BorderRadius = 10;
            this.btnDangKiKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKiKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKiKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKiKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKiKhachHang.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDangKiKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnDangKiKhachHang.Location = new System.Drawing.Point(705, 6);
            this.btnDangKiKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangKiKhachHang.Name = "btnDangKiKhachHang";
            this.btnDangKiKhachHang.Size = new System.Drawing.Size(210, 65);
            this.btnDangKiKhachHang.TabIndex = 159;
            this.btnDangKiKhachHang.Text = "Đăng ký";
            this.btnDangKiKhachHang.Click += new System.EventHandler(this.btnDangKiKhachHang_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.guna2Panel2.Controls.Add(this.txtMaNV);
            this.guna2Panel2.Controls.Add(this.guna2Button2);
            this.guna2Panel2.Controls.Add(this.txtName);
            this.guna2Panel2.Controls.Add(this.t);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Location = new System.Drawing.Point(1234, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(304, 78);
            this.guna2Panel2.TabIndex = 158;
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoSize = true;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(114, 43);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(59, 19);
            this.txtMaNV.TabIndex = 156;
            this.txtMaNV.Text = "NV001";
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Red;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(248, -2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(58, 78);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "X";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(2, 19);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 23);
            this.txtName.TabIndex = 154;
            this.txtName.Text = "Nguyễn Văn Nhật";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.t.Location = new System.Drawing.Point(2, 42);
            this.t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(122, 20);
            this.t.TabIndex = 155;
            this.t.Text = "Mã nhân viên : ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Snow;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2Button1.Location = new System.Drawing.Point(177, 1);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(70, 67);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderColor = System.Drawing.Color.Snow;
            this.btnThanhToan.BorderRadius = 10;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Location = new System.Drawing.Point(921, 6);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(210, 65);
            this.btnThanhToan.TabIndex = 12;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BorderColor = System.Drawing.Color.Snow;
            this.btnKhachHang.BorderRadius = 10;
            this.btnKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachHang.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Location = new System.Drawing.Point(489, 6);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(210, 65);
            this.btnKhachHang.TabIndex = 11;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BorderColor = System.Drawing.Color.Snow;
            this.btnDatPhong.BorderRadius = 10;
            this.btnDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDatPhong.ForeColor = System.Drawing.Color.Black;
            this.btnDatPhong.Location = new System.Drawing.Point(273, 6);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(210, 65);
            this.btnDatPhong.TabIndex = 10;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // panelMoving
            // 
            this.panelMoving.BackColor = System.Drawing.Color.Gray;
            this.panelMoving.BorderRadius = 5;
            this.panelMoving.Location = new System.Drawing.Point(26, 71);
            this.panelMoving.Margin = new System.Windows.Forms.Padding(2);
            this.panelMoving.Name = "panelMoving";
            this.panelMoving.Size = new System.Drawing.Size(243, 7);
            this.panelMoving.TabIndex = 4;
            // 
            // btnThongTinPhong
            // 
            this.btnThongTinPhong.BorderColor = System.Drawing.Color.Snow;
            this.btnThongTinPhong.BorderRadius = 10;
            this.btnThongTinPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongTinPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongTinPhong.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnThongTinPhong.ForeColor = System.Drawing.Color.Black;
            this.btnThongTinPhong.Location = new System.Drawing.Point(26, 5);
            this.btnThongTinPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongTinPhong.Name = "btnThongTinPhong";
            this.btnThongTinPhong.Size = new System.Drawing.Size(243, 65);
            this.btnThongTinPhong.TabIndex = 2;
            this.btnThongTinPhong.Text = "Phòng và Dịch vụ";
            this.btnThongTinPhong.Click += new System.EventHandler(this.btnThongTinPhong_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BorderColor = System.Drawing.Color.Snow;
            this.btnDangXuat.BorderRadius = 10;
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.IndianRed;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Location = new System.Drawing.Point(1352, 799);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(177, 47);
            this.btnDangXuat.TabIndex = 159;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // uC_Phong1
            // 
            this.uC_Phong1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Phong1.BackgroundImage")));
            this.uC_Phong1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_Phong1.Location = new System.Drawing.Point(0, 82);
            this.uC_Phong1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Phong1.Name = "uC_Phong1";
            this.uC_Phong1.Size = new System.Drawing.Size(1920, 960);
            this.uC_Phong1.TabIndex = 6;
            // 
            // uC_DichVu1
            // 
            this.uC_DichVu1.BackColor = System.Drawing.Color.Transparent;
            this.uC_DichVu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_DichVu1.BackgroundImage")));
            this.uC_DichVu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_DichVu1.ForeColor = System.Drawing.Color.GreenYellow;
            this.uC_DichVu1.Location = new System.Drawing.Point(0, 82);
            this.uC_DichVu1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_DichVu1.Name = "uC_DichVu1";
            this.uC_DichVu1.Size = new System.Drawing.Size(1920, 960);
            this.uC_DichVu1.TabIndex = 7;
            // 
            // uC_NV_DatPhong1
            // 
            this.uC_NV_DatPhong1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_NV_DatPhong1.BackgroundImage")));
            this.uC_NV_DatPhong1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_NV_DatPhong1.Location = new System.Drawing.Point(0, 82);
            this.uC_NV_DatPhong1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_NV_DatPhong1.Name = "uC_NV_DatPhong1";
            this.uC_NV_DatPhong1.Size = new System.Drawing.Size(1920, 960);
            this.uC_NV_DatPhong1.TabIndex = 8;
            // 
            // uC_KhachHang1
            // 
            this.uC_KhachHang1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_KhachHang1.BackgroundImage")));
            this.uC_KhachHang1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_KhachHang1.Location = new System.Drawing.Point(0, 82);
            this.uC_KhachHang1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_KhachHang1.Name = "uC_KhachHang1";
            this.uC_KhachHang1.Size = new System.Drawing.Size(1540, 960);
            this.uC_KhachHang1.TabIndex = 9;
            // 
            // uC_NV_DangKyKhachHang1
            // 
            this.uC_NV_DangKyKhachHang1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_NV_DangKyKhachHang1.BackgroundImage")));
            this.uC_NV_DangKyKhachHang1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_NV_DangKyKhachHang1.Location = new System.Drawing.Point(0, 82);
            this.uC_NV_DangKyKhachHang1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_NV_DangKyKhachHang1.Name = "uC_NV_DangKyKhachHang1";
            this.uC_NV_DangKyKhachHang1.Size = new System.Drawing.Size(1540, 780);
            this.uC_NV_DangKyKhachHang1.TabIndex = 160;
            // 
            // uC_NV_ThanhToan1
            // 
            this.uC_NV_ThanhToan1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_NV_ThanhToan1.BackgroundImage")));
            this.uC_NV_ThanhToan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_NV_ThanhToan1.Location = new System.Drawing.Point(0, 83);
            this.uC_NV_ThanhToan1.Name = "uC_NV_ThanhToan1";
            this.uC_NV_ThanhToan1.Size = new System.Drawing.Size(2053, 960);
            this.uC_NV_ThanhToan1.TabIndex = 161;
            // 
            // uC_US_NV1
            // 
            this.uC_US_NV1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_US_NV1.BackgroundImage")));
            this.uC_US_NV1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_US_NV1.Location = new System.Drawing.Point(0, 83);
            this.uC_US_NV1.Name = "uC_US_NV1";
            this.uC_US_NV1.Size = new System.Drawing.Size(2053, 960);
            this.uC_US_NV1.TabIndex = 162;
            // 
            // FormNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1540, 1080);
            this.Controls.Add(this.uC_US_NV1);
            this.Controls.Add(this.uC_NV_ThanhToan1);
            this.Controls.Add(this.uC_NV_DangKyKhachHang1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.uC_KhachHang1);
            this.Controls.Add(this.uC_NV_DatPhong1);
            this.Controls.Add(this.uC_DichVu1);
            this.Controls.Add(this.uC_Phong1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel panelMoving;
        private Guna.UI2.WinForms.Guna2Button btnThongTinPhong;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnDatPhong;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label txtMaNV;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label t;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnDangKiKhachHang;
        private All_User_Controller.UC_Phong uC_Phong1;
        private All_User_Controller.UC_DichVu uC_DichVu1;
        private All_User_Controller.UC_NV_DatPhong uC_NV_DatPhong1;
        private All_User_Controller.UC_KhachHang uC_KhachHang1;
        private All_User_Controller.UC_NV_DangKyKhachHang uC_NV_DangKyKhachHang1;
        private All_User_Controller.UC_NV_ThanhToan uC_NV_ThanhToan1;
        private All_User_Controller.UC_US_NV uC_US_NV1;
    }
}