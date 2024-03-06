using BLL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_ThemNhanVien : UserControl
    {
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        NhanVienBLL NhanVienBLL = new NhanVienBLL();

        public UC_ThemNhanVien()
        {
            InitializeComponent();
        }

        private void UC_ThemNhanVien_Load(object sender, EventArgs e)
        {
            LamMoiTxtVaLebel();
            ShowDanhSachNV();
        }
      
        private void btnThem_Click(object sender, EventArgs e)
        {
            LamMoiLebel();
            bool kt = true;
            string gioiTinh = "Nam";
            // kiểm tra tên TK
            if (string.IsNullOrEmpty(txtTK.Text))
            {
                kt = false;
                labelLoiTenTK.Text = "Không được để trống";
            }
            else
            {
                if (TaiKhoanBLL.IsTenTK(txtTK.Text))
                {
                    kt = false;
                    labelLoiTenTK.Text = "Đã được sử dụng";
                }else if (txtTK.Text.Length < 8)
                {
                    kt = false;
                    labelLoiTenTK.Text = "Tối thiểu 8 ký tự";
                }
                else
                    labelLoiTenTK.Text = "";
            }
            // kiểm tra mật khẩu
            if (string.IsNullOrEmpty(txtMK.Text))
            {
                kt = false;
                labelLoiMK.Text = "Không được để trống";
            }
            else
            {
                if (txtMK.Text.Length < 8)
                {
                    kt = false;
                    labelLoiMK.Text = "Tối thiểu 8 ký tự";
                }
                else
                    labelLoiMK.Text = "";
            }
            // kiểm tra mã NV
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                kt = false;
                labelLoiMaNV.Text = "Không được để trống";
            }
            else {
                if (NhanVienBLL.IsMaAccess(txtMaNV.Text))
                {
                    kt = false;
                    labelLoiMaNV.Text = "Đã tồn tại";
                }
                else
                    labelLoiMaNV.Text = "";
               
            }

            // kiểm tra CCCD
            if (string.IsNullOrEmpty(txtCCCD.Text))
            {
                labelLoiCCCD.Text = "Không được để trống";
                kt = false;
            }
            else if (IsNumber(txtCCCD.Text) != true)
            {
                labelLoiCCCD.Text = "Không chứa ký tự";
                kt = false;
            }
            else
            {
                if (txtCCCD.Text.Length < 12 || txtCCCD.Text.Length > 12)
                {
                    labelLoiCCCD.Text = "CCCD không hợp lệ";
                    kt = false;
                }
                else
                {
                    if (NhanVienBLL.IsCCCDAccess(txtCCCD.Text))
                    {
                        labelLoiCCCD.Text = "CCCD đã tồn tại";
                        kt = false;
                    }
                    else labelLoiCCCD.Text = string.Empty;
                }
            }
            // kiểm tra Name
            if (string.IsNullOrEmpty(txtName.Text))
            {
                labelLoiName.Text = "Không được để trống";
                kt = false;
            }
            else {
                if (IsNumber(txtName.Text))
                {
                    labelLoiName.Text = "Tên không chứa ký tự số";
                    kt = false;
                }
                else if (txtName.Text.Length < 6)
                {
                    labelLoiName.Text = "Tối thiểu 6 ký tự";
                    kt = false;
                }
                else
                    labelLoiName.Text = "";
            }

            // kiểm tra giới tính
            if(radioButtonNam.Checked != true && radioButtonNu.Checked != true)
            {
                kt = false;
                labelLoiGioiTinh.Text = "Không được để trống";
            }
            else
            {
                labelLoiGioiTinh.Text = "";
                if (radioButtonNam.Checked != true)
                    gioiTinh = "Nữ";

            }
            // kiểm tra SDT
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                labelLoiSDT.Text = "Không được để trống";
                kt = false;
            }
            else
            {
                if (IsNumber(txtSDT.Text) != true)
                {
                    labelLoiSDT.Text = "Không được chứa ký tự";
                    kt = false;
                }
                else if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 13)
                {
                    labelLoiSDT.Text = "Chưa hợp lệ";
                    kt = false;
                }
                else
                    labelLoiSDT.Text = "";
            }
            // kiểm tra DC
            if (string.IsNullOrEmpty(txtDC.Text))
            {
                kt = false;
                labelLoiDC.Text = "Không được để trống";
            }
            else
                labelLoiDC.Text = "";
            // kiểm tra luong
            if (string.IsNullOrEmpty(txtLuong.Text))
            {
                kt = false;
                labelLoiLuong.Text = "Không được để trống";
            }
            else
            {
                if (!IsNumber(txtLuong.Text))
                {
                    kt = false;
                    labelLoiLuong.Text = "Không chứ ký tự";
                }
                else
                    labelLoiLuong.Text = "";
            }

            // kiểm tra ngay Làm việc
            if (string.IsNullOrEmpty(txtNgayVaoLam.Text))
            {
                kt = false;
                labelLoiNgayVaoLam.Text = "Không được để trống";
            }
            else
            {
                DateTime homNay = DateTime.Now;
                DateTime ngayLam = DateTime.Parse(txtNgayVaoLam.Text);
                if (ngayLam.Day > homNay.Day || ngayLam.Month > homNay.Month || ngayLam.Year > homNay.Year)
                {
                    kt = false;
                    labelLoiNgayVaoLam.Text = "Không hợp lệ";
                }
                else
                    labelLoiNgayVaoLam.Text = "";
            }


            // hoàn thành đăng ký
            if (kt)
            {
                if (TaiKhoanBLL.InsertTaiKhoanAccess(txtTK.Text, txtMK.Text, "NHANVIEN"))
                {
                    if (NhanVienBLL.InsertAccess(txtTK.Text, txtMaNV.Text,txtCCCD.Text, txtName.Text, txtSDT.Text, gioiTinh, txtDC.Text, int.Parse(txtLuong.Text), DateTime.Parse(txtNgayVaoLam.Text)))
                    {
                        ShowDanhSachNV();
                        LabelThemNVThanhCong.Visible = true;
                    }
                    else
                        MessageBox.Show("Lỗi thêm nhân viên");
                }
                else
                    MessageBox.Show("Lỗi thêm tài khoản");
            }
            else
                LabelThemNVThanhCong.Visible = false;
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            LamMoiLebel();
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                labelLoiMaNV.Text = "Không để trống mã khi xóa!";
            }else if (!NhanVienBLL.IsMaAccess(txtMaNV.Text))
            {
                labelLoiMaNV.Text = "Mã không tồn tại để thực hiện xóa!";
            }
            else
            {
                int maTK = NhanVienBLL.GetMaTKAccess(txtMaNV.Text);
                if (TaiKhoanBLL.IsMaAccess(maTK))
                {
                    NhanVienBLL.DeleteAccess(txtMaNV.Text);
                    ShowDanhSachNV();
                    LamMoiTxtVaLebel();
                    TaiKhoanBLL.DeleteAccess(maTK);
                    MessageBox.Show("Xóa thành công");
                }
            }    
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            LamMoiLebel();
            string gioiTinh = "Nam";
            if (radioButtonNam.Checked != true)
                    gioiTinh = "Nữ";
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                labelLoiMaNV.Text = "Không để trống mã khi cập nhật!";
            }
            else if (!NhanVienBLL.IsMaAccess(txtMaNV.Text))
            {
                labelLoiMaNV.Text = "Mã không tồn tại để thực hiện cập nhật!";
            }
            else
            {
                NhanVienBLL.UpdateAccess( txtMaNV.Text, txtName.Text,txtCCCD.Text ,txtSDT.Text, gioiTinh, txtDC.Text, int.Parse(txtLuong.Text), DateTime.Parse(txtNgayVaoLam.Text));
                ShowDanhSachNV();
                LamMoiTxtVaLebel();
                MessageBox.Show("Cập nhật thành công");
            }
        }
        private void GridViewDanhSachNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LamMoiTxtVaLebel();
                btnSua.Visible = true;
                btnXoa.Visible = true;
                GridViewDanhSachNhanVien.ReadOnly = true;
                GridViewDanhSachNhanVien.CurrentRow.Selected = true;
                if (GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    LamMoiTxtVaLebel();
                }
                else {
                    txtMaNV.Text = GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtCCCD.Text = GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtName.Text = GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                    if (GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
                        radioButtonNam.Checked = true;
                    else radioButtonNu.Checked = true;
                    txtSDT.Text = GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtDC.Text = GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtLuong.Text = formatTien(GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString());
                    txtNgayVaoLam.Value = DateTime.Parse(GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString());
                    txtTK.Text = GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtMK.Text = GridViewDanhSachNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();
                }
                
            }
            catch (Exception)
            {
                LamMoiTxtVaLebel();
            }
        }

        void ShowDanhSachNV()
        {
            GridViewDanhSachNhanVien.Rows.Clear();
            GridViewDanhSachNhanVien.ColumnCount = 10;
            GridViewDanhSachNhanVien.Columns[0].Name = "Mã nhân viên";
            GridViewDanhSachNhanVien.Columns[0].Width = 50;
            GridViewDanhSachNhanVien.Columns[1].Name = "CCCD";
            GridViewDanhSachNhanVien.Columns[2].Name = "Họ và tên";
            GridViewDanhSachNhanVien.Columns[3].Name = "Giới tính";
            GridViewDanhSachNhanVien.Columns[4].Name = "Số điện thoại";
            GridViewDanhSachNhanVien.Columns[5].Name = "Địa chỉ";
            GridViewDanhSachNhanVien.Columns[6].Name = "Lương";
            GridViewDanhSachNhanVien.Columns[7].Name = "Ngày vào làm";
            GridViewDanhSachNhanVien.Columns[8].Name = "Tên tài khoản";
            GridViewDanhSachNhanVien.Columns[9].Name = "Mật khẩu";
            foreach (var item in NhanVienBLL.TableList())
            {
                string[] row = { item.MaNV, item.CCCD, item.TenNV, item.GioiTinh, item.SDT, item.DiaChi, item.Luong.ToString(), item.NgayVaoLam.ToString(), TaiKhoanBLL.GetTKAccess(item.MaTK), TaiKhoanBLL.GetMKAccess(item.MaTK) };

                GridViewDanhSachNhanVien.Rows.Add(row);
            }
        }
        void LamMoiTxtVaLebel()
        {
            // Text 
            txtTK.Text = string.Empty;
            txtMK.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtName.Text = string.Empty;
            radioButtonNam.Checked = true;
            txtSDT.Text = string.Empty;
            txtDC.Text = string.Empty;
            txtLuong.Text = string.Empty;
            txtNgayVaoLam.Text = DateTime.Now.ToString();

            // Label báo lỗi
            labelLoiTenTK.Text = "";
            labelLoiMK.Text = "";
            labelLoiMaNV.Text = "";
            labelLoiCCCD.Text = "";
            labelLoiName.Text = "";
            labelLoiGioiTinh.Text = "";
            labelLoiSDT.Text = "";
            labelLoiDC.Text = "";
            labelLoiLuong.Text = "";
            labelLoiNgayVaoLam.Text = "";

            LabelThemNVThanhCong.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }
        void LamMoiLebel()
        {
            // Label báo lỗi
            labelLoiTenTK.Text = "";
            labelLoiMK.Text = "";
            labelLoiMaNV.Text = "";
            labelLoiCCCD.Text = "";
            labelLoiName.Text = "";
            labelLoiGioiTinh.Text = "";
            labelLoiSDT.Text = "";
            labelLoiDC.Text = "";
            labelLoiLuong.Text = "";
            labelLoiNgayVaoLam.Text = "";

            LabelThemNVThanhCong.Visible = false;
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
