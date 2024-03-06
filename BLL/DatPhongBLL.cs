using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class DatPhongBLL
    {
        DatPhongDAL DatPhongDAL = new DatPhongDAL();
        public void InsertDatPhongAccess(string soPhong, string CCCD, string NgayNhanPhong, string NgayTraPhong)
        {
            DatPhongDAL.InsertDatPhong(soPhong, CCCD, NgayNhanPhong, NgayTraPhong);
        }
        public void UpdateAccess(int MaDatPhong, string soP)
        {
            DatPhongDAL.Update(MaDatPhong, soP);
        }
        public bool DeleteAccess(int maDP)
        {
            if (DatPhongDAL.IsMa(maDP))
            {
                DatPhongDAL.Delete(maDP);
                return true;
            }
            return false;
        }
        public string GetCCCDAccess(int maDP)
        {
            return DatPhongDAL.GetCCCD(maDP);
        }
        public List<DatPhong> ListDatPhog()
        {
            return DatPhongDAL.GetListDatPhong();
        }
        public List<DatPhong> GetListDatPhongNDAccess(string CCCD)
        {
            return DatPhongDAL.GetListDatPhongND(CCCD);
        }
    }
}
