using BLL;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_NV_ThanhToan : UserControl
    {
        PhieuThueBLL phieuThueBLL = new PhieuThueBLL();
        NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
        NhanVienBLL NhanVienBLL = new NhanVienBLL();
        PhongBLL PhongBLL = new PhongBLL();
        DatDichVuBLL datDichVuBLL = new DatDichVuBLL();
        DichVuBLL dichVuBLL = new DichVuBLL();
        ThongKeBLL ThongKeBLL = new ThongKeBLL();
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        int tongTien;
        int slDV;
        int GiaTongTienDV;
        int GiaTongP;
        string MaNV;
        int maPhiue;
        public UC_NV_ThanhToan()
        {
            InitializeComponent();
        }

        private void UC_NV_ThanhToan_Load(object sender, EventArgs e)
        {
            LamMoi();
            ShowNguuoiXuDung();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LamMoi();
            ShowNguuoiXuDung();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MaNV);
            ThongKeBLL.InsertAccess(int.Parse(txtSP.Text),int.Parse(txtTongGio.Text), slDV, GiaTongTienDV, GiaTongP,txtCCCD.Text, MaNV, GiaTongTienDV + GiaTongP);
            phieuThueBLL.UpdateAccessTT(maPhiue, "Đã thanh toán");
            LamMoi();
            ShowNguuoiXuDung();
            MessageBox.Show("Thanh toán thành công");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hoàn tất");
        }
        void ShowNguuoiXuDung()
        {
            GridViewDanhSachNguoiXuDung.Rows.Clear();
            GridViewDanhSachNguoiXuDung.ColumnCount = 4;
            GridViewDanhSachNguoiXuDung.Columns[0].Name = "Mã phiếu";
            GridViewDanhSachNguoiXuDung.Columns[1].Name = "Người dùng";
            GridViewDanhSachNguoiXuDung.Columns[2].Name = "Số phòng";
            GridViewDanhSachNguoiXuDung.Columns[3].Name = "Nhân viên lập phiếu";

            foreach (var item in phieuThueBLL.ListPhieuThue())
            {
                if (item.TrangThai == "Chưa thanh toán")
                {
                    string[] row = { item.MaPhieu.ToString(), nguoiDungBLL.GetName(item.CCCD), item.SoPhong, NhanVienBLL.GetNameAccess(item.MaNV) };
                    GridViewDanhSachNguoiXuDung.Rows.Add(row);
                }
            } 
        }
        private void GridViewDanhSachNguoiXuDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LamMoi();
            try
            {
                tongTien = 0;
                GiaTongP = 0;
                GridViewDanhSachNguoiXuDung.CurrentRow.Selected = true;
                GridViewDanhSachNguoiXuDung.ReadOnly = true;
                btnIn.Visible = true;
                btnThanhToan.Visible = true;
                labelDVDaSuDung.Visible = true;
                GridViewDanhSachDichVu.Visible = true;
                if (GridViewDanhSachNguoiXuDung.Rows[e.RowIndex].Cells[1].Value == null) {
                    LamMoi();
                }
                else
                {
                    txtTenNguoiDung.Text = GridViewDanhSachNguoiXuDung.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSP.Text = GridViewDanhSachNguoiXuDung.Rows[e.RowIndex].Cells[2].Value.ToString();
                    maPhiue = int.Parse(GridViewDanhSachNguoiXuDung.Rows[e.RowIndex].Cells[0].Value.ToString());
                    foreach (var item in PhongBLL.GetListPhongAccess(GridViewDanhSachNguoiXuDung.Rows[e.RowIndex].Cells[2].Value.ToString()))
                    {
                        txtSP.Text = item.SoPhong;
                        txtLoaiPhong.Text = item.LoaiPhong;
                        txtLoaiGiuong.Text = item.LoaiGiuong;
                        txtGia.Text = item.GiaTien.ToString();
                        tongTien = int.Parse(formatTien(item.GiaTien.ToString()));
                    }
                    foreach (var item in phieuThueBLL.ListPhieuThue(int.Parse(txtTenNguoiDung.Text = GridViewDanhSachNguoiXuDung.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        DateTime nn = item.NgayNhanPhong;
                        DateTime nt = item.NgayTraPhong;
                        txtCCCD.Text = item.CCCD;
                        txtNgayNP.Text = nn.ToString();
                        txtNgayTP.Text = nt.ToString();
                        txtTongGio.Text = ((nt.Day - nn.Day) * 24).ToString();
                        tongTien += tongTien * ((nt.Day - nn.Day) - 1);
                        GiaTongP = tongTien;
                        MaNV = item.MaNV;

                    }
                    // kiểm tra nếu phòng có sử dụng dịch vụ thì tính tiền và show dịch vụ
                    ShowDichVu(txtSP.Text, txtCCCD.Text, txtNgayNP.Text);
                    txtSoTienTong.Text = tongTien + ".000 VND";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Looix");
                LamMoi();
            }
        }
        void ShowDichVu(string SP,string CCCD, string ngayNhan)
        {
            slDV = 0;
            GiaTongTienDV = 0;
            if (datDichVuBLL.GetListAccess(txtSP.Text, txtCCCD.Text, txtNgayNP.Text) != null)
            {
                GridViewDanhSachDichVu.Rows.Clear();
                GridViewDanhSachDichVu.ColumnCount = 2;
                GridViewDanhSachDichVu.Columns[0].Name = "Tên dịch vụ";
                GridViewDanhSachDichVu.Columns[1].Name = "Giá";


                foreach (var item in datDichVuBLL.GetListAccess(txtSP.Text, txtCCCD.Text, txtNgayNP.Text))
                {
                    slDV++;
                    foreach (var item1 in dichVuBLL.GetListAccess(item.maDV))
                    {
                        tongTien += int.Parse(formatTien(item1.GiaTien.ToString()));
                        GiaTongTienDV += int.Parse(formatTien(item1.GiaTien.ToString()));
                        string[] row = { item1.TenDichVu, item1.GiaTien.ToString() };
                        GridViewDanhSachDichVu.Rows.Add(row);
                    }
                }
            }
            else
            {
                AnDichVu();
            }
            

        }
        void LamMoi()
        {
            txtTenNguoiDung.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtSP .Text = string.Empty;
            txtLoaiPhong.Text = string.Empty;       
            txtLoaiGiuong.Text = string.Empty;
            txtGia.Text = string.Empty;
            txtNgayNP.Text = string.Empty;
            txtNgayTP.Text = string.Empty;
            txtTongGio.Text = string.Empty;

            btnIn.Visible = false;
            btnThanhToan.Visible = false;
            txtTenNVTT.Text = NhanVienBLL.GetNameAccess(TaiKhoanBLL.GetMaTKFileStream());
            AnDichVu();
        }
        void AnDichVu()
        {
            labelDVDaSuDung.Visible = false;
            GridViewDanhSachDichVu.Visible = false;
        }
        string formatTien(string tien)
        {
            string item = "";
            foreach (Char c in tien)
            {
                if (Char.IsDigit(c))
                {
                    item += c;
                }
                else return item;
            }
            return item;
        }

        
    }
}
