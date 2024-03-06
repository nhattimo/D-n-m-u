using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        ThongKeDAL ThongKeDAL = new ThongKeDAL();
        public void InsertAccess(int SP, int SoGio, int SLDV, int GiaTienDV, int GiaTP, string CCCD, string MaNV, int TongTien)
        {
            ThongKeDAL.Insert(SP, SoGio, SLDV, GiaTienDV, GiaTP, CCCD, MaNV, TongTien);
        }

        public List<ThongKe> GetListccess()
        {
            return ThongKeDAL.GetList();
        }
    }
}
