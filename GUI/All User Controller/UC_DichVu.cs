using BLL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_DichVu : UserControl
    {
        DichVuBLL DichVuBLL = new DichVuBLL();
        PhongBLL phongBLL = new PhongBLL();
        NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
        DatPhongBLL datPhongBLL = new DatPhongBLL();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        DatDichVuBLL datDichVuBLL = new DatDichVuBLL();
        PhieuThueBLL PhieuThueBLL = new PhieuThueBLL();
        string MaDV;
        public UC_DichVu()
        {
            InitializeComponent();
        }

        private void UC_DichVu_Load(object sender, EventArgs e)
        {
            ShowDanhDV();
            ShowDanhSachPhongCuaUS();
            LamMoiTxtDV();
            LamMoiTxtP();

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            ShowDanhDV();
            ShowDanhSachPhongCuaUS();
        }
        private void btnDatDV_Click(object sender, EventArgs e)
        {
            bool kt = true;
            if (string.IsNullOrEmpty(txtTenDV.Text))
            {
                kt = false;
                labelLoiChonDV.Visible = true;
            }
            else
            {
                labelLoiChonDV.Visible = false;
            }
            if (string.IsNullOrEmpty(txtSoPhong.Text))
            {
                kt = false;
                labelLoiPhong.Visible = true;
            }
            else
            {
                labelLoiPhong.Visible = false;
            }
            if (kt)
            {
                
                datDichVuBLL.InsertAccess(MaDV, nguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream()), txtSoPhong.Text, txtNgayNhanDV.Text);
                MessageBox.Show("Đặt thành công dịch vụ");
            }
        }
        void ShowDanhDV()
        {
            GridViewDanhSachDV.Rows.Clear();
            GridViewDanhSachDV.ColumnCount = 4;
            GridViewDanhSachDV.Columns[0].Name = "Mã dịch vụ";
            GridViewDanhSachDV.Columns[1].Name = "Tên";
            GridViewDanhSachDV.Columns[2].Name = "Giá";
            GridViewDanhSachDV.Columns[3].Name = "Mô tả";
            GridViewDanhSachDV.Columns[3].Width = 200;
            foreach (var item in DichVuBLL.GetListAccess())
            {
                string[] row = { item.MaDV, item.TenDichVu, item.GiaTien.ToString(), item.MoTa };
                GridViewDanhSachDV.Rows.Add(row);
            }
        }
        void ShowDanhSachPhongCuaUS()
        {
            GridViewDanhSachPhong.Rows.Clear();
            GridViewDanhSachPhong.ColumnCount = 8;
            GridViewDanhSachPhong.Columns[0].Name = "Mã đặt";
            GridViewDanhSachPhong.Columns[1].Name = "Số phòng";
            GridViewDanhSachPhong.Columns[2].Name = "Loại phòng";
            GridViewDanhSachPhong.Columns[3].Name = "Loại giường";
            GridViewDanhSachPhong.Columns[4].Name = "Giá tiền";
            GridViewDanhSachPhong.Columns[5].Name = "Trạng thái";
            GridViewDanhSachPhong.Columns[6].Name = "Ngày nhận phòng";
            GridViewDanhSachPhong.Columns[7].Name = "Ngày trả phòng";
            foreach (var item in datPhongBLL.GetListDatPhongNDAccess(nguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream())))
            {
                foreach (var item1 in phongBLL.GetListPhongAccess(item.SoPhong.ToString()))
                {
                    string[] row = {item.MaDP.ToString(), item.SoPhong.ToString(), item1.LoaiPhong, item1.LoaiGiuong, item1.GiaTien.ToString(), item1.TrangThai, item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString() };
                    GridViewDanhSachPhong.Rows.Add(row);
                }
            }
            foreach (var item in PhieuThueBLL.ListPhieuThue(nguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream())))
            {
                foreach (var item1 in phongBLL.GetListPhongAccess(item.SoPhong.ToString()))
                {
                    string[] row = { item.MaPhieu.ToString(), item.SoPhong.ToString(), item1.LoaiPhong, item1.LoaiGiuong, item1.GiaTien.ToString(), item1.TrangThai, item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString() };
                    GridViewDanhSachPhong.Rows.Add(row);
                }
            }
        }
        private void GridViewDanhSachDV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewDanhSachDV.ReadOnly = true;
                GridViewDanhSachDV.CurrentRow.Selected = true;
                if (GridViewDanhSachDV.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    LamMoiTxtDV();
                }
                else {
                    MaDV = GridViewDanhSachDV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenDV.Text = GridViewDanhSachDV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtGiaTienDV.Text = formatTien(GridViewDanhSachDV.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtMoTaDV.Text = GridViewDanhSachDV.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception)
            {
                LamMoiTxtDV();
            }
        }
        private void GridViewDanhSachPhong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewDanhSachPhong.CurrentRow.Selected = true;
                GridViewDanhSachPhong.ReadOnly = true;
                if (GridViewDanhSachPhong.Rows[e.RowIndex].Cells[1].Value == null)
                {
                    LamMoiTxtP();
                }
                else {
                    txtSoPhong.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtNgayNhanDV.Value = DateTime.Parse(GridViewDanhSachPhong.Rows[e.RowIndex].Cells[6].Value.ToString());
                    labelLoiChonDV.Visible = false;
                }
                
            }
            catch (Exception)
            {
                LamMoiTxtP();
            }
        }
        
        public void LamMoiTxtDV()
        {
            txtTenDV.Text = "";
            txtGiaTienDV.Text = "";
            txtMoTaDV.Text = "";
            labelLoiChonDV.Visible = false;
        }
        public void LamMoiTxtP()
        {
            txtSoPhong.Text = "";
            txtNgayNhanDV.Value = DateTime.Now;
            labelLoiPhong.Visible = false;
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
