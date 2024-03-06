using BLL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class UC_DangNhap : UserControl
    {
        TaiKhoanBLL taiKhoanBLL  = new TaiKhoanBLL();
        public UC_DangNhap()
        {
            InitializeComponent();
        }
        private void UC_DangNhap_Load(object sender, EventArgs e)
        {
            LamMoiLabelVaTxt();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            switch (taiKhoanBLL.DangNhap(txtTenTaiKhoan.Text, txtMatKhau.Text))
            {
                case "NGUOIDUNG":
                    taiKhoanBLL.SetMaTKFileStream(taiKhoanBLL.GetMaTK(txtTenTaiKhoan.Text));
                    LamMoiLabelVaTxt();
                    //MessageBox.Show(taiKhoanBLL.GetMaTKFileStream().ToString());
                    
                    FormNguoiDung nguoiDung = new FormNguoiDung();
                    nguoiDung.Show();
                    break;

                case "NHANVIEN":
                    taiKhoanBLL.SetMaTKFileStream(taiKhoanBLL.GetMaTK(txtTenTaiKhoan.Text));
                    LamMoiLabelVaTxt();
                    //MessageBox.Show(taiKhoanBLL.GetMaTKFileStream().ToString());
                    
                    FormNhanVien nhanVien = new FormNhanVien();
                    nhanVien.Show();
                    break;

                case "QUANLY":
                    taiKhoanBLL.SetMaTKFileStream(taiKhoanBLL.GetMaTK(txtTenTaiKhoan.Text));
                    LamMoiLabelVaTxt();
                    //MessageBox.Show(taiKhoanBLL.GetMaTKFileStream().ToString());
                    
                    FormQuanLy quanLy = new FormQuanLy();
                    quanLy.Show();
                    break;
                
                default:
                    txtMatKhau.Clear();
                    labelDNThatBai.Visible = true;
                    break;
            }
        }
        void LamMoiLabelVaTxt()
        {
            labelSaiTK.Visible = false;
            labelSaiMk.Visible = false;
            labelDNThatBai.Visible = false;
            txtMatKhau.Text = string.Empty;
            txtTenTaiKhoan.Text = string.Empty;
            this.Hide();
        }

        private void PanelDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
