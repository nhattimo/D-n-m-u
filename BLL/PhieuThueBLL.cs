using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PhieuThueBLL
    {
        PhieuThueDAL phieuThueDAL = new PhieuThueDAL();
        public void InsertPhieuThueAccess(string soPhong, DateTime ngayNhanPhong, DateTime ngayTraPhong, string CCCD, string MaNV, string trangThai)
        {
            phieuThueDAL.InsertPhieuThue(soPhong, ngayNhanPhong, ngayTraPhong, CCCD, MaNV, trangThai);
        }
        public void UpdateAccessTT(int maP, string TrangThai)
        {
            phieuThueDAL.UpdateAccess(maP, TrangThai);
        }
        public void UpdateAccess(int maPhiue, string soP)
        {
            phieuThueDAL.Update(maPhiue, soP);
        }
        public List<PhieuThue> ListPhieuThue()
        {
            return phieuThueDAL.GetListPhieuThue();
        }
        public List<PhieuThue> ListPhieuThue(int maPhieuThue)
        {
            return phieuThueDAL.GetListPhieuThue(maPhieuThue);
        }
        public List<PhieuThue> ListPhieuThue(string CCCD)
        {
            return phieuThueDAL.GetListPhieuThue(CCCD);
        }
    }
}
