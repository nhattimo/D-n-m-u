namespace GUI.All_User_Controller
{
    partial class UC_LapPhieuThue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.GridViewDanhSachDatPhong = new System.Windows.Forms.DataGridView();
            this.GridViewDanhSachPhieu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCCCDNguoiThue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelSaiNgayNhanPhong = new System.Windows.Forms.Label();
            this.txtNgayNhanPhong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelSaiSoPhong = new System.Windows.Forms.Label();
            this.labelSaiCCCDNguoiThue = new System.Windows.Forms.Label();
            this.labelSaiTenNhanVien = new System.Windows.Forms.Label();
            this.btnTaoPhieu = new Guna.UI2.WinForms.Guna2Button();
            this.LabelTaoPhieuThanhCong = new System.Windows.Forms.Label();
            this.LabelSaiNgayTraPhong = new System.Windows.Forms.Label();
            this.txtNgayTraPhong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDanhSachDatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDanhSachPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // GridViewDanhSachDatPhong
            // 
            this.GridViewDanhSachDatPhong.BackgroundColor = System.Drawing.Color.White;
            this.GridViewDanhSachDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDanhSachDatPhong.Location = new System.Drawing.Point(47, 76);
            this.GridViewDanhSachDatPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewDanhSachDatPhong.Name = "GridViewDanhSachDatPhong";
            this.GridViewDanhSachDatPhong.RowHeadersWidth = 51;
            this.GridViewDanhSachDatPhong.RowTemplate.Height = 24;
            this.GridViewDanhSachDatPhong.Size = new System.Drawing.Size(1111, 455);
            this.GridViewDanhSachDatPhong.TabIndex = 62;
            this.GridViewDanhSachDatPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDanhSachDatPhong_CellClick);
            // 
            // GridViewDanhSachPhieu
            // 
            this.GridViewDanhSachPhieu.BackgroundColor = System.Drawing.Color.White;
            this.GridViewDanhSachPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDanhSachPhieu.Location = new System.Drawing.Point(45, 604);
            this.GridViewDanhSachPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewDanhSachPhieu.Name = "GridViewDanhSachPhieu";
            this.GridViewDanhSachPhieu.RowHeadersWidth = 51;
            this.GridViewDanhSachPhieu.RowTemplate.Height = 24;
            this.GridViewDanhSachPhieu.Size = new System.Drawing.Size(1112, 326);
            this.GridViewDanhSachPhieu.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 35);
            this.label1.TabIndex = 66;
            this.label1.Text = "Danh sách đặt phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(41, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 35);
            this.label2.TabIndex = 67;
            this.label2.Text = "Danh sách phiếu";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanVien.DefaultText = "";
            this.txtTenNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtTenNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.Location = new System.Drawing.Point(1241, 572);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.PasswordChar = '\0';
            this.txtTenNhanVien.PlaceholderText = "";
            this.txtTenNhanVien.SelectedText = "";
            this.txtTenNhanVien.Size = new System.Drawing.Size(545, 44);
            this.txtTenNhanVien.TabIndex = 117;
            this.txtTenNhanVien.TextChanged += new System.EventHandler(this.txtTenNhanVien_TextChanged);
            // 
            // txtCCCDNguoiThue
            // 
            this.txtCCCDNguoiThue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCDNguoiThue.DefaultText = "";
            this.txtCCCDNguoiThue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCDNguoiThue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCDNguoiThue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCDNguoiThue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCDNguoiThue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCDNguoiThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCCCDNguoiThue.ForeColor = System.Drawing.Color.Black;
            this.txtCCCDNguoiThue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCDNguoiThue.Location = new System.Drawing.Point(1241, 475);
            this.txtCCCDNguoiThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCDNguoiThue.Name = "txtCCCDNguoiThue";
            this.txtCCCDNguoiThue.PasswordChar = '\0';
            this.txtCCCDNguoiThue.PlaceholderText = "";
            this.txtCCCDNguoiThue.SelectedText = "";
            this.txtCCCDNguoiThue.Size = new System.Drawing.Size(545, 44);
            this.txtCCCDNguoiThue.TabIndex = 116;
            this.txtCCCDNguoiThue.TextChanged += new System.EventHandler(this.txtCCCDNguoiThue_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(1239, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 35);
            this.label8.TabIndex = 114;
            this.label8.Text = "Lập phiếu thuê phòng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(1240, 554);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(91, 16);
            this.lb.TabIndex = 113;
            this.lb.Text = "Tên nhân viên";
            this.lb.Click += new System.EventHandler(this.lb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1240, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 112;
            this.label4.Text = "CCCD người thuê phòng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1243, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 111;
            this.label3.Text = "Ngày nhận phòng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1243, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 110;
            this.label6.Text = "Số phòng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoPhong.DefaultText = "";
            this.txtSoPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoPhong.ForeColor = System.Drawing.Color.Black;
            this.txtSoPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Location = new System.Drawing.Point(1245, 174);
            this.txtSoPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.PasswordChar = '\0';
            this.txtSoPhong.PlaceholderText = "";
            this.txtSoPhong.SelectedText = "";
            this.txtSoPhong.Size = new System.Drawing.Size(545, 44);
            this.txtSoPhong.TabIndex = 109;
            this.txtSoPhong.TextChanged += new System.EventHandler(this.txtSoPhong_TextChanged);
            // 
            // LabelSaiNgayNhanPhong
            // 
            this.LabelSaiNgayNhanPhong.AutoSize = true;
            this.LabelSaiNgayNhanPhong.ForeColor = System.Drawing.Color.Red;
            this.LabelSaiNgayNhanPhong.Location = new System.Drawing.Point(1243, 322);
            this.LabelSaiNgayNhanPhong.Name = "LabelSaiNgayNhanPhong";
            this.LabelSaiNgayNhanPhong.Size = new System.Drawing.Size(25, 16);
            this.LabelSaiNgayNhanPhong.TabIndex = 120;
            this.LabelSaiNgayNhanPhong.Text = "Lỗi";
            this.LabelSaiNgayNhanPhong.Click += new System.EventHandler(this.LabelSaiNgayNhanPhong_Click);
            // 
            // txtNgayNhanPhong
            // 
            this.txtNgayNhanPhong.BackColor = System.Drawing.Color.White;
            this.txtNgayNhanPhong.Checked = true;
            this.txtNgayNhanPhong.FillColor = System.Drawing.Color.White;
            this.txtNgayNhanPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtNgayNhanPhong.Location = new System.Drawing.Point(1244, 274);
            this.txtNgayNhanPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgayNhanPhong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtNgayNhanPhong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtNgayNhanPhong.Name = "txtNgayNhanPhong";
            this.txtNgayNhanPhong.Size = new System.Drawing.Size(544, 44);
            this.txtNgayNhanPhong.TabIndex = 118;
            this.txtNgayNhanPhong.Value = new System.DateTime(2023, 10, 2, 20, 5, 0, 423);
            this.txtNgayNhanPhong.ValueChanged += new System.EventHandler(this.txtNgayNhanPhong_ValueChanged);
            // 
            // labelSaiSoPhong
            // 
            this.labelSaiSoPhong.AutoSize = true;
            this.labelSaiSoPhong.ForeColor = System.Drawing.Color.Red;
            this.labelSaiSoPhong.Location = new System.Drawing.Point(1243, 220);
            this.labelSaiSoPhong.Name = "labelSaiSoPhong";
            this.labelSaiSoPhong.Size = new System.Drawing.Size(25, 16);
            this.labelSaiSoPhong.TabIndex = 121;
            this.labelSaiSoPhong.Text = "Lỗi";
            this.labelSaiSoPhong.Click += new System.EventHandler(this.labelSaiSoPhong_Click);
            // 
            // labelSaiCCCDNguoiThue
            // 
            this.labelSaiCCCDNguoiThue.AutoSize = true;
            this.labelSaiCCCDNguoiThue.ForeColor = System.Drawing.Color.Red;
            this.labelSaiCCCDNguoiThue.Location = new System.Drawing.Point(1240, 521);
            this.labelSaiCCCDNguoiThue.Name = "labelSaiCCCDNguoiThue";
            this.labelSaiCCCDNguoiThue.Size = new System.Drawing.Size(25, 16);
            this.labelSaiCCCDNguoiThue.TabIndex = 122;
            this.labelSaiCCCDNguoiThue.Text = "Lỗi";
            this.labelSaiCCCDNguoiThue.Click += new System.EventHandler(this.labelSaiCCCDNguoiThue_Click);
            // 
            // labelSaiTenNhanVien
            // 
            this.labelSaiTenNhanVien.AutoSize = true;
            this.labelSaiTenNhanVien.ForeColor = System.Drawing.Color.Red;
            this.labelSaiTenNhanVien.Location = new System.Drawing.Point(1240, 622);
            this.labelSaiTenNhanVien.Name = "labelSaiTenNhanVien";
            this.labelSaiTenNhanVien.Size = new System.Drawing.Size(25, 16);
            this.labelSaiTenNhanVien.TabIndex = 123;
            this.labelSaiTenNhanVien.Text = "Lỗi";
            this.labelSaiTenNhanVien.Click += new System.EventHandler(this.labelSaiTenNhanVien_Click);
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BorderColor = System.Drawing.Color.Snow;
            this.btnTaoPhieu.BorderRadius = 10;
            this.btnTaoPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaoPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaoPhieu.FillColor = System.Drawing.Color.ForestGreen;
            this.btnTaoPhieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoPhieu.ForeColor = System.Drawing.Color.Black;
            this.btnTaoPhieu.Location = new System.Drawing.Point(1605, 681);
            this.btnTaoPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(180, 46);
            this.btnTaoPhieu.TabIndex = 124;
            this.btnTaoPhieu.Text = "Tạo phiếu";
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // LabelTaoPhieuThanhCong
            // 
            this.LabelTaoPhieuThanhCong.AutoSize = true;
            this.LabelTaoPhieuThanhCong.ForeColor = System.Drawing.Color.ForestGreen;
            this.LabelTaoPhieuThanhCong.Location = new System.Drawing.Point(1452, 644);
            this.LabelTaoPhieuThanhCong.Name = "LabelTaoPhieuThanhCong";
            this.LabelTaoPhieuThanhCong.Size = new System.Drawing.Size(136, 16);
            this.LabelTaoPhieuThanhCong.TabIndex = 125;
            this.LabelTaoPhieuThanhCong.Text = "Tạo phiếu thành công";
            this.LabelTaoPhieuThanhCong.Click += new System.EventHandler(this.LabelTaoPhieuThanhCong_Click);
            // 
            // LabelSaiNgayTraPhong
            // 
            this.LabelSaiNgayTraPhong.AutoSize = true;
            this.LabelSaiNgayTraPhong.ForeColor = System.Drawing.Color.Red;
            this.LabelSaiNgayTraPhong.Location = new System.Drawing.Point(1241, 423);
            this.LabelSaiNgayTraPhong.Name = "LabelSaiNgayTraPhong";
            this.LabelSaiNgayTraPhong.Size = new System.Drawing.Size(25, 16);
            this.LabelSaiNgayTraPhong.TabIndex = 128;
            this.LabelSaiNgayTraPhong.Text = "Lỗi";
            this.LabelSaiNgayTraPhong.Click += new System.EventHandler(this.LabelSaiNgayTraPhong_Click);
            // 
            // txtNgayTraPhong
            // 
            this.txtNgayTraPhong.BackColor = System.Drawing.Color.White;
            this.txtNgayTraPhong.Checked = true;
            this.txtNgayTraPhong.FillColor = System.Drawing.Color.White;
            this.txtNgayTraPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtNgayTraPhong.Location = new System.Drawing.Point(1243, 375);
            this.txtNgayTraPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgayTraPhong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtNgayTraPhong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtNgayTraPhong.Name = "txtNgayTraPhong";
            this.txtNgayTraPhong.Size = new System.Drawing.Size(544, 44);
            this.txtNgayTraPhong.TabIndex = 127;
            this.txtNgayTraPhong.Value = new System.DateTime(2023, 10, 2, 20, 5, 0, 423);
            this.txtNgayTraPhong.ValueChanged += new System.EventHandler(this.txtNgayTraPhong_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1241, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 126;
            this.label7.Text = "Ngày trả phòng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // UC_LapPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelSaiNgayTraPhong);
            this.Controls.Add(this.txtNgayTraPhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LabelTaoPhieuThanhCong);
            this.Controls.Add(this.btnTaoPhieu);
            this.Controls.Add(this.labelSaiTenNhanVien);
            this.Controls.Add(this.labelSaiCCCDNguoiThue);
            this.Controls.Add(this.labelSaiSoPhong);
            this.Controls.Add(this.LabelSaiNgayNhanPhong);
            this.Controls.Add(this.txtNgayNhanPhong);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtCCCDNguoiThue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewDanhSachPhieu);
            this.Controls.Add(this.GridViewDanhSachDatPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_LapPhieuThue";
            this.Size = new System.Drawing.Size(1920, 960);
            this.Load += new System.EventHandler(this.UC_LapPhieuThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDanhSachDatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDanhSachPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.DataGridView GridViewDanhSachDatPhong;
        private System.Windows.Forms.DataGridView GridViewDanhSachPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCDNguoiThue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSoPhong;
        private System.Windows.Forms.Label LabelSaiNgayNhanPhong;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtNgayNhanPhong;
        private System.Windows.Forms.Label labelSaiTenNhanVien;
        private System.Windows.Forms.Label labelSaiCCCDNguoiThue;
        private System.Windows.Forms.Label labelSaiSoPhong;
        private Guna.UI2.WinForms.Guna2Button btnTaoPhieu;
        private System.Windows.Forms.Label LabelTaoPhieuThanhCong;
        private System.Windows.Forms.Label LabelSaiNgayTraPhong;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtNgayTraPhong;
        private System.Windows.Forms.Label label7;
    }
}
