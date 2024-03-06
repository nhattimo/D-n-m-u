using BLL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_ThemPhong : UserControl
    {
        PhongBLL phongBLL = new PhongBLL();
        public UC_ThemPhong()
        {
            InitializeComponent();
        }
        private void UC_ThemPhong_Load(object sender, EventArgs e)
        {
            LamMoiLebel();
            ShowDanhSachPhong();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            bool ketQua = true;

            // kiểm tra nhập vào số phòng
            if (string.IsNullOrEmpty(txtSoPhong.Text))
            {
                ketQua = false;
                LabelSaiSoPhong.Text = "Không được để trống";
            }
            else
            {
                if (IsNumber(txtSoPhong.Text) != true)
                {
                    ketQua = false;
                    LabelSaiSoPhong.Text = "Hãy nhập bằng số";
                }
                else
                {
                    if (phongBLL.IsSoPhong(txtSoPhong.Text))
                    {
                        ketQua = false;
                        LabelSaiSoPhong.Text = "Số phòng đã tồn tại";
                    }
                    else
                        LabelSaiSoPhong.Text = string.Empty;
                }
            }

            // kiểm tra nhập vào loại phòng
            if (string.IsNullOrEmpty(txtLoaiPhong.Text))
            {
                ketQua = false;
                LabelSaiLoaiPhong.Text = "Không được để trống";
            }
            else
            {
                LabelSaiLoaiPhong.Text = string.Empty;
            }

            // kiểm tra nhập vào loại giường
            if (string.IsNullOrEmpty(txtLoaiGiuong.Text))
            {
                ketQua = false;
                LabelSaiLoaiGiuong.Text = "Không được để trống";
            }
            else
            {
                LabelSaiLoaiGiuong.Text = string.Empty;
            }

            // kiểm tra nhập vào giá tiền
            if (string.IsNullOrEmpty(txtGiaTien.Text))
            {
                ketQua = false;
                LabelSaiGiaTien.Text = "Không được để trống";
            }
            else
            {
                if (IsNumber(txtGiaTien.Text) != true)
                {
                    ketQua = false;
                    LabelSaiGiaTien.Text = "Hãy nhập bằng số";
                }
                else
                {
                    LabelSaiGiaTien.Text = string.Empty;
                }
            }

            // kiểm tra nhập vào trạng thái
            if (string.IsNullOrEmpty(txtTrangThai.Text))
            {
                ketQua = false;
                LabelSaiTrangThai.Text = "Không được để trống";
            }
            else
            {
                LabelSaiTrangThai.Text = string.Empty;
            }
            if (ketQua)
            {
                phongBLL.InsertPhongAccess(txtSoPhong.Text, txtLoaiPhong.Text, txtLoaiGiuong.Text, int.Parse(txtGiaTien.Text), txtTrangThai.Text, txtMoTa.Text);
                ShowDanhSachPhong();
                LabelThemPhongThanhCong.Visible = true;
            }else
                LabelThemPhongThanhCong.Visible = false;

            /*if (KTTextNhapVao(txtSoPhong.Text, txtLoaiPhong.Text, txtLoaiGiuong.Text, txtGiaTien.Text, txtTrangThai.Text))
            {
                phongBLL.InsertPhongAccess(int.Parse(txtSoPhong.Text), txtLoaiPhong.Text, txtLoaiGiuong.Text, int.Parse(txtGiaTien.Text), txtTrangThai.Text, txtMoTa.Text);
                ShowDanhSachPhong();
                LabelThemPhongThanhCong.Visible = true;
            }
            else
                LabelThemPhongThanhCong.Visible = false;*/

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoPhong.Text))
            {
                LabelSaiSoPhong.Text = "Hãy nhập số phòng cần xóa";
            }
            else
            {
                if (phongBLL.IsSoPhong(txtSoPhong.Text) != true)
                {
                    LabelSaiSoPhong.Text = "Số phòng không tồn tại";
                }
                else
                {
                    if (phongBLL.GetTrangThaiAccess(txtSoPhong.Text) == "Trống")
                    {
                        phongBLL.DeletePhongAccess(txtSoPhong.Text);
                        LamMoiLebel();
                        LamMoiText();
                        ShowDanhSachPhong();
                        MessageBox.Show("Xóa thành công!" + txtSoPhong.Text);
                    }
                    else
                    {
                        MessageBox.Show("Phòng này đang ở trạng thái '" + phongBLL.GetTrangThaiAccess(txtSoPhong.Text) + "' nên Không thể xóa");
                    }

                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            bool ketQua = true;
            if (string.IsNullOrEmpty(txtSoPhong.Text))
            {
                ketQua = false;
                LabelSaiSoPhong.Text = "Không được để trống";
            }
            else
            {
                if (IsNumber(txtSoPhong.Text) != true)
                {
                    ketQua = false;
                    LabelSaiSoPhong.Text = "Hãy nhập bằng số";
                }
                else
                {
                    if (phongBLL.IsSoPhong(txtSoPhong.Text) != true)
                    {
                        ketQua = false;
                        LabelSaiSoPhong.Text = "Số phòng không tồn tại";
                    }else LabelSaiSoPhong.Text = string.Empty;
                }
            }
            if (ketQua)
            {
                if (phongBLL.GetTrangThaiAccess(txtSoPhong.Text) == "Trống")
                {
                    phongBLL.UpdatePhong(txtSoPhong.Text, txtLoaiPhong.Text, txtLoaiGiuong.Text, int.Parse(txtGiaTien.Text), txtTrangThai.Text, txtMoTa.Text);
                    LamMoiText();
                    ShowDanhSachPhong();
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Phòng này đang ở trạng thái '" + phongBLL.GetTrangThaiAccess(txtSoPhong.Text) + "' nên Không thể cập nhật");
                }
                
            }
        }

        private void GridViewDanhSachPhong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewDanhSachPhong.CurrentRow.Selected = true;
                GridViewDanhSachPhong.ReadOnly = true;
                if (GridViewDanhSachPhong.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    LamMoiLebel();
                    LamMoiText();
                    btnSua.Visible = false;
                    btnXoa.Visible = false;
                }
                else {
                    txtSoPhong.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtLoaiPhong.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtLoaiGiuong.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtGiaTien.Text = formatTien(GridViewDanhSachPhong.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtTrangThai.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtMoTa.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[5].Value.ToString();
                    if (GridViewDanhSachPhong.CurrentRow.Selected == true)
                    {
                        btnSua.Visible = true;
                        btnXoa.Visible = true;
                    }
                }
               
            }
            catch (Exception)
            {
                LamMoiLebel();
                LamMoiText();
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
        }
        
        /*bool KTTextNhapVao(string soPhong, string loaiPhong, string loaiGiuong, string giaTien, string trangThai)
        {
            bool ketQua = true ;

            // kiểm tra nhập vào số phòng
            if (string.IsNullOrEmpty(soPhong))
            {
                ketQua = false;
                LabelSaiSoPhong.Text = "Không được để trống";
            }
            else
            {
                if (IsNumber(soPhong) != true)
                {
                    ketQua = false;
                    LabelSaiSoPhong.Text = "Hãy nhập bằng số";
                }
                else
                {
                    if (phongBLL.IsSoPhong(int.Parse(soPhong)))
                    {
                        ketQua = false;
                        LabelSaiSoPhong.Text = "Số phòng đã tồn tại";
                    }else
                        LabelSaiSoPhong.Text = string.Empty;
                }
            }

            // kiểm tra nhập vào loại phòng
            if (string.IsNullOrEmpty(loaiPhong))
            {
                ketQua = false;
                LabelSaiLoaiPhong.Text = "Không được để trống";
            }
            else
            {
                LabelSaiLoaiPhong.Text = string.Empty;
            }

            // kiểm tra nhập vào loại giường
            if (string.IsNullOrEmpty(loaiGiuong))
            {
                ketQua = false;
                LabelSaiLoaiGiuong.Text = "Không được để trống";
            }
            else
            {
                LabelSaiLoaiGiuong.Text = string.Empty;
            }

            // kiểm tra nhập vào giá tiền
            if (string.IsNullOrEmpty(giaTien))
            {
                ketQua = false;
                LabelSaiGiaTien.Text = "Không được để trống";
            }
            else
            {
                if (IsNumber(giaTien) != true)
                {
                    ketQua = false;
                    LabelSaiGiaTien.Text = "Hãy nhập bằng số";
                }
                else
                {
                    LabelSaiGiaTien.Text = string.Empty;
                }
            }

            // kiểm tra nhập vào trạng thái
            if (string.IsNullOrEmpty(trangThai))
            {
                ketQua = false;
                LabelSaiTrangThai.Text = "Không được để trống";
            }
            else
            {
                LabelSaiTrangThai.Text = string.Empty;
            }
            return ketQua;
        }*/
        public void LamMoiLebel()
        {
            LabelSaiSoPhong.Text = string.Empty;
            LabelSaiLoaiPhong.Text = string.Empty;
            LabelSaiLoaiGiuong.Text = string.Empty;
            LabelSaiGiaTien.Text = string.Empty;
            LabelSaiTrangThai.Text = string.Empty;
            LabelThemPhongThanhCong.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }
        public void LamMoiText()
        {
            txtSoPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtLoaiGiuong.Text = "";
            txtGiaTien.Text = "";
            txtTrangThai.Text = "";
            txtMoTa.Text = "";
            btnSua.Visible = false;
            btnXoa.Visible = false;
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

        void ShowDanhSachPhong()
        {
            GridViewDanhSachPhong.Rows.Clear();
            GridViewDanhSachPhong.ColumnCount = 6;
            GridViewDanhSachPhong.Columns[0].Name = "Số phòng";
            GridViewDanhSachPhong.Columns[1].Name = "Loại phòng";
            GridViewDanhSachPhong.Columns[2].Name = "Loại giường";
            GridViewDanhSachPhong.Columns[3].Name = "Giá";
            GridViewDanhSachPhong.Columns[4].Name = "Trạng thái";
            GridViewDanhSachPhong.Columns[5].Name = "Mô tả";
            foreach (var item in phongBLL.ListPhong())
            {
                string[] row = { item.SoPhong.ToString(), item.LoaiPhong, item.LoaiGiuong, (item.GiaTien).ToString(),item.TrangThai, item.MoTa};
                GridViewDanhSachPhong.Rows.Add(row);   
            }
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
