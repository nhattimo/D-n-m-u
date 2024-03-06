using BLL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_LapPhieuThue : UserControl
    {
        DatPhongBLL DatPhongBLL = new DatPhongBLL();
        PhongBLL PhongBLL = new PhongBLL();
        NguoiDungBLL NguoiDungBLL = new NguoiDungBLL();
        PhieuThueBLL PhieuThueBLL = new PhieuThueBLL();
        NhanVienBLL NhanVienBLL = new NhanVienBLL();
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        public UC_LapPhieuThue()
        {
            InitializeComponent();
        }

        private void UC_LapPhieuThue_Load(object sender, EventArgs e)
        {
            LamMoiUC();
            ShowDanhSachDatPhong();
            ShowDanhSachPhieu();
        }
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            bool check = true;
            // kiểm tra nhập số phòng
            if (string.IsNullOrEmpty(txtSoPhong.Text))
            {
                check = false;
                labelSaiSoPhong.Text = "Không để trống";
            }
            else
            {
                if (IsNumber(txtSoPhong.Text) != true)
                {
                    check = false;
                    labelSaiSoPhong.Text = "Hãy nhập bằng số";
                }
                else
                {
                    if (PhongBLL.IsSoPhong(txtSoPhong.Text) != true)
                    {
                        check = false;
                        labelSaiSoPhong.Text = "Số phòng không tồn tại";
                    }
                    else
                        labelSaiSoPhong.Text = string.Empty;
                }
            }

            // kiểm tra nhập vào CCCD
            if (string.IsNullOrEmpty(txtCCCDNguoiThue.Text))
            {
                check = false;
                labelSaiCCCDNguoiThue.Text = "Không được để trống";
            }
            else if (IsNumber(txtCCCDNguoiThue.Text) != true)
            {
                labelSaiCCCDNguoiThue.Text = "Không chứa ký tự";
                check = false;
            }
            else
            {
                if (txtCCCDNguoiThue.Text.Length < 12 || txtCCCDNguoiThue.Text.Length > 12)
                {
                    labelSaiCCCDNguoiThue.Text = "CCCD không hợp lệ";
                    check = false;
                }
                else
                {
                    if (NguoiDungBLL.IsCCCD(txtCCCDNguoiThue.Text) != true)
                    {
                        labelSaiCCCDNguoiThue.Text = "CCCD không tồn tại";
                        check = false;
                    }
                    else labelSaiCCCDNguoiThue.Text = string.Empty;
                }
            }

            // kiểm tra tên nhan vien
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                check = false;
                labelSaiTenNhanVien.Text = "Không để trống";
            }

            if (check)
            { 
                PhieuThueBLL.InsertPhieuThueAccess(txtSoPhong.Text, DateTime.Parse(txtNgayNhanPhong.Text), DateTime.Parse(txtNgayTraPhong.Text), txtCCCDNguoiThue.Text, NhanVienBLL.GetMaNVAccess(TaiKhoanBLL.GetMaTKFileStream()),"Chưa thanh toán" );
                ShowDanhSachPhieu();
                LabelTaoPhieuThanhCong.Visible = true;
            }
        }

        private void GridViewDanhSachDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridViewDanhSachDatPhong.CurrentRow.Selected = true;
            txtSoPhong.Text = GridViewDanhSachDatPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNgayNhanPhong.Value = DateTime.Parse(GridViewDanhSachDatPhong.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtNgayTraPhong.Value = DateTime.Parse(GridViewDanhSachDatPhong.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtCCCDNguoiThue.Text = GridViewDanhSachDatPhong.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTenNhanVien.Text = NhanVienBLL.GetNameAccess(TaiKhoanBLL.GetMaTKFileStream());
        }
        
        void ShowDanhSachDatPhong()
        {
            GridViewDanhSachDatPhong.Rows.Clear();
            GridViewDanhSachDatPhong.ColumnCount = 5;
            GridViewDanhSachDatPhong.Columns[0].Name = "Số phòng";
            GridViewDanhSachDatPhong.Columns[1].Name = "Thời gian đặt";
            GridViewDanhSachDatPhong.Columns[2].Name = "Ngày nhận phòng";
            GridViewDanhSachDatPhong.Columns[3].Name = "Ngày trả phòng";
            GridViewDanhSachDatPhong.Columns[4].Name = "CCCD người dùng";
            foreach (var item in DatPhongBLL.ListDatPhog())
            {
                string[] row = { item.SoPhong.ToString(), item.ThoiGianDat.ToString(), item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString(), item.CCCD };
                GridViewDanhSachDatPhong.Rows.Add(row);
            }
        }
        void ShowDanhSachPhieu()
        {
            GridViewDanhSachPhieu.Rows.Clear();
            GridViewDanhSachPhieu.ColumnCount = 4;
            GridViewDanhSachPhieu.Columns[0].Name = "Số phòng";
            GridViewDanhSachPhieu.Columns[1].Name = "Ngày nhận phòng";
            GridViewDanhSachPhieu.Columns[2].Name = "Ngày trả phòng";
            GridViewDanhSachPhieu.Columns[3].Name = "CCCD người dùng";
            foreach (var item in PhieuThueBLL.ListPhieuThue())
            {
                string[] row = { item.SoPhong.ToString(), item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString(), item.CCCD};
                GridViewDanhSachPhieu.Rows.Add(row);
            }
        }
        bool IsNumber(string number)
        {
            foreach (Char c in number)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public void LamMoiUC()
        {
            LabelTaoPhieuThanhCong.Visible = false;
            labelSaiSoPhong.Text = string.Empty;
            LabelSaiNgayNhanPhong.Text = string.Empty;
            LabelSaiNgayTraPhong.Text = string.Empty;
            labelSaiCCCDNguoiThue.Text = string.Empty;
            labelSaiTenNhanVien.Text = string.Empty;
            labelSaiTenNhanVien.Text = string.Empty;
        }

        private void txtNgayTraPhong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void labelSaiSoPhong_Click(object sender, EventArgs e)
        {

        }

        private void LabelSaiNgayNhanPhong_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayNhanPhong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCCCDNguoiThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSoPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSaiCCCDNguoiThue_Click(object sender, EventArgs e)
        {

        }

        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSaiTenNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void LabelTaoPhieuThanhCong_Click(object sender, EventArgs e)
        {

        }

        private void LabelSaiNgayTraPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
