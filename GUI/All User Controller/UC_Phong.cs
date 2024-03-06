using BLL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_Phong : UserControl
    {
        PhongBLL phongBLL = new PhongBLL();
        NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
        DichVuBLL DichVuBLL = new DichVuBLL();
        public UC_Phong()
        {
            InitializeComponent();
        }
        // Event
        private void UC_Phong_Load(object sender, EventArgs e)
        {
            ShowDanhSachPhong();
            ShowDanhSachDV();
            LamMoiAll();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            ShowDanhSachPhong();
            ShowDanhSachDV();
            LamMoiAll();
        }
        private void GridViewDanhSachPhong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            LamMoiAll();
            try
            {
                GridViewDanhSachPhong.CurrentRow.Selected = true;
                GridViewDanhSachPhong.ReadOnly = true;
                if (GridViewDanhSachPhong.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    LamMoiAll();
                }
                else {
                    txtSoP.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtLoaiP.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtLoaiG.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtGia.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtTrangThai.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtMoTa.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[5].Value.ToString();
                    ShowTTPhong();
                    //nếu có sử dụng phòng thì show người dùng ra
                    if (txtTrangThai.Text == "Đang sử dụng")
                    {
                        if (nguoiDungBLL.IsSoPhong(int.Parse(txtSoP.Text)))
                        {
                            GroupBoxKhachHang.Visible = true;
                            foreach (var item in nguoiDungBLL.ListNguoiDungTheoP(int.Parse(txtSoP.Text)))
                            {
                                txtTen.Text = item.HoVaTen;
                                txtSDT.Text = item.SDT;
                                txtCCCD.Text = item.CCCD;
                                txtDC.Text = item.DiaChi;
                                txtQT.Text = item.QuocTich;
                            }
                        }
                        else
                            MessageBox.Show("Lỗi không hiển thị người dùng");
                    }
                    else
                    {
                        LamMoiLableVaTxtND();
                    }
                }
                
            }
            catch (Exception)
            {
                LamMoiAll();
            }
        }

        private void GridViewDanhSachDV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            LamMoiAll();
            try
            {
                GridViewDanhSachDV.CurrentRow.Selected = true;
                GridViewDanhSachDV.ReadOnly = true;
                if (GridViewDanhSachDV.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    LamMoiAll();
                }
                else
                {
                    txtMaDV.Text = GridViewDanhSachDV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNameDV.Text = GridViewDanhSachDV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtGiaDV.Text = GridViewDanhSachDV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtMoTaDV.Text = GridViewDanhSachDV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    ShowTTDichVu();
                }  
            }
            catch (Exception)
            {
                LamMoiAll();
            }
        }
        

        //function
        void ShowDanhSachPhong()
        {
            GridViewDanhSachPhong.Rows.Clear();
            GridViewDanhSachPhong.ColumnCount = 6;
            GridViewDanhSachPhong.Columns[0].Name = "Số phòng";
            GridViewDanhSachPhong.Columns[1].Name = "Loại phòng";
            GridViewDanhSachPhong.Columns[2].Name = "Loại giường";
            GridViewDanhSachPhong.Columns[3].Name = "Giá";
            GridViewDanhSachPhong.Columns[4].Name = "Trạng thái";
            GridViewDanhSachPhong.Columns[4].Width = 150;
            GridViewDanhSachPhong.Columns[5].Name = "Mô tả";
            GridViewDanhSachPhong.Columns[5].Width = 400;
            foreach (var item in phongBLL.ListPhong())
            {
                string[] row = { item.SoPhong.ToString(), item.LoaiPhong, item.LoaiGiuong, (item.GiaTien).ToString(), item.TrangThai, item.MoTa };
                GridViewDanhSachPhong.Rows.Add(row);

            }
        }
        void ShowDanhSachDV()
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
        void ShowTTPhong()
        {
            GroupBoxThongTin.Visible = true;
            GroupBoxPhong.Visible = true;
        }
        void ShowTTDichVu()
        {
            GroupBoxThongTin.Visible = true;
            GroupBoxDV.Visible = true;


        }
        void LamMoiAll()
        {
            GroupBoxThongTin.Visible = false;
            LamMoiTxtP();
            LamMoiTxtDV();
            LamMoiLableVaTxtND();
        }
        void LamMoiTxtP()
        {
            txtSoP.Text = "";
            txtLoaiP.Text = "";
            txtLoaiG.Text = "";
            txtGia.Text = "";
            txtTrangThai.Text = "";
            txtMoTa.Text = "";

            GroupBoxPhong.Visible = false;

        }
        void LamMoiTxtDV()
        {
            txtMaDV.Text = "";
            txtNameDV.Text = "";
            txtGiaDV.Text = "";
            txtMoTaDV.Text = "";
            GroupBoxDV.Visible = false;

        }
        void LamMoiLableVaTxtND()
        {
            txtTen.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            txtDC.Text = "";
            txtQT.Text = "";

            GroupBoxKhachHang.Visible = false;
        }

        
    }
}
