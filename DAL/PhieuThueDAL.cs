using DTO;
using System;
using System.Linq;
using System.Collections.Generic;

namespace DAL
{
    public class PhieuThueDAL
    {
        public void InsertPhieuThue(string soPhong, DateTime ngayNhanPhong, DateTime ngayTraPhong, string CCCD, string MaNV, string trangThai )
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = new PhieuThue() { SoPhong = soPhong,NgayNhanPhong = ngayNhanPhong, NgayTraPhong = ngayTraPhong, CCCD = CCCD, MaNV = MaNV, TrangThai = trangThai };
                db.PHIEUTHUE.Add( obj );
                db.SaveChanges();
            }
        }
        public void UpdateAccess(int maP, string TrangThai)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from pt in db.PHIEUTHUE
                           where pt.MaPhieu == maP
                           select pt).Single();
                obj.TrangThai = TrangThai;
                db.SaveChanges();
            }
        }
        public void Update(int maPhiue, string soP)
        {

            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from pt in db.PHIEUTHUE
                           where pt.MaPhieu == maPhiue 
                           select pt).Single();
                obj.SoPhong = soP;
                db.SaveChanges();
            }
        }
        public List<PhieuThue> GetListPhieuThue()
        {
            List<PhieuThue> list = new List<PhieuThue>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listPT = from pt in db.PHIEUTHUE
                             //orderby pt.PHONG ascending
                             select pt;
                
                foreach (var item in listPT)
                {
                    list.Add(item);
                } 
                return list;
                

            }
        }
        public List<PhieuThue> GetListPhieuThue(int maPhieuThue)
        {
            List<PhieuThue> list = new List<PhieuThue>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listPT = from pt in db.PHIEUTHUE
                             where pt.MaPhieu == maPhieuThue
                             select pt;

                foreach (var item in listPT)
                {
                    list.Add(item);
                }
                return list;


            }
        }
        public List<PhieuThue> GetListPhieuThue(string CCCD)
        {
            List<PhieuThue> list = new List<PhieuThue>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listPT = from pt in db.PHIEUTHUE
                             where pt.CCCD == CCCD
                             select pt;

                foreach (var item in listPT)
                {
                    list.Add(item);
                }
                return list;


            }
        }
    }
}
