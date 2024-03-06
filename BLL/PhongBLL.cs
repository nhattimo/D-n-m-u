using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class PhongBLL
    {
        PhongDAL PhongDAL = new PhongDAL();
        public void InsertPhongAccess(string soPhong, string loaiPhong, string loaiGiuong, int giaTien, string trangThai, string moTa)
        {
            PhongDAL.InsertPhong(soPhong, loaiPhong, loaiGiuong, giaTien, trangThai, moTa);
        }
        public bool IsSoPhong(string soPhong)
        {
            if (PhongDAL.IsSoPhong(soPhong))
                return true;
            return false;
        }
        public List<Phong> ListPhong()
        {
            return PhongDAL.GetListPhong();
        }
        public List<Phong> GetListPhongAccess(string soPhong)
        {
            return PhongDAL.GetListPhong(soPhong);
        }
        public void DeletePhongAccess(string soPhong)
        {
            PhongDAL.DeletePhong(soPhong);
        }
        public void UpdatePhong(string soPhong, string loaiPhong, string loaiGiuong, int giaTien, string trangThai, string moTa)
        {
            PhongDAL.UpdatePhong(soPhong, loaiPhong, loaiGiuong, giaTien, trangThai, moTa);
        }
        public void UpdateTrangThaiPhongAccess(string soPhong, string trangThai)
        {
            PhongDAL.UpdateTrangThaiPhong(soPhong, trangThai);
        }
        public string GetTrangThaiAccess(string soP)
        {
            return PhongDAL.GetTrangThai(soP);
        }
    }
}
