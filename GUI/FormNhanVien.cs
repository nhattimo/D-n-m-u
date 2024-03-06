using BLL;
using GUI.All_User_Controller;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormNhanVien : Form
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        NhanVienBLL NhanVienBLL = new NhanVienBLL();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LamMoiUC();
            btnThongTinPhong.PerformClick(); // tạo sự kiện Nhấp chuột của một Nút trên các sự kiện Nhấp chuột
            int maTK = taiKhoanBLL.GetMaTKFileStream();
            txtName.Text = NhanVienBLL.GetNameAccess(maTK);
            txtMaNV.Text = NhanVienBLL.GetMaNVAccess(maTK);
        }

        void LamMoiUC()
        {
            uC_Phong1.Visible = false;
            uC_DichVu1.Visible = false;
            uC_NV_DatPhong1.Visible=false;
            uC_KhachHang1.Visible = false;
            uC_NV_DangKyKhachHang1.Visible = false;
            uC_NV_ThanhToan1.Visible = false;
            uC_US_NV1.Visible = false;
            btnDangXuat.Visible = false;


        }
        private void btnThongTinPhong_Click(object sender, EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnThongTinPhong.Left; //  di chuyển dưới btn qua bên trái
            panelMoving.Width = btnThongTinPhong.Width;
            uC_Phong1.Visible = true; //  để trạng thái có thể nhìn thấy
            btnThongTinPhong.BringToFront(); // mang ra phía trước
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnDatPhong.Left; //  di chuyển dưới btn qua bên trái
            panelMoving.Width = btnDatPhong.Width;
            uC_NV_DatPhong1.Visible = true; //  để trạng thái có thể nhìn thấy
            btnDatPhong.BringToFront(); // mang ra phía trước
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnKhachHang.Left; //  di chuyển dưới btn qua bên trái
            panelMoving.Width = btnKhachHang.Width;
            uC_KhachHang1.Visible = true; //  để trạng thái có thể nhìn thấy
            btnKhachHang.BringToFront(); // mang ra phía trước
        }

        private void btnDangKiKhachHang_Click(object sender, EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnDangKiKhachHang.Left; //  di chuyển dưới btn qua bên trái
            panelMoving.Width = btnDangKiKhachHang.Width;
            uC_NV_DangKyKhachHang1.Visible = true; //  để trạng thái có thể nhìn thấy
            btnDangKiKhachHang.BringToFront(); // mang ra phía trước
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = guna2Button1.Left; //  di chuyển dưới btn qua bên trái
            panelMoving.Width = guna2Button1.Width;
            uC_US_NV1.Visible = true;
            btnDangXuat.BringToFront();
            btnDangXuat.Visible = true;

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnThanhToan.Left; //  di chuyển dưới btn qua bên trái
            panelMoving.Width = btnThanhToan.Width;
            uC_NV_ThanhToan1.Visible = true;
            btnThanhToan.Visible = true;
        }

        

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhapDangKy formDangNhapDangKy = new FormDangNhapDangKy();
            formDangNhapDangKy.Show();
            this.Close();
        }

    }
}
