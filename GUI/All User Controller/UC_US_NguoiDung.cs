using BLL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_US_NguoiDung : UserControl
    {
        DatPhongBLL datPhongBLL = new DatPhongBLL();
        NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        PhongBLL phongBLL = new PhongBLL();
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        PhieuThueBLL PhieuThueBLL = new PhieuThueBLL();
        DatDichVuBLL datDichVuBLL = new DatDichVuBLL();
        DichVuBLL DichVuBLL = new DichVuBLL();
        string soPhong;
        int maDP;
        int maDDV;
        public UC_US_NguoiDung()
        {
            InitializeComponent();
        }

        private void UC_US_NguoiDung_Load(object sender, EventArgs e)
        {
            ShowDanhSachDatPhong();
            ShowDanhSachDichVu();
            btnHuyPhong.Visible = false;
            btnThanhToan.Visible = false;
            btnHuyDV.Visible = false;
            int maTK = TaiKhoanBLL.GetMaTKFileStream();
            foreach (var item in nguoiDungBLL.ListAccess(maTK))
            {
                txtName.Text = item.HoVaTen;
                txtSoCCCD.Text = item.CCCD;
                txtTuoi.Text = item.Tuoi + "";
                txtSDT.Text = item.SDT;
                txtGT.Text = item.GioiTinh;
                txtEmail.Text = item.Email;
                txtDC.Text = item.DiaChi;
                txtQT.Text = item.QuocTich;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            ShowDanhSachDatPhong();
            ShowDanhSachDichVu();
        }
        private void btnHuyPhong_Click(object sender, EventArgs e)
        {
            if (datPhongBLL.DeleteAccess(maDP))
            {
                phongBLL.UpdateTrangThaiPhongAccess(soPhong, "Trống");
                ShowDanhSachDatPhong();
                MessageBox.Show("Hủy phòng thành công");
            }
            else
                MessageBox.Show("Hủy phòng thất bại");
        }

        private void btnHuyDV_Click(object sender, EventArgs e)
        {
            datDichVuBLL.DeleteAccess(maDDV);
            ShowDanhSachDichVu();
            MessageBox.Show("Hủy thành công");
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhật");
        }

        private void GridViewDanhSachPhong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewDanhSachPhong.CurrentRow.Selected = true;
                GridViewDanhSachPhong.ReadOnly = true;
                if (GridViewDanhSachPhong.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    btnHuyPhong.Visible = false;
                    btnThanhToan.Visible = false;
                }
                else
                {
                    maDP = int.Parse(GridViewDanhSachPhong.Rows[e.RowIndex].Cells[0].Value.ToString());
                    soPhong = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (phongBLL.GetTrangThaiAccess(soPhong) == "Đã được đặt")
                    {
                        btnHuyPhong.Visible = true;
                        btnThanhToan.Visible = false;
                    }
                    else
                    {
                        btnThanhToan.Visible = true;
                        btnHuyPhong.Visible = false;

                    }
                }
            }
            catch (Exception)
            {
                btnHuyPhong.Visible = false;
                btnThanhToan.Visible = false;
            }
            
        }
        
        void ShowDanhSachDatPhong()
        {
            GridViewDanhSachPhong.Rows.Clear();
            GridViewDanhSachPhong.ColumnCount = 6;
            GridViewDanhSachPhong.Columns[0].Name = "Mã";
            GridViewDanhSachPhong.Columns[1].Name = "Số phòng";
            GridViewDanhSachPhong.Columns[2].Name = "Trạng thái";
            GridViewDanhSachPhong.Columns[3].Name = "Thời gian đặt";
            GridViewDanhSachPhong.Columns[4].Name = "Ngày nhận phòng";
            GridViewDanhSachPhong.Columns[5].Name = "Ngày trả phòng";
            foreach (var item in datPhongBLL.GetListDatPhongNDAccess(nguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream())))
            {
                string[] row = {item.MaDP.ToString(), item.SoPhong.ToString(), phongBLL.GetTrangThaiAccess(item.SoPhong), item.ThoiGianDat.ToString(), item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString() };
                GridViewDanhSachPhong.Rows.Add(row);
            }
            foreach (var item in PhieuThueBLL.ListPhieuThue(nguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream())))
            {
                foreach (var item1 in phongBLL.GetListPhongAccess(item.SoPhong.ToString()))
                {
                    string[] row = { item.MaPhieu.ToString(), item.SoPhong.ToString(), phongBLL.GetTrangThaiAccess(item.SoPhong), "", item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString() };
                    GridViewDanhSachPhong.Rows.Add(row);
                }
            }
        }

        private void GridViewDatDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewDatDichVu.CurrentRow.Selected = true;
                GridViewDatDichVu.ReadOnly = true;
                if (GridViewDatDichVu.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    btnHuyDV.Visible = false;
                }
                else
                {
                    maDDV = int.Parse(GridViewDatDichVu.Rows[e.RowIndex].Cells[0].Value.ToString());
                    btnHuyDV.Visible = true;
                }
            }
            catch (Exception)
            {
                btnHuyDV.Visible = false;
            }
            
        }

        void ShowDanhSachDichVu()
        {
            GridViewDatDichVu.Rows.Clear();
            GridViewDatDichVu.ColumnCount = 7;
            GridViewDatDichVu.Columns[0].Name = "Mã";
            GridViewDatDichVu.Columns[1].Name = "Số phòng";
            GridViewDatDichVu.Columns[2].Name = "Ngày nhận";
            GridViewDatDichVu.Columns[3].Name = "Tên dịch vụ";
            GridViewDatDichVu.Columns[4].Name = "Giá";
            GridViewDatDichVu.Columns[5].Name = "Mô tả";
            GridViewDatDichVu.Columns[5].Width = 200;
            foreach (var item in datDichVuBLL.GetListAccess(nguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream())))
            {
                foreach (var item1 in DichVuBLL.GetListAccess(item.maDV))
                {
                    string[] row = { item.MaDatDV.ToString(),item.SoPhong, item.NgayNhanDV.ToString(), item1.TenDichVu, item1.TrangThai, item1.GiaTien.ToString(), item1.MoTa };
                    GridViewDatDichVu.Rows.Add(row);
                } 
            }
            
        } 
    }
}
