namespace GUI
{
    partial class FormNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNguoiDung));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNguoiDung = new Guna.UI2.WinForms.Guna2Button();
            this.txtSoCCCD = new System.Windows.Forms.Label();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.btnDoiPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.panelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_US_NguoiDung1 = new GUI.All_User_Controller.UC_US_NguoiDung();
            this.uC_DichVu1 = new GUI.All_User_Controller.UC_DichVu();
            this.uC_DatPhong1 = new GUI.All_User_Controller.UC_DatPhong();
            this.uC_DoiPhong1 = new GUI.All_User_Controller.UC_DoiPhong();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.btnDoiPhong);
            this.guna2Panel1.Controls.Add(this.btnDichVu);
            this.guna2Panel1.Controls.Add(this.panelMoving);
            this.guna2Panel1.Controls.Add(this.btnDatPhong);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2053, 107);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Beige;
            this.guna2Panel2.Controls.Add(this.btnNguoiDung);
            this.guna2Panel2.Controls.Add(this.txtSoCCCD);
            this.guna2Panel2.Controls.Add(this.btnThoat);
            this.guna2Panel2.Controls.Add(this.txtName);
            this.guna2Panel2.Controls.Add(this.t);
            this.guna2Panel2.Location = new System.Drawing.Point(1648, 1);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(405, 106);
            this.guna2Panel2.TabIndex = 157;
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.BorderColor = System.Drawing.Color.Snow;
            this.btnNguoiDung.BorderRadius = 10;
            this.btnNguoiDung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNguoiDung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNguoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNguoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNguoiDung.FillColor = System.Drawing.Color.Transparent;
            this.btnNguoiDung.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnNguoiDung.ForeColor = System.Drawing.Color.Black;
            this.btnNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("btnNguoiDung.Image")));
            this.btnNguoiDung.ImageSize = new System.Drawing.Size(70, 70);
            this.btnNguoiDung.Location = new System.Drawing.Point(229, 2);
            this.btnNguoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(91, 103);
            this.btnNguoiDung.TabIndex = 11;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_Click);
            // 
            // txtSoCCCD
            // 
            this.txtSoCCCD.AutoSize = true;
            this.txtSoCCCD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoCCCD.Location = new System.Drawing.Point(95, 62);
            this.txtSoCCCD.Name = "txtSoCCCD";
            this.txtSoCCCD.Size = new System.Drawing.Size(138, 19);
            this.txtSoCCCD.TabIndex = 156;
            this.txtSoCCCD.Text = "1111111111111111";
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
            this.btnThoat.Location = new System.Drawing.Point(337, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 103);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "X";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(19, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 23);
            this.txtName.TabIndex = 154;
            this.txtName.Text = "Nguyễn Văn Nhật";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.t.Location = new System.Drawing.Point(19, 62);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(72, 20);
            this.t.TabIndex = 155;
            this.t.Text = "CCCD : ";
            // 
            // btnDoiPhong
            // 
            this.btnDoiPhong.BorderColor = System.Drawing.Color.Snow;
            this.btnDoiPhong.BorderRadius = 10;
            this.btnDoiPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiPhong.FillColor = System.Drawing.Color.Snow;
            this.btnDoiPhong.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDoiPhong.ForeColor = System.Drawing.Color.Black;
            this.btnDoiPhong.Location = new System.Drawing.Point(455, 11);
            this.btnDoiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiPhong.Name = "btnDoiPhong";
            this.btnDoiPhong.Size = new System.Drawing.Size(383, 79);
            this.btnDoiPhong.TabIndex = 14;
            this.btnDoiPhong.Text = "Đổi phòng";
            this.btnDoiPhong.Click += new System.EventHandler(this.btnDoiPhong_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BorderColor = System.Drawing.Color.Snow;
            this.btnDichVu.BorderRadius = 10;
            this.btnDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDichVu.FillColor = System.Drawing.Color.Snow;
            this.btnDichVu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnDichVu.Location = new System.Drawing.Point(875, 11);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(383, 79);
            this.btnDichVu.TabIndex = 8;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // panelMoving
            // 
            this.panelMoving.BackColor = System.Drawing.Color.Gray;
            this.panelMoving.BorderRadius = 5;
            this.panelMoving.Location = new System.Drawing.Point(35, 98);
            this.panelMoving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMoving.Name = "panelMoving";
            this.panelMoving.Size = new System.Drawing.Size(383, 9);
            this.panelMoving.TabIndex = 4;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BorderColor = System.Drawing.Color.Snow;
            this.btnDatPhong.BorderRadius = 10;
            this.btnDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatPhong.FillColor = System.Drawing.Color.Snow;
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDatPhong.ForeColor = System.Drawing.Color.Black;
            this.btnDatPhong.Location = new System.Drawing.Point(35, 11);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(383, 79);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // uC_US_NguoiDung1
            // 
            this.uC_US_NguoiDung1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_US_NguoiDung1.BackgroundImage")));
            this.uC_US_NguoiDung1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_US_NguoiDung1.Location = new System.Drawing.Point(0, 114);
            this.uC_US_NguoiDung1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_US_NguoiDung1.Name = "uC_US_NguoiDung1";
            this.uC_US_NguoiDung1.Size = new System.Drawing.Size(2053, 1081);
            this.uC_US_NguoiDung1.TabIndex = 7;
            // 
            // uC_DichVu1
            // 
            this.uC_DichVu1.BackColor = System.Drawing.Color.Transparent;
            this.uC_DichVu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_DichVu1.BackgroundImage")));
            this.uC_DichVu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_DichVu1.ForeColor = System.Drawing.Color.GreenYellow;
            this.uC_DichVu1.Location = new System.Drawing.Point(0, 114);
            this.uC_DichVu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_DichVu1.Name = "uC_DichVu1";
            this.uC_DichVu1.Size = new System.Drawing.Size(2053, 960);
            this.uC_DichVu1.TabIndex = 6;
            // 
            // uC_DatPhong1
            // 
            this.uC_DatPhong1.BackColor = System.Drawing.Color.Transparent;
            this.uC_DatPhong1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_DatPhong1.BackgroundImage")));
            this.uC_DatPhong1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_DatPhong1.Location = new System.Drawing.Point(0, 114);
            this.uC_DatPhong1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_DatPhong1.Name = "uC_DatPhong1";
            this.uC_DatPhong1.Size = new System.Drawing.Size(2053, 960);
            this.uC_DatPhong1.TabIndex = 5;
            this.uC_DatPhong1.Load += new System.EventHandler(this.uC_DatPhong1_Load);
            // 
            // uC_DoiPhong1
            // 
            this.uC_DoiPhong1.BackColor = System.Drawing.Color.Transparent;
            this.uC_DoiPhong1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_DoiPhong1.BackgroundImage")));
            this.uC_DoiPhong1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_DoiPhong1.Location = new System.Drawing.Point(0, 114);
            this.uC_DoiPhong1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_DoiPhong1.Name = "uC_DoiPhong1";
            this.uC_DoiPhong1.Size = new System.Drawing.Size(2053, 960);
            this.uC_DoiPhong1.TabIndex = 8;
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
            this.btnDangXuat.Location = new System.Drawing.Point(1803, 992);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(236, 58);
            this.btnDangXuat.TabIndex = 158;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // FormNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2053, 1329);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.uC_DoiPhong1);
            this.Controls.Add(this.uC_US_NguoiDung1);
            this.Controls.Add(this.uC_DichVu1);
            this.Controls.Add(this.uC_DatPhong1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNguoiDung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNguoiDung_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDichVu;
        private Guna.UI2.WinForms.Guna2Panel panelMoving;
        private Guna.UI2.WinForms.Guna2Button btnDatPhong;
        private All_User_Controller.UC_DatPhong uC_DatPhong1;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private All_User_Controller.UC_DichVu uC_DichVu1;
        private Guna.UI2.WinForms.Guna2Button btnNguoiDung;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Controller.UC_US_NguoiDung uC_US_NguoiDung1;
        private All_User_Controller.UC_DoiPhong uC_DoiPhong1;
        private Guna.UI2.WinForms.Guna2Button btnDoiPhong;
        private System.Windows.Forms.Label txtSoCCCD;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label txtName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
    }
}