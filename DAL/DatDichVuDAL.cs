using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class DatDichVuDAL
    {
        public void Insert(string maDV, string CCCD, string soP, string NgayNhanDV )
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = new DatDichVu() { maDV = maDV, CCCD = CCCD, SoPhong = soP,NgayNhanDV = DateTime.Parse(NgayNhanDV), };
                db.DATDICHVU.Add(obj);
                db.SaveChanges();
            }
        }
        /*public void Update(int MaDatPhong, string soP)
        {

            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from dp in db.DATPHONG
                           where dp.MaDP == MaDatPhong
                           select dp).Single();
                obj.SoPhong = soP;
                db.SaveChanges();
            }
        }*/
        public void Delete(int maDDV)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from dv in db.DATDICHVU
                           where dv.MaDatDV == maDDV
                           select dv).Single();
                db.DATDICHVU.Remove(obj);
                db.SaveChanges();
            }
        }
        public bool IsMa(int maDDV)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from dv in db.DATDICHVU
                               where dv.MaDatDV == maDDV
                               select dv.MaDatDV).ToList();
                    // nếu có trả về true 
                    if (obj.Count >= 1)
                        return true;
                    // ngược lại trả về false
                    return false;
                }
                catch (Exception)
                {

                    return true;
                }

            }
        }
        public bool GetMa(string CCCD, string ngayNhanDV)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from dv in db.DATDICHVU
                               where dv.NgayNhanDV == DateTime.Parse(ngayNhanDV) && dv.CCCD == CCCD
                               select dv.MaDatDV).ToList();
                    // If there are any matching records, return true
                    if (obj.Count >= 1)
                        return true;
                    // Otherwise, return false
                    return false;
                }
                catch (Exception)
                {
                    // Handle the exception as needed
                    return true;
                }
            }
        }
        
        public List<DatDichVu> GetList()
        {
            List<DatDichVu> list = new List<DatDichVu>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listdt = from dv in db.DATDICHVU
                             orderby dv.MaDatDV ascending
                             select dv;
                foreach (var item in listdt)
                {
                    list.Add(item);
                }
                return list;
            }
        }
        public List<DatDichVu> GetList(string CCCD)
        {
            List<DatDichVu> list = new List<DatDichVu>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listdt = from dv in db.DATDICHVU
                             where dv.CCCD == CCCD
                             orderby dv.SoPhong ascending
                             select dv;
                foreach (var item in listdt)
                {
                    list.Add(item);
                }
                return list;
            }
        }
        public List<DatDichVu> GetList(string soP, string CCCD, string ngayNhanDV)
        {
            List<DatDichVu> list = new List<DatDichVu>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                DateTime ngayNhan = DateTime.Parse(ngayNhanDV);
                var listdt = from dv in db.DATDICHVU
                             where dv.CCCD == CCCD && dv.SoPhong == soP && dv.NgayNhanDV.Month == ngayNhan.Month && dv.NgayNhanDV.Day == ngayNhan.Day && dv.NgayNhanDV.Year == ngayNhan.Year
                             select dv;
                if (listdt.ToList().Count >= 1)
                {
                    foreach (var item in listdt)
                    {
                        list.Add(item);
                    }
                    return list;
                }
                else
                    return null;
            }
        }
    }
}
