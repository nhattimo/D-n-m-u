using BLL;
using System;
using System.Windows.Forms;


namespace GUI.All_User_Controller
{
    public partial class UC_DatPhong : UserControl
    {
        DatPhongBLL DatPhongBLL = new DatPhongBLL();
        PhongBLL phongBLL = new PhongBLL();
        NguoiDungBLL NguoiDungBLL = new NguoiDungBLL();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        PhieuThueBLL PhieuThueBLL = new PhieuThueBLL();
        string TrangThai;
        public UC_DatPhong()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            ShowDanhSachPhong();
        }
        private void UC_DatPhong_Load(object sender, EventArgs e)
        {
            LamMoiLabelVaText();
            ShowDanhSachPhong();
            ReadOnlyTxt();
            LabelDatPhongThanhCong.Visible = false;
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DateTime homNay = DateTime.Now;
            DateTime ngayNhan = DateTime.Parse(txtNgayNhanPhong.Text);
            DateTime ngayTra = DateTime.Parse(txtNgayTraPhong.Text);
            bool kt = true;
            // kiểm tra nhập vào số phòng
            if (string.IsNullOrEmpty(txtSoPhong.Text))
            {
                kt = false;
                LabelSaiSoPhong.Text = "Vui lòng chọn phòng cần đặt";
            }
            else
            {
                LabelSaiSoPhong.Text = "";
                // kiểm tra ngày nhận phòng
                
                if (homNay.Day > ngayNhan.Day && homNay.Month > ngayNhan.Month && homNay.Year > ngayNhan.Year)
                {
                    kt = false;
                    LabelSaiNgayDat.Text = "Ngày nhận phải lớn hơn hoặc bằng ngày hôm nay";
                }
                else LabelSaiNgayDat.Text = "";


                // kiểm tra ngày trả phòng
                if (ngayTra.Month < ngayNhan.Month)
                {
                    kt = false;
                    LabelSaiNgayTraPhong.Text = "Tháng trả phải lớn hơn tháng đặt";
                }
                else if (homNay.Day > ngayNhan.Day)
                {
                    kt = false;
                    LabelSaiNgayDat.Text = "Ngày nhận phải lớn hơn hoặc bằng ngày hôm nay";
                }
                else if (ngayTra.Day < ngayNhan.Day)
                {
                    kt = false;
                    LabelSaiNgayTraPhong.Text = "Ngày trả phải lớn hơn ngày đặt";
                }
                else if (ngayNhan.Day > ngayTra.Day && ngayNhan.Month > ngayTra.Month && ngayNhan.Year > ngayTra.Year)
                {
                    kt = false;
                    LabelSaiNgayTraPhong.Text = "Ngày trả phải lớn hơn hoặc bằng ngày hôm nay";
                }
                else if (ngayNhan.Day > ngayTra.Day && ngayNhan.Month > ngayTra.Month && ngayNhan.Year > ngayTra.Year)
                {
                    kt = false;
                    LabelSaiNgayTraPhong.Text = "Ngày trả phải lớn hơn ngày đặt";
                }
                else if (TrangThai == "Đã được đặt")
                {
                    string LoiDatNgay = "";
                    foreach (var item in DatPhongBLL.GetListDatPhongNDAccess(NguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream())))
                    {
                        foreach (var item1 in phongBLL.GetListPhongAccess(item.SoPhong.ToString()))
                        {
                            DateTime ngayNhan1 = DateTime.Parse(item.NgayNhanPhong.ToString());
                            DateTime ngayTra1 = DateTime.Parse(item.NgayTraPhong.ToString());
                            if (ngayTra1.Day >= ngayNhan.Day && ngayTra1.Month >= ngayNhan.Month)
                            {
                                kt = false;
                                LoiDatNgay += "không thể đặt phòng từ " + ngayNhan1 + " đến " + ngayTra1 + "\n";
                            }
                        }
                    }
                    if (LoiDatNgay != "")
                    {
                        MessageBox.Show(LoiDatNgay);
                    }
                }
                else if (TrangThai == "Đang sử dụng")
                {
                    string LoiDatNgay = "";
                    foreach (var item in PhieuThueBLL.ListPhieuThue(NguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream())))
                    {
                        foreach (var item1 in phongBLL.GetListPhongAccess(item.SoPhong.ToString()))
                        {
                            DateTime ngayNhan1 = DateTime.Parse(item.NgayNhanPhong.ToString());
                            DateTime ngayTra1 = DateTime.Parse(item.NgayTraPhong.ToString());
                            if (ngayTra1.Day >= ngayNhan.Day && ngayTra1.Month >= ngayNhan.Month)
                            {
                                kt = false;
                                LoiDatNgay += "không thể đặt phòng từ " + ngayNhan1 + " đến " + ngayTra1 + "\n";

                            }
                        }
                    }
                    if (LoiDatNgay != "")
                    {
                        MessageBox.Show(LoiDatNgay);
                    }

                }
                else LabelSaiNgayTraPhong.Text = "";
            }
           
            if (kt)
            {
                DatPhongBLL.InsertDatPhongAccess(txtSoPhong.Text, NguoiDungBLL.GetCCCD(taiKhoanBLL.GetMaTKFileStream()), txtNgayNhanPhong.Text, txtNgayTraPhong.Text);
                phongBLL.UpdateTrangThaiPhongAccess(txtSoPhong.Text, "Đã được đặt");
                LabelDatPhongThanhCong.Visible = true;
                ShowDanhSachPhong();
                LamMoiLabelVaText(); 
            }
            else
            {
                LabelDatPhongThanhCong.Visible = false;
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
                    LamMoiLabelVaText();
                }
                else
                {             
                    txtSoPhong.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtLoaiPhong.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtLoaiGiuong.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtGiaTien.Text = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
                    TrangThai = GridViewDanhSachPhong.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            catch (Exception)
            {

                LamMoiLabelVaText();
            }
            
        }

        void ShowDanhSachPhong()
        {
            DateTime homNay = DateTime.Now;
            DateTime ngayNhan = DateTime.Parse(txtNgayNhanPhong.Text);
            DateTime ngayTra = DateTime.Parse(txtNgayTraPhong.Text);
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
                if (homNay.Day >= ngayNhan.Day || homNay.Month >= ngayNhan.Month || homNay.Year >= ngayNhan.Year)
                {
                    string[] row = { item.SoPhong.ToString(), item.LoaiPhong, item.LoaiGiuong, (item.GiaTien).ToString(), item.TrangThai, item.MoTa };
                    GridViewDanhSachPhong.Rows.Add(row);
                }
                else LabelSaiNgayDat.Text = "";
                /*if (item.TrangThai == "Trống")
                {
                    string[] row = { item.SoPhong.ToString(), item.LoaiPhong, item.LoaiGiuong, (item.GiaTien).ToString(), item.TrangThai, item.MoTa };
                    GridViewDanhSachPhong.Rows.Add(row);
                }*/

            }
        }
        void LamMoiLabelVaText()
        {
            LabelSaiSoPhong.Text = "";
            LabelSaiLoaiPhong.Text = "";
            LabelSaiLoaiGiuong.Text = "";
            LabelSaiGiaTien.Text = "";
            LabelSaiNgayDat.Text = "";
            LabelSaiNgayTraPhong.Text = "";

            txtSoPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtLoaiGiuong.Text = "";
            txtGiaTien.Text = "";
            txtNgayNhanPhong.Text = DateTime.Now.ToString();
            txtNgayTraPhong.Text = DateTime.Now.ToString();
        }
        void ReadOnlyTxt()
        {
            txtSoPhong.ReadOnly = true;
            txtLoaiPhong.ReadOnly = true;
            txtLoaiGiuong.ReadOnly = true;
            txtGiaTien.ReadOnly = true;
        }
    }
}
