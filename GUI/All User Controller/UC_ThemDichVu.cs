using BLL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_ThemDichVu : UserControl
    {
        DichVuBLL DichVuBLL = new DichVuBLL();
        public UC_ThemDichVu()
        {
            InitializeComponent();
        }

        private void UC_ThemDichVu_Load(object sender, EventArgs e)
        {
            LamMoi();
            ShowDanhDV();
            LabelThemThanhCong.Visible = false;
        }
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            bool kt = true;
            // kiểm tra mã 
            if (string.IsNullOrEmpty(txtMaDV.Text))
            {
                kt = false;
                LabelSaiMaDV.Text = "Không được để trống";
            }
            else
            {
                if (DichVuBLL.IsMaAccess(txtMaDV.Text))
                {
                    kt = false;
                    LabelSaiMaDV.Text = "Mã đã tồn tại";
                }
                else LabelSaiMaDV.Text = "";
            }
            // kiểm tra tên
            if (string.IsNullOrEmpty(txtTenDV.Text))
            {
                kt = false;
                LabelSaiTen.Text = "Không được để trống";
            }
            else 
            {
                if (IsNumber(txtTenDV.Text))
                {
                    LabelSaiTen.Text = "không chứa chữ số";
                    kt = false;
                }
                else
                {
                    LabelSaiTen.Text = string.Empty;
                }
            }

            // kiểm tra gia tien
            /*if (string.IsNullOrEmpty(txtGiaTien.Text))
            {
                kt = false;
                LabelSaiTen.Text = "Không được để trống";
            }
            else
            {
                if (IsNumber(txtGiaTien.Text) != true)
                {
                    kt = false;
                    LabelSaiTen.Text = "Hãy nhập bằng số";
                }
                else
                {
                    LabelSaiTen.Text = string.Empty;
                }
            }*/
            // Kiểm tra trạng thái
            if (string.IsNullOrEmpty(txtTrangThai.Text))
            {
                kt = false;
                LabelSaiTrangThai.Text = "Không được để trống";
            }
            else LabelSaiTrangThai.Text = "";
            if (kt)
            {
                if (DichVuBLL.InsertAccess(txtMaDV.Text, txtTenDV.Text, int.Parse(txtGiaTien.Text), txtTrangThai.Text,txtMoTa.Text))
                {
                    LabelThemThanhCong.Visible = true;
                    ShowDanhDV();
                    LamMoi();
                    //MessageBox.Show("Thêm thành công dịch vụ");
                }
                else
                {
                    LabelThemThanhCong.Visible = false;
                    ShowDanhDV();
                    MessageBox.Show("Lỗi dữ liệu");

                }
            }
            else
            {
                MessageBox.Show("Lỗi không thêm được dịch vụ");
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            bool kt = true;
            // kiểm tra mã 
            if (string.IsNullOrEmpty(txtMaDV.Text))
            {
                kt = false;
                LabelSaiMaDV.Text = "Không được để trống";
            }
            else
            {
                if (DichVuBLL.IsMaAccess(txtMaDV.Text) != true)
                {
                    kt = false;
                    LabelSaiMaDV.Text = "Mã không tồn tại";
                }
                else LabelSaiMaDV.Text = "";
            }
            // kiểm tra tên
            if (string.IsNullOrEmpty(txtTenDV.Text) != true)
            {
                if (IsNumber(txtTenDV.Text))
                {
                    LabelSaiTen.Text = "không chứa chữ số";
                    kt = false;
                }
                else
                {
                    LabelSaiTen.Text = string.Empty;
                }
            }
            // kiểm tra gia tien
            if (string.IsNullOrEmpty(txtGiaTien.Text) != true)
            {
                if (IsNumber(txtGiaTien.Text) != true)
                {
                    kt = false;
                    LabelSaiTen.Text = "Hãy nhập bằng số";
                }
                else
                {
                    LabelSaiTen.Text = string.Empty;
                }
            }
            if (kt)
            {
                if (DichVuBLL.UpdateAccess(txtMaDV.Text, txtTenDV.Text, int.Parse(txtGiaTien.Text), txtTrangThai.Text,txtMoTa.Text))
                {
                    ShowDanhDV();
                    LamMoi();
                    MessageBox.Show("Sửa thành công");
                    
                }
                else MessageBox.Show("Sửa thất bại");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kt = true;
            if (string.IsNullOrEmpty(txtMaDV.Text))
            {
                kt = false;
                LabelSaiMaDV.Text = "Không được để trống";
            }
            else
            {
                if (DichVuBLL.IsMaAccess(txtMaDV.Text) != true)
                {
                    kt = false;
                    LabelSaiMaDV.Text = "Mã không tồn tại";
                }
                else LabelSaiMaDV.Text = "";
            }

            if (kt)
            {
                if (DichVuBLL.DeleteAccess(txtMaDV.Text))
                {
                    ShowDanhDV();
                    LamMoi();
                    MessageBox.Show("Xóa thành công");
                }
                    
                else MessageBox.Show("Xóa thất bại");
            }
        }
        private void GridViewDanhSachDichVu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewDanhSachDichVu.ReadOnly = true;
                GridViewDanhSachDichVu.CurrentRow.Selected = true;
                if (GridViewDanhSachDichVu.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    LamMoi();
                }
                else {
                    txtMaDV.Text = GridViewDanhSachDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenDV.Text = GridViewDanhSachDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtGiaTien.Text = formatTien(GridViewDanhSachDichVu.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtTrangThai.Text = GridViewDanhSachDichVu.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtMoTa.Text = GridViewDanhSachDichVu.Rows[e.RowIndex].Cells[4].Value.ToString();
                    btnSua.Visible = true;
                    btnXoa.Visible = true;
                }
               
            }
            catch (Exception)
            {
                LamMoi();
            }
        }

        void ShowDanhDV()
        {
            GridViewDanhSachDichVu.Rows.Clear();
            GridViewDanhSachDichVu.ColumnCount = 5;
            GridViewDanhSachDichVu.Columns[0].Name = "Mã dịch vụ";
            GridViewDanhSachDichVu.Columns[1].Name = "Tên";
            GridViewDanhSachDichVu.Columns[2].Name = "Giá";
            GridViewDanhSachDichVu.Columns[3].Name = "Trạng thái";
            GridViewDanhSachDichVu.Columns[4].Name = "Mô tả";
            foreach (var item in DichVuBLL.GetListAccess())
            {
                string[] row = { item.MaDV, item.TenDichVu, item.GiaTien.ToString(),item.TrangThai, item.MoTa };
                GridViewDanhSachDichVu.Rows.Add(row);
            }
        }
        public bool IsNumber(string SDT)
        {
            foreach (Char c in SDT)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        void LamMoi()
        {
            btnSua.Visible = false;
            btnXoa.Visible = false;

            txtMaDV.ReadOnly = false;

            LabelSaiMaDV.Text = string.Empty;
            LabelSaiTen.Text = string.Empty;
            LabelSaiGia.Text = string.Empty;
            LabelSaiTrangThai.Text = string.Empty;

            txtMaDV.Text = string.Empty;
            txtTenDV.Text = string.Empty;
            txtGiaTien.ResetText();
            txtMoTa.Text = string.Empty;
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
