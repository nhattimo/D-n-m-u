using BLL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Controller
{
    public partial class US_BaoCaoThongKe : UserControl
    {
        ThongKeBLL thongKeBLL = new ThongKeBLL();
        NguoiDungBLL NguoiDungBLL = new NguoiDungBLL();
        NhanVienBLL NhanVienBLL = new NhanVienBLL();
        int tongTien;
        public US_BaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void US_BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            ShowThongKe();
            txtTongTien.Text = "Tổng tiền: " + tongTien.ToString() + ".000VND";
        }

        void ShowThongKe()
        {
            GridViewThongKe.Rows.Clear();
            GridViewThongKe.ColumnCount = 8;
            GridViewThongKe.Columns[0].Name = "khách hàng";
            GridViewThongKe.Columns[1].Name = "Số phòng";
            GridViewThongKe.Columns[2].Name = "Thời gian";
            GridViewThongKe.Columns[3].Name = "Thành tiền";
            GridViewThongKe.Columns[4].Name = "Số lượng DV";
            GridViewThongKe.Columns[5].Name = "Thành tiền";
            GridViewThongKe.Columns[6].Name = "Nhân viên";
            GridViewThongKe.Columns[7].Name = "Tổng tiền";

            foreach (var item in thongKeBLL.GetListccess())
            {
                string[] row = { NguoiDungBLL.GetName(item.CCCD), item.SoPhong + "", item.SoGio + "", item.GiaTienPhong + "", item.SlDV + "", item.GiaTienDV+"", NhanVienBLL.GetNameAccess(item.MaNV), item.TongTien+""};
                string tien = formatTien(item.TongTien + "");
                tongTien += int.Parse(tien);
                GridViewThongKe.Rows.Add(row);
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
