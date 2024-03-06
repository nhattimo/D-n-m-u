using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace DAL
{
    public class NhanVienDAL
    {
        public void Insert(string maNV, int MaTK,string CCCD, string hoVaTen, string SDT, string gioiTinh, string diaChi,int luong, DateTime ngayVaoLam)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = new NhanVien() { MaNV = maNV, MaTK = MaTK,CCCD = CCCD, TenNV = hoVaTen, SDT = SDT, GioiTinh = gioiTinh, DiaChi = diaChi, Luong = luong, NgayVaoLam = ngayVaoLam };
                db.NHANVIEN.Add(obj);
                db.SaveChanges();
            }
        }

        public void Delete(string maNV)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from nv in db.NHANVIEN
                           where nv.MaNV == maNV
                           select nv).Single();
                db.NHANVIEN.Remove(obj);
                db.SaveChanges();
            }
        }
        public void Update(string maNV, string hoVaTen,string CCCD, string SDT, string gioiTinh, string diaChi, int luong, DateTime ngayVaoLam)
        {

            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from nv in db.NHANVIEN
                           where nv.MaNV == maNV
                           select nv).Single();

                if (string.IsNullOrEmpty(hoVaTen.ToString()) != true)
                    obj.TenNV = hoVaTen;
                if (string.IsNullOrEmpty(CCCD) != true)
                    obj.CCCD = CCCD;
                if (string.IsNullOrEmpty(SDT) != true)
                    obj.SDT = SDT;
                if (string.IsNullOrEmpty(gioiTinh) != true)
                    obj.GioiTinh = gioiTinh;
                if (string.IsNullOrEmpty(diaChi) != true)
                    obj.DiaChi = diaChi;
                if (string.IsNullOrEmpty(luong.ToString()) != true)
                    obj.Luong = luong;
                if (string.IsNullOrEmpty(ngayVaoLam.ToString()) != true)
                    obj.NgayVaoLam = ngayVaoLam;

                db.SaveChanges();
            }
        }
        public bool IsMa(string ma)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from nv in db.NHANVIEN
                               where nv.MaNV == ma
                               select nv.MaNV).ToList();
                    if (obj.Count >= 1)
                        return true;
                    return false;
                }
                catch (Exception)
                {
                    return true;
                }
            }
        }
        public bool IsCCCD(string CCCD)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from CC in db.NHANVIEN
                               where CC.CCCD == CCCD
                               select CC.CCCD).ToList();
                    if (obj.Count >= 1)
                        return true;
                    return false;
                }
                catch (Exception)
                {
                    return true;
                }
            }
        }
        public string GetName(string ma)
        {
            string item = "";
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from nv in db.NHANVIEN
                           where nv.MaNV == ma
                           select nv.TenNV).ToList();
                if (obj.Count > 0)
                {
                    obj.ForEach(t => item = t);
                    return item;
                }
                else
                    return item;
            }
        }
        public string GetName(int maTK)
        {
            string item = "";
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from nv in db.NHANVIEN
                           where nv.MaTK == maTK
                           select nv.TenNV).ToList();
                if (obj.Count > 0)
                {
                    obj.ForEach(t => item = t);
                    return item;
                }
                else
                    return item;
            }
        }
        public string GetMaNV(int maTk)
        {
            string item = "";
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from nv in db.NHANVIEN
                           where nv.MaTK == maTk
                           select nv.MaNV).ToList();
                if (obj.Count > 0)
                {
                    obj.ForEach(t => item = t);
                    return item;
                }
                else
                    return item;
            }
        }
        public int GetMaTK(string maNV)
        {
            int item = 0;
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from nv in db.NHANVIEN
                           where nv.MaNV == maNV
                           select nv.MaTK).ToList();
                if (obj.Count > 0)
                {
                    obj.ForEach(t => item = t);
                    return item;
                }
                else
                    return item;
            }
        }
        public List<NhanVien> GetTableList()
        {
            List<NhanVien> list = new List<NhanVien>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listND = from nv in db.NHANVIEN
                             orderby nv.MaNV ascending
                             select nv;
                foreach (var item in listND)
                {
                    list.Add(item);
                }
                return list;
            }
        }
    }
}
