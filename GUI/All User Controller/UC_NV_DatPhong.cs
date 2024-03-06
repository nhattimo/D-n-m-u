using BLL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_NV_DatPhong : UserControl
    {
        DatPhongBLL DatPhongBLL = new DatPhongBLL();
        PhongBLL PhongBLL = new PhongBLL();
        NguoiDungBLL NguoiDungBLL = new NguoiDungBLL();
        PhieuThueBLL PhieuThueBLL = new PhieuThueBLL();
        NhanVienBLL NhanVienBLL = new NhanVienBLL();
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        //int MaDP;
        public UC_NV_DatPhong()
        {
            InitializeComponent();
        }

        private void UC_NV_DatPhong_Load(object sender, EventArgs e)
        {
            LamMoiLabelVaText();
            ShowDanhSachKhanhDatPhong();
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
                labelSaiCCCDNguoiThue.Text = "Không chứ ký tự";
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
                PhieuThueBLL.InsertPhieuThueAccess(txtSoPhong.Text, DateTime.Parse(txtNgayNhanPhong.Text), DateTime.Parse(txtNgayTraPhong.Text), txtCCCDNguoiThue.Text, NhanVienBLL.GetMaNVAccess(TaiKhoanBLL.GetMaTKFileStream()), "Chưa thanh toán");
                DatPhongBLL.DeleteAccess(int.Parse(txtMaDP.Text));
                PhongBLL.UpdateTrangThaiPhongAccess(txtSoPhong.Text,"Đang sử dụng");
                NguoiDungBLL.UpdateAccess(txtCCCDNguoiThue.Text, int.Parse(txtSoPhong.Text));
                ShowDanhSachKhanhDatPhong();
                ShowDanhSachPhieu();
                LamMoiLabelVaText();
                LabelTaoPhieuThanhCong.Visible = true;
            }
        }

        private void GridViewDanhSachDatPhong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewDanhSachDatPhong.CurrentRow.Selected = true;
                GridViewDanhSachDatPhong.ReadOnly = true;
                if (GridViewDanhSachDatPhong.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    LamMoiLabelVaText();
                }
                else {
                    txtMaDP.Text = GridViewDanhSachDatPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtSoPhong.Text = GridViewDanhSachDatPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtCCCDNguoiThue.Text = GridViewDanhSachDatPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtNgayNhanPhong.Value = DateTime.Parse(GridViewDanhSachDatPhong.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txtNgayTraPhong.Value = DateTime.Parse(GridViewDanhSachDatPhong.Rows[e.RowIndex].Cells[6].Value.ToString());
                    txtTenNhanVien.Text = NhanVienBLL.GetNameAccess(TaiKhoanBLL.GetMaTKFileStream());
                    txtSoPhong.ReadOnly = true;
                    txtCCCDNguoiThue.ReadOnly = true;
                    txtTenNhanVien.ReadOnly = true;
                }
            }
            catch (Exception)
            {
                LamMoiLabelVaText();
            }
        }

        private void GridViewDanhSachPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void ShowDanhSachKhanhDatPhong()
        {
            GridViewDanhSachDatPhong.Rows.Clear();
            GridViewDanhSachDatPhong.ReadOnly = true;
            GridViewDanhSachDatPhong.ColumnCount = 7;
            GridViewDanhSachDatPhong.Columns[0].Name = "MaDP";
            GridViewDanhSachDatPhong.Columns[1].Name = "Số phòng";
            GridViewDanhSachDatPhong.Columns[2].Name = "Khách hàng";
            GridViewDanhSachDatPhong.Columns[3].Name = "CCCD";
            GridViewDanhSachDatPhong.Columns[4].Name = "Thời gian đặt";
            GridViewDanhSachDatPhong.Columns[5].Name = "Ngày nhận phòng";
            GridViewDanhSachDatPhong.Columns[6].Name = "Ngày trả phòng";
            
            foreach (var item in DatPhongBLL.ListDatPhog())
            {
                string timeDatPhong = item.ThoiGianDat.Hour + " : " + item.ThoiGianDat.Minute + "  "
                                        + item.ThoiGianDat.Day + "/" + item.ThoiGianDat.Month + "/" 
                                        + item.ThoiGianDat.Day;

                string[] row = { item.MaDP.ToString(), item.SoPhong.ToString(), NguoiDungBLL.GetName(item.CCCD), item.CCCD, timeDatPhong, item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString() };
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
                string[] row = { item.SoPhong.ToString(), item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString(), item.CCCD };
                GridViewDanhSachPhieu.Rows.Add(row);
            }
        }
        void LamMoiLabelVaText()
        {
            LabelTaoPhieuThanhCong.Visible = false;
            labelSaiSoPhong.Text = string.Empty;
            LabelSaiNgayNhanPhong.Text = string.Empty;
            LabelSaiNgayTraPhong.Text = string.Empty;
            labelSaiCCCDNguoiThue.Text = string.Empty;
            labelSaiTenNhanVien.Text = string.Empty;
            labelSaiTenNhanVien.Text = string.Empty;

            txtSoPhong.Text = "";
            txtNgayNhanPhong.Text = DateTime.Now.ToString();
            txtNgayTraPhong.Text = DateTime.Now.ToString();
            txtCCCDNguoiThue.Text = "";
            txtTenNhanVien.Text = NhanVienBLL.GetNameAccess(TaiKhoanBLL.GetMaTKFileStream());

            txtSoPhong.ReadOnly = false;
            txtCCCDNguoiThue.ReadOnly = false;
            txtTenNhanVien.ReadOnly = false;
            
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

        
    }
}
