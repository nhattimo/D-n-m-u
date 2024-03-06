using BLL;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_KhachHang : UserControl
    {
        PhieuThueBLL PhieuThueBLL = new PhieuThueBLL();
        NguoiDungBLL NguoiDungBLL = new NguoiDungBLL();
        public UC_KhachHang()
        {
            InitializeComponent();
        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            LamMoiAll();
            ShowDanhSachKhanhHang();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LamMoiAll();
            ShowDanhSachKhanhHang();
        }
        void ShowDanhSachKhanhHang()
        {
            GridViewDanhSachKhachHang.Rows.Clear();
            GridViewDanhSachKhachHang.ReadOnly = true;
            GridViewDanhSachKhachHang.ColumnCount = 5;
            GridViewDanhSachKhachHang.Columns[0].Name = "Họ và tên";
            GridViewDanhSachKhachHang.Columns[1].Name = "CCCD";
            GridViewDanhSachKhachHang.Columns[2].Name = "Số phòng";
            GridViewDanhSachKhachHang.Columns[3].Name = "Ngày nhận phòng";
            GridViewDanhSachKhachHang.Columns[4].Name = "Ngày trả phòng";
            foreach (var item in PhieuThueBLL.ListPhieuThue())
            {
                string[] row = {NguoiDungBLL.GetName(item.CCCD), item.CCCD, item.SoPhong.ToString(), item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString() };
                GridViewDanhSachKhachHang.Rows.Add(row);
            }
        }
        private void GridViewDanhSachKhachHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewDanhSachKhachHang.CurrentRow.Selected = true;
                GridViewDanhSachKhachHang.ReadOnly = true;
                txtSoP.Text = GridViewDanhSachKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtLoaiP.Text = GridViewDanhSachKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLoaiG.Text = GridViewDanhSachKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGia.Text = GridViewDanhSachKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTrangThai.Text = GridViewDanhSachKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMoTa.Text = GridViewDanhSachKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
                ShowTTPhongVaKhachHang();
            }
            catch (Exception)
            {
                LamMoiAll();
            }
        }
        
        void ShowTTPhongVaKhachHang()
        {
            GroupBoxThongTin.Visible = true;
            GroupBoxPhong.Visible = true;
            GroupBoxKH.Visible = true;
        }
        void LamMoiAll()
        {
            GroupBoxThongTin.Visible = false;
            LamMoiTxtP();
            LamMoiTxtND();
        }
        void LamMoiTxtP()
        {
            txtSoP.Text = "";
            txtLoaiP.Text = "";
            txtLoaiG.Text = "";
            txtGia.Text = "";
            txtTrangThai.Text = "";
            txtMoTa.Text = "";
        }
        void LamMoiTxtND()
        {
            txtTen.Text = "";
            txtTuoi.Text = "";
            txtGT.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            txtDC.Text = "";
            txtQT.Text = "";
        }

        
    }
}
