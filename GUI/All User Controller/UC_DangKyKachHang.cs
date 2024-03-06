using BLL;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_DangKyKachHang : UserControl
    {
        public UC_DangKyKachHang()
        {
            InitializeComponent();
        }
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        NguoiDungBLL NguoiDungBLL = new NguoiDungBLL();
        private void UC_DangKyKachHang_Load(object sender, EventArgs e)
        {
            LamMoiLabel();
            ShowDanhSachNguoiDung();
        }
        
        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            bool trangThai = true;
            #region Kiểm tra dữ liệu nhập vào
            // kiểm tra nhập vào tên tài khoản
            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text))
            {
                LabelSaiTK.Text = "Không được để trống";
                trangThai = false;
            }
            else if (txtTenTaiKhoan.Text.Length < 8)
            {
                LabelSaiTK.Text = "Tối thiểu 8 ký tự";
                trangThai = false;
            }
            else
            {
                if (TaiKhoanBLL.IsTenTK(txtTenTaiKhoan.Text))
                {
                    LabelSaiTK.Text = "Tên tài khoản đã được sử dụng";
                    trangThai = false;
                }
                else
                    LabelSaiTK.Text = string.Empty;
            }


            // kiểm tra nhập vào mật khẩu
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                LabelSaiMK.Text = "Không được để trống";
                trangThai = false;
            }
            else if (txtMatKhau.Text.Length < 8)
            {
                LabelSaiMK.Text = "Tối thiểu 8 ký tự";
                trangThai = false;
            }
            else
                LabelSaiMK.Text = string.Empty;

            // kiểm tra nhập vào Họ và tên
            if (string.IsNullOrEmpty(txtHoVaTen.Text))
            {
                LabelSaiHoTen.Text = "Không được để trống";
                trangThai = false;
            }
            else if (IsNumber(txtHoVaTen.Text))
            {
                LabelSaiHoTen.Text = "Tên không chứa ký tự số";
                trangThai = false;
            }
            else if (txtHoVaTen.Text.Length < 6)
            {
                LabelSaiHoTen.Text = "Tối thiểu 6 ký tự";
                trangThai = false;
            }
            else
                LabelSaiHoTen.Text = string.Empty;

            // kiểm tra nhập vào tuổi 
            if (string.IsNullOrEmpty(txtTuoi.Text))
            {
                LabelSaiTuoi.Text = "Không được để trống";
                trangThai = false;
            }
            else if (IsNumber(txtTuoi.Text) != true)
            {
                LabelSaiTuoi.Text = "không được nhập bằng chữ";
                trangThai = false;
            }
            else
            {
                if (int.Parse(txtTuoi.Text) < 18)
                {
                    LabelSaiTuoi.Text = "Số tuổi chưa được cho phép sử dụng";
                    trangThai = false;
                }
                else if (int.Parse(txtTuoi.Text) > 125)
                {
                    LabelSaiTuoi.Text = "Số tuổi vượt quá cho phép";
                    trangThai = false;
                }
                else
                    LabelSaiTuoi.Text = string.Empty;

            }

            // kiểm tra nhập vào giới tính 
            if (radioButtonNam.Checked == false && radioButtonNu.Checked == false)
            {
                LabelSaiGioiTinh.Text = "Hãy chọn giới tính";
                trangThai = false;
            }
            else
                LabelSaiGioiTinh.Text = string.Empty;

            // kiểm tra quốc tịch
            if (string.IsNullOrEmpty(txtQuocTich.Text))
            {
                LabelSaiQuocTich.Text = "Không được để trống";
                trangThai = false;
            }
            else
                LabelSaiQuocTich.Text = string.Empty;
            // kiểm tra số điện thoại
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                LabelSaiSDT.Text = "Không được để trống";
                trangThai = false;
            }
            else if (IsNumber(txtSDT.Text) != true)
            {
                LabelSaiSDT.Text = "Số điện thoại không chứa ký tự";
                trangThai = false;
            }
            else
            {
                if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 13)
                {
                    LabelSaiSDT.Text = "Số điện thoại chưa hợp lệ";
                    trangThai = false;
                }
                else
                    LabelSaiSDT.Text = string.Empty;

            }

            // kiểm tra nhập vào email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                LabelSaiEmail.Text = "Không được để trống";
                trangThai = false;
            }
            else if (IsEmail(txtEmail.Text) != true)
            {
                LabelSaiEmail.Text = "Email chưa hợp lệ";
                trangThai = false;
            }
            else
                LabelSaiEmail.Text = string.Empty;

            // kiểm tra nhâp vào dịa chỉ
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                LabelSaiDiaChi.Text = "Không được để trống";
                trangThai = false;
            }
            else
                LabelSaiDiaChi.Text = string.Empty;

            // kiểm tra CCCD
            if (string.IsNullOrEmpty(txtCCCD.Text))
            {
                LabelSaiCCCD.Text = "Không được để trống";
                trangThai = false;
            }
            else if (IsNumber(txtCCCD.Text) != true)
            {
                LabelSaiCCCD.Text = "CCCD Không hợp lệ vì chứa ký tự";
                trangThai = false;
            }
            else
            {
                if (txtCCCD.Text.Length < 12 || txtCCCD.Text.Length > 12)
                {
                    LabelSaiCCCD.Text = "CCCD không hợp lệ";
                    trangThai = false;
                }
                else
                {
                    if (NguoiDungBLL.IsCCCD(txtCCCD.Text))
                    {
                        LabelSaiCCCD.Text = "CCCD đã được sử dụng ở 1 tài khoản khác";
                        trangThai = false;
                    }
                    else LabelSaiCCCD.Text = string.Empty;
                }
            }
            #endregion
            // hoàn tất đăng ký
            if (trangThai == true)
            {
                string GioiTinh = "Nữ";
                if (radioButtonNam.Checked)
                    GioiTinh = "Nam";
                if (TaiKhoanBLL.InsertTaiKhoanAccess(txtTenTaiKhoan.Text, txtMatKhau.Text, "NGUOIDUNG"))
                {
                    if (NguoiDungBLL.InsertNguoiDungAccess(txtTenTaiKhoan.Text, txtHoVaTen.Text, byte.Parse(txtTuoi.Text), GioiTinh, txtQuocTich.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text, txtCCCD.Text))
                    {

                        LabeltxtDangKyThanhCong.Visible = true;
                        ShowDanhSachNguoiDung();
                    }
                }
                else
                    LabeltxtDangKyThatBai.Visible = true;
            }
            else
            {
                LabeltxtDangKyThanhCong.Visible = false;
            }
        }

        void ShowDanhSachNguoiDung()
        {
            GridViewDanhSachNguoiDung.Rows.Clear();
            GridViewDanhSachNguoiDung.ColumnCount = 8;
            GridViewDanhSachNguoiDung.Columns[0].Name = "Họ và tên";
            GridViewDanhSachNguoiDung.Columns[1].Name = "Tuổi";
            GridViewDanhSachNguoiDung.Columns[2].Name = "Giới tính";
            GridViewDanhSachNguoiDung.Columns[3].Name = "Số điện thoại";
            GridViewDanhSachNguoiDung.Columns[4].Name = "CCCD";
            GridViewDanhSachNguoiDung.Columns[5].Name = "Email";
            GridViewDanhSachNguoiDung.Columns[6].Name = "Địa chỉ";
            GridViewDanhSachNguoiDung.Columns[7].Name = "Quốc tịch";
            foreach (var item in NguoiDungBLL.ListNguoiDung())
            {
                string[] row = { item.HoVaTen, item.Tuoi + "", item.GioiTinh, item.SDT,item.CCCD, item.Email, item.DiaChi, item.QuocTich };
                GridViewDanhSachNguoiDung.Rows.Add(row);
            }
        }
        private void GridViewDanhSachNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewDanhSachNguoiDung.CurrentRow.Selected = true;
                txtHoVaTen.Text = GridViewDanhSachNguoiDung.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTuoi.Text = GridViewDanhSachNguoiDung.Rows[e.RowIndex].Cells[1].Value.ToString();
                //txtSDT.Text = GridViewDanhSachNguoiDung.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = GridViewDanhSachNguoiDung.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCCCD.Text = GridViewDanhSachNguoiDung.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEmail.Text = GridViewDanhSachNguoiDung.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = GridViewDanhSachNguoiDung.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtQuocTich.Text = GridViewDanhSachNguoiDung.Rows[e.RowIndex].Cells[7].Value.ToString();
                /*if (GridViewDanhSachNguoiDung.CurrentRow.Selected == true)
                {
                    btnSua.Visible = true;
                    btnXoa.Visible = true;
                }*/
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IsEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
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
        void LamMoiLabel()
        {
            LabelSaiTK.Text = string.Empty;
            LabelSaiMK.Text = string.Empty;
            LabelSaiHoTen.Text = string.Empty;
            LabelSaiTuoi.Text = string.Empty;
            LabelSaiGioiTinh.Text = string.Empty;
            LabelSaiSDT.Text = string.Empty;
            LabelSaiQuocTich.Text = string.Empty;
            LabelSaiEmail.Text = string.Empty;
            LabelSaiDiaChi.Text = string.Empty;
            LabelSaiCCCD.Text = string.Empty;
            LabeltxtDangKyThanhCong.Visible = false;
            LabeltxtDangKyThatBai.Visible = false;
        }

    }
}
