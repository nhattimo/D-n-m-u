using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDangNhapDangKy : Form
    {
        public FormDangNhapDangKy()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void uC_DangNhap1_Load(object sender, EventArgs e)
        {
            
        }
        public void AnForm()
        {
            this.Hide();
            uC_DangKy11.Hide();
            uC_DangNhap1.Hide();
            btnBanDaCoTK.Hide();
            btnChuaCoTK.Hide();
        }
        private void FormDangNhapDangKy_Load(object sender, EventArgs e)
        {
            uC_DangKy11.Visible = false;
            uC_DangNhap1.Visible = true;
            btnChuaCoTK.Visible = true;
            btnBanDaCoTK.Visible = false;
        }

        private void btnChuaCoTK_Click(object sender, EventArgs e)
        {
            uC_DangKy11.Visible = true;
            uC_DangNhap1.Visible = false;
            btnBanDaCoTK.Visible = true;
            btnChuaCoTK.Visible = false;
        }

        private void btnBanDaCoTK_Click_1(object sender, EventArgs e)
        {
            uC_DangKy11.Visible = false;
            uC_DangNhap1.Visible = true;
            btnChuaCoTK.Visible = true;
            btnBanDaCoTK.Visible = false;
        }
    }
}
