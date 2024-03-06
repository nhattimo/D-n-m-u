using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDAL
    {
        public void Insert(int SP, int SoGio, int SLDV, int GiaTienDV, int GiaTP, string CCCD, string MaNV, int TongTien)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = new ThongKe() { SoPhong = SP, SoGio = SoGio, SlDV = SLDV, GiaTienDV = GiaTienDV, GiaTienPhong = GiaTP, CCCD = CCCD, MaNV = MaNV, TongTien = TongTien };
                db.THONGKE.Add(obj);
                db.SaveChanges();
            }
        }

        public List<ThongKe> GetList()
        {
            List<ThongKe> list = new List<ThongKe>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listdt = from dv in db.THONGKE
                             orderby dv.Ma ascending
                             select dv;
                foreach (var item in listdt)
                {
                    list.Add(item);
                }
                return list;
            }
        }
    }
}
