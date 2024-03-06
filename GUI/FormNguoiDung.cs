using BLL;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormNguoiDung : Form
    {
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        NguoiDungBLL NguoiDungBLL = new NguoiDungBLL();
        public FormNguoiDung()
        {
            InitializeComponent();
        }
        private void FormNguoiDung_Load(object sender, System.EventArgs e)
        {
            LamMoiUC();
            btnDatPhong.PerformClick();
            int maTK = TaiKhoanBLL.GetMaTKFileStream();
            txtName.Text = NguoiDungBLL.GetNameAccess(maTK);
            txtSoCCCD.Text = NguoiDungBLL.GetCCCD(maTK);

        }
        private void btnDatPhong_Click(object sender, System.EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnDatPhong.Left; //  di chuyển dưới btn qua bên trái
            panelMoving.Width = btnDatPhong.Width;
            uC_DatPhong1.Show(); //  để trạng thái có thể nhìn thấy
            btnDatPhong.BringToFront(); // mang ra phía trước
        }
        private void btnDoiPhong_Click(object sender, System.EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnDoiPhong.Left; //  di chuyển dưới btn qua bên trái
            panelMoving.Width = btnDoiPhong.Width;
            uC_DoiPhong1.Refresh();
            uC_DoiPhong1.Show(); //  để trạng thái có thể nhìn thấy
            btnDoiPhong.BringToFront(); // mang ra phía trước
        }
        private void btnDichVu_Click(object sender, System.EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnDichVu .Left; //  di chuyển dưới btn qua bên trái
            panelMoving .Width = btnDichVu .Width;
            uC_DichVu1.Show(); //  để trạng thái có thể nhìn thấy
            btnDichVu.BringToFront(); // mang ra phía trước
        }
        private void btnNguoiDung_Click(object sender, System.EventArgs e)
        {
            LamMoiUC();
            panelMoving.Left = btnNguoiDung.Left; //  di chuyển dưới btn qua bên trái
            panelMoving.Width = btnNguoiDung.Width;
            uC_US_NguoiDung1.Show(); //  để trạng thái có thể nhìn thấy
            btnNguoiDung.BringToFront(); // mang ra phía trước
            btnDangXuat.Visible = true;
            btnDangXuat.BringToFront();

        }
        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void uC_DatPhong1_Load(object sender, System.EventArgs e)
        {

        }
       
        void LamMoiUC()
        {
            uC_DatPhong1.Hide();
            uC_DichVu1.Hide();
            uC_US_NguoiDung1.Hide();
            uC_DoiPhong1.Hide();
            btnDangXuat.Visible = false;
        }

        private void btnDangXuat_Click(object sender, System.EventArgs e)
        {
            FormDangNhapDangKy formDangNhapDangKy = new FormDangNhapDangKy();
            formDangNhapDangKy.Show();
            this.Close();
        }
    }
}
