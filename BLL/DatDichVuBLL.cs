using DAL;
using DTO;
using System.Collections.Generic;


namespace BLL
{
    public class DatDichVuBLL
    {
        DatDichVuDAL datDichVuDAL = new DatDichVuDAL();
        public void InsertAccess(string maDV, string CCCD, string soP, string NgayNhanDV)
        {
            datDichVuDAL.Insert(maDV, CCCD, soP, NgayNhanDV);
        }
        public bool DeleteAccess(int maDDV)
        {
            if (datDichVuDAL.IsMa(maDDV))
            {
                datDichVuDAL.Delete(maDDV);
                return true;
            }
            return false;
        }
        public bool IsMaAccess(int maDDV)
        {
            if (datDichVuDAL.IsMa(maDDV))
            {
                return true;
            }
            return false;
        }
        public List<DatDichVu> GetListAccess()
        {
            return datDichVuDAL.GetList();
        }
        public List<DatDichVu> GetListAccess(string CCCD)
        {
            return datDichVuDAL.GetList(CCCD);
        }
        public List<DatDichVu> GetListAccess(string soP, string CCCD, string ngayNhanDV)
        {
            if(datDichVuDAL.GetList(soP, CCCD, ngayNhanDV) != null)
            {
                return datDichVuDAL.GetList(soP, CCCD, ngayNhanDV);
            }
            return null;
            
        }

    }
}
