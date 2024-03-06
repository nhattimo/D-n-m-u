using GUI.All_User_Controller;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQuanLy : Form
    {
        public int MaTK;
        public FormQuanLy()
        {
            InitializeComponent();
        }
       
        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            LamMoiUC();
            btnThemPhong.PerformClick(); // tạo sự kiện Nhấp chuột của một Nút trên các sự kiện Nhấp chuột
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnThemPhong.Left; //  di chuyển dưới btn qua bên trái
            uC_ThemPhong1.Show(); //  để trạng thái có thể nhìn thấy  
            btnThemPhong.BringToFront(); // mang ra phía trước
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnDichVu.Left; //  di chuyển dưới btn qua bên trái
            uC_ThemDichVu1.Show(); //  để trạng thái có thể nhìn thấy
            btnDichVu.BringToFront(); // mang ra phía trước
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnNhanVien.Left; //  di chuyển dưới btn qua bên trái
            uC_ThemNhanVien1.Show(); //  để trạng thái có thể nhìn thấy
            btnNhanVien.BringToFront(); // mang ra phía trước
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnBaoCaoThongKe.Left; //  di chuyển dưới btn qua bên trái
            uS_BaoCaoThongKe1.Show(); //  để trạng thái có thể nhìn thấy
            btnBaoCaoThongKe.BringToFront(); // mang ra phía trước
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void LamMoiUC()
        {
            uC_ThemPhong1.Hide();
            uC_ThemDichVu1.Hide();
            uC_ThemNhanVien1.Hide();
            uS_BaoCaoThongKe1.Hide();

        }
        
        
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhapDangKy formDangNhapDangKy = new FormDangNhapDangKy();
            formDangNhapDangKy.Show();
        }

        private void uC_ThemDichVu1_Load(object sender, EventArgs e)
        {

        }
    }
}
