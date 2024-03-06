using DAL;
using DTO;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BLL
{
    public class NguoiDungBLL
    {
        NguoiDungDAL NguoiDungDAL = new NguoiDungDAL();
        TaiKhoanDAL TaiKhoanDAL = new TaiKhoanDAL();
        public bool InsertNguoiDungAccess(string TenTK,string hoVaTen, byte tuoi, string gioiTinh, string quocTich, string SDT, string Email, string diaChi, string CCCD)
        {
            // nếu CCCD đã được sử dụng thì trả về false
            if (NguoiDungDAL.IsCCCD(CCCD))
                return false;

            else
            {
                NguoiDungDAL.InsertNguoiDung(TaiKhoanDAL.GetMa(TenTK), hoVaTen, tuoi, gioiTinh, quocTich, SDT, Email, diaChi, CCCD);
                return true;
            }
        }
        public bool UpdateAccess(string CCCD, int soPhong)
        {
            if (NguoiDungDAL.IsCCCD(CCCD))
            {
                NguoiDungDAL.Update(CCCD, soPhong);
                return true;
            }
            return false;

        }
        public bool IsCCCD(string CCCD)
        {
            if (NguoiDungDAL.IsCCCD(CCCD))
                return true;
            return false;
        }
        public bool IsSoPhong(int soPhong)
        {
            if (NguoiDungDAL.IsSoPhong(soPhong))
                return true;
            return false;
        }
        public string GetCCCD(int MaTK)
        {
            return NguoiDungDAL.GetCCCD(MaTK);
        }
        public string GetName(string CCCD)
        {
           return NguoiDungDAL.GetName(CCCD);
        }
        public string GetNameAccess(int maTK)
        {
            return NguoiDungDAL.GetName(maTK);
        }
        public List<NguoiDung> ListNguoiDung()
        {
            return NguoiDungDAL.GetListNguoiDung();
        }
        public List<NguoiDung> ListNguoiDungTheoP(int soPhong)
        {
            return NguoiDungDAL.GetNguoiDungTheoSoP(soPhong);
        }
        public List<NguoiDung> ListAccess(int tk)
        {
            return NguoiDungDAL.GetList(tk);
        }
    }
}
