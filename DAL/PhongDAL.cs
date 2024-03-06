using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class PhongDAL
    {
        public void InsertPhong(string soPhong, string loaiPhong, string loaiGiuong, int giaTien, string trangThai, string moTa)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = new Phong() { SoPhong = soPhong, LoaiPhong = loaiPhong, LoaiGiuong = loaiGiuong, GiaTien = giaTien, TrangThai = trangThai , MoTa = moTa };
                db.PHONG.Add(obj); 
                db.SaveChanges();
            }
        }
        public void DeletePhong(string soPhong)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from p in db.PHONG
                           where p.SoPhong == soPhong
                           select p).Single();
                db.PHONG.Remove(obj);
                db.SaveChanges();
            }
        }
        public void UpdatePhong(string soPhong, string loaiPhong, string loaiGiuong, int giaTien, string trangThai, string moTa)
        {

            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from p in db.PHONG
                           where p.SoPhong == soPhong
                           select p).Single();

                if (string.IsNullOrEmpty(soPhong.ToString()) != true)
                    obj.SoPhong = soPhong;
                if (string.IsNullOrEmpty(loaiPhong) != true)
                    obj.LoaiPhong = loaiPhong;
                if (string.IsNullOrEmpty(loaiGiuong) != true)
                    obj.LoaiGiuong = loaiGiuong;
                if (string.IsNullOrEmpty(giaTien.ToString()) != true)
                    obj.GiaTien = giaTien;
                if (string.IsNullOrEmpty(trangThai) != true)
                    obj.TrangThai = trangThai;
                if (string.IsNullOrEmpty(moTa) != true)
                    obj.MoTa = moTa;

                db.SaveChanges();
            }
        }
        public void UpdateTrangThaiPhong(string soPhong, string trangThai)
        {

            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from p in db.PHONG
                           where p.SoPhong == soPhong
                           select p).Single();
                obj.TrangThai = trangThai;
                db.SaveChanges();
            }
        }
        public string GetTrangThai(string soPhong)
        {
            string phong = "";
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from sp in db.PHONG
                           where sp.SoPhong == soPhong
                           select sp.TrangThai).ToList();
                if (obj.Count >= 1)
                {
                    obj.ForEach(t => phong = t);
                    return phong;
                }
                else
                    return phong;
            }
        }
        
        public bool IsSoPhong(string soPhong)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from p in db.PHONG
                               where p.SoPhong == soPhong
                               select p.SoPhong).ToList();
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
        public List<Phong> GetListPhong()
        {
            List<Phong> list = new List<Phong>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listPhong = from p in db.PHONG
                                 orderby p.SoPhong ascending
                                select p;
                foreach (var item in listPhong)
                {
                    list.Add(item);
                    /*string[] mang = {item.MaSV,item.TiengAnh.ToString(),item.TinHoc.ToString(),item.GDTC.ToString().ToString(), item.DiemTB.ToString() };
                    list[0]=(item.MaSV);*/
                }
                return list;
            }
        }
        public List<Phong> GetListPhong(string soPhong)
        {
            List<Phong> list = new List<Phong>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listPhong = from p in db.PHONG
                                where p.SoPhong == soPhong
                                select p;
                foreach (var item in listPhong)
                {
                    list.Add(item);
                    /*string[] mang = {item.MaSV,item.TiengAnh.ToString(),item.TinHoc.ToString(),item.GDTC.ToString().ToString(), item.DiemTB.ToString() };
                    list[0]=(item.MaSV);*/
                }
                return list;
            }
        }
    }
}
