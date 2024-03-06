using DAL;
using DTO;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;


namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL NhanVienDAL = new NhanVienDAL();
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        public bool InsertAccess(string TenTK, string maNV,string CCCD, string hoVaTen, string SDT, string gioiTinh, string diaChi, int luong, DateTime ngayVaoLam)
        {
            // nếu CCCD đã được sử dụng thì trả về false
            if (IsMaAccess(maNV))
                return false;

            NhanVienDAL.Insert(maNV, TaiKhoanBLL.GetMaTK(TenTK), CCCD, hoVaTen, SDT, gioiTinh, diaChi, luong, ngayVaoLam);
            return true;  
        }
        public bool DeleteAccess(string ma)
        {
            if (IsMaAccess(ma))
            {
                NhanVienDAL.Delete(ma);
                return true; 
            }
            return false;
        }
        public bool UpdateAccess(string maNV, string hoVaTen, string CCCD,string SDT, string gioiTinh, string diaChi, int luong, DateTime ngayVaoLam)
        {
            if (IsMaAccess(maNV))
            {
                NhanVienDAL.Update(maNV, hoVaTen, CCCD, SDT, gioiTinh, diaChi, luong, ngayVaoLam);
                return true;
            }
            return false;
        }

        public bool IsCCCDAccess(string CCCD)
        {
            if (NhanVienDAL.IsCCCD(CCCD))
                return true;
            return false;
        }
        public bool IsMaAccess(string ma)
        {
            if (NhanVienDAL.IsMa(ma))
                return true;
            return false;
        }
        public string GetMaNVAccess(int maTK)
        {
            return NhanVienDAL.GetMaNV(maTK);
        }
        public string GetNameAccess(string ma)
        {
            return NhanVienDAL.GetName(ma);
        }
        public string GetNameAccess(int maTK)
        {
            return NhanVienDAL.GetName(maTK);
        }
        public int GetMaTKAccess(string maNV)
        {
            return NhanVienDAL.GetMaTK(maNV);
        }
        public List<NhanVien> TableList()
        {
            return NhanVienDAL.GetTableList();
        }
    }
}
