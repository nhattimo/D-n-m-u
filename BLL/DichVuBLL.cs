using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class DichVuBLL
    {
        DichVuDAL DichVuDAL = new DichVuDAL();
        public bool InsertAccess(string maDV, string tenDV, int giaTien, string trangThai, string moTa)
        {
            // ma nay ko co thi cho add
            if (DichVuDAL.IsMa(maDV) != true)
            {
                DichVuDAL.Insert(maDV, tenDV, giaTien, trangThai,moTa);
                return true;
            }
            return false;
        }
        public bool DeleteAccess(string maDV)
        {
            if (DichVuDAL.IsMa(maDV))
            {
                DichVuDAL.Delete(maDV);
                return true;
            }
            return false;
        }
        public bool UpdateAccess(string maDV, string tenDV, int giaTien, string trangThai, string moTa)
        {
            if (DichVuDAL.IsMa(maDV))
            {
                DichVuDAL.Update(maDV, tenDV, giaTien, trangThai, moTa);
                return true;
            }
            return false;
        }
        public bool IsMaAccess(string maDV)
        {
            if (DichVuDAL.IsMa(maDV))
            {
                DichVuDAL.IsMa(maDV);
                return true;
            }
            return false;
        }

        


        public List<DichVu> GetListAccess()
        {
            return DichVuDAL.GetList();
        }
        public List<DichVu> GetListAccess(string maDV)
        {
            return DichVuDAL.GetList(maDV);
        }

    
    }
}
