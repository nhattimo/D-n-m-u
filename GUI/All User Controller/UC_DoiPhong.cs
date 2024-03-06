using BLL;
using DTO;
using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_DoiPhong : UserControl
    {
        PhongBLL phongBLL = new PhongBLL();
        NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
        DatPhongBLL datPhongBLL = new DatPhongBLL();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        PhieuThueBLL PhieuThueBLL = new PhieuThueBLL();
        int ma = 0;
        string maPhieu;
        string trangThaiPhong;
        public UC_DoiPhong()
        {
            InitializeComponent();
        }
        
        private void UC_DoiPhong_Load(object sender, EventArgs e)
        {
            ShowDanhSachPhongCuaUS();
            ShowDanhSachPhongTrong();
            LamMoiTxtVaLabel();
            TextReadOnly();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            ShowDanhSachPhongCuaUS();
            ShowDanhSachPhongTrong();
        }
        private void btnDoiPhong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoPhong.Text))
            {
                labelLoiPhongMuonChon.Visible = true;
            }else if (string.IsNullOrEmpty(txtSoPhongD.Text))
            {
                labelLoiPhongMuonDoi.Visible = true;
            }
            else
            {
                if(trangThaiPhong == "Đã được đặt")
                {
                    datPhongBLL.UpdateAccess(ma, txtSoPhongD.Text);
                    phongBLL.UpdateTrangThaiPhongAccess(txtSoPhongD.Text, trangThaiPhong);
                    phongBLL.UpdateTrangThaiPhongAccess(txtSoPhong.Text, "Trống");
                }
                else
                {
                    PhieuThueBLL.UpdateAccess(ma, txtSoPhongD.Text);
                    phongBLL.UpdateTrangThaiPhongAccess(txtSoPhongD.Text, trangThaiPhong);
                    phongBLL.UpdateTrangThaiPhongAccess(txtSoPhong.Text, "Trống");
                }
                LamMoiTxtVaLabel();
                ShowDanhSachPhongCuaUS();
                ShowDanhSachPhongTrong();
                MessageBox.Show("Đổi thành công");

            }
        }

       
        void ShowDanhSachPhongCuaUS()
        {
            GridViewDanhSachPhongCuaUS.Rows.Clear();
            GridViewDanhSachPhongCuaUS.ColumnCount = 8;
            GridViewDanhSachPhongCuaUS.Columns[0].Name = "Mã";
            GridViewDanhSachPhongCuaUS.Columns[1].Name = "Số phòng";
            GridViewDanhSachPhongCuaUS.Columns[2].Name = "Loại phòng";
            GridViewDanhSachPhongCuaUS.Columns[3].Name = "Loại giường";
            GridViewDanhSachPhongCuaUS.Columns[4].Name = "Giá tiền";
            GridViewDanhSachPhongCuaUS.Columns[5].Name = "Trạng thái";
            GridViewDanhSachPhongCuaUS.Columns[6].Name = "Ngày nhận phòng";
            GridViewDanhSachPhongCuaUS.Columns[7].Name = "Ngày trả phòng";
            foreach (var item in datPhongBLL.GetListDatPhongNDAccess(nguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream())))
            {
                foreach (var item1 in phongBLL.GetListPhongAccess(item.SoPhong.ToString()))
                {
                    string[] row = { item.MaDP.ToString(), item.SoPhong.ToString(),item1.LoaiPhong, item1.LoaiGiuong, item1.GiaTien.ToString(), item1.TrangThai, item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString() };
                    GridViewDanhSachPhongCuaUS.Rows.Add(row);
                }  
            }
            foreach (var item in PhieuThueBLL.ListPhieuThue(nguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream())))
            {
                foreach (var item1 in phongBLL.GetListPhongAccess(item.SoPhong.ToString()))
                {
                    string[] row = { item.MaPhieu.ToString(), item.SoPhong, item1.LoaiPhong, item1.LoaiGiuong, item1.GiaTien.ToString(), item1.TrangThai, item.NgayNhanPhong.ToString(), item.NgayTraPhong.ToString() };
                    GridViewDanhSachPhongCuaUS.Rows.Add(row);
                }  
            }
        }
        
        private void GridViewDanhSachPhongCuaUS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewDanhSachPhongCuaUS.CurrentRow.Selected = true;
                GridViewDanhSachPhongCuaUS.ReadOnly = true;
                if (GridViewDanhSachPhongCuaUS.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    LamMoiTextPhongDaDat();
                }
                else
                {

                    ma = int.Parse(GridViewDanhSachPhongCuaUS.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtSoPhong.Text = GridViewDanhSachPhongCuaUS.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtLoaiPhong.Text = GridViewDanhSachPhongCuaUS.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtLoaiGiuong.Text = GridViewDanhSachPhongCuaUS.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtGiaTien.Text = GridViewDanhSachPhongCuaUS.Rows[e.RowIndex].Cells[4].Value.ToString();
                    trangThaiPhong = GridViewDanhSachPhongCuaUS.Rows[e.RowIndex].Cells[5].Value.ToString();
                    labelLoiPhongMuonChon.Visible = false;
                }
            }
            catch (Exception)
            {

                LamMoiTextPhongDaDat();
            }
           
        }
        
        void ShowDanhSachPhongTrong()
        {
            GridViewDanhSachPhongTrong.Rows.Clear();
            GridViewDanhSachPhongTrong.ColumnCount = 6;
            GridViewDanhSachPhongTrong.Columns[0].Name = "Số phòng";
            GridViewDanhSachPhongTrong.Columns[1].Name = "Loại phòng";
            GridViewDanhSachPhongTrong.Columns[2].Name = "Loại giường";
            GridViewDanhSachPhongTrong.Columns[3].Name = "Giá";
            GridViewDanhSachPhongTrong.Columns[4].Name = "Trạng thái";
            GridViewDanhSachPhongTrong.Columns[5].Name = "Mô tả";
            GridViewDanhSachPhongTrong.Columns[5].Width = 220;
            foreach (var item in phongBLL.ListPhong())
            {
                if (item.TrangThai == "Trống")
                {
                    string[] row = { item.SoPhong.ToString(), item.LoaiPhong, item.LoaiGiuong, (item.GiaTien).ToString(), item.TrangThai, item.MoTa };
                    GridViewDanhSachPhongTrong.Rows.Add(row);
                }

            }
        }
        
        private void GridViewDanhSachPhongTrong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                GridViewDanhSachPhongTrong.CurrentRow.Selected = true;
                GridViewDanhSachPhongTrong.ReadOnly = true;
                if (GridViewDanhSachPhongTrong.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    LamMoiTextPhong();
                }
                else
                {

                    txtSoPhongD.Text = GridViewDanhSachPhongTrong.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtLoaiPhongD.Text = GridViewDanhSachPhongTrong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtLoaiGiuongD.Text = GridViewDanhSachPhongTrong.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtGiaTienD.Text = GridViewDanhSachPhongTrong.Rows[e.RowIndex].Cells[3].Value.ToString();
                    labelLoiPhongMuonDoi.Visible = false;
                }
            }
            catch (Exception)
            {

                LamMoiTextPhong();
            }
            
            
        }
        

        
        void TextReadOnly()
        {
            txtGiaTien.ReadOnly = true;
            txtLoaiGiuong.ReadOnly = true;
            txtLoaiPhong.ReadOnly = true;
        }
        void LamMoiTxtVaLabel()
        {
            txtSoPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtLoaiGiuong.Text = "";
            txtGiaTien.Text = "";

            txtSoPhongD.Text = "";
            txtLoaiPhongD.Text = "";
            txtLoaiGiuongD.Text = "";
            txtGiaTienD.Text = "";

            labelLoiPhongMuonChon.Visible = false;
            labelLoiPhongMuonDoi.Visible = false;
        }
        void LamMoiTextPhongDaDat()
        {
            txtSoPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtLoaiGiuong.Text = "";
            txtGiaTien.Text = "";
        }
        void LamMoiTextPhong()
        {
            txtSoPhongD.Text = "";
            txtLoaiPhongD.Text = "";
            txtLoaiGiuongD.Text = "";
            txtGiaTienD.Text = "";
        }

        
    }
}
