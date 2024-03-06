using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DichVuDAL
    {
        public void Insert(string maDV, string tenDV, int giaTien, string trangThai, string moTa)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = new DichVu() { MaDV = maDV, TenDichVu = tenDV, GiaTien = giaTien,TrangThai = trangThai, MoTa = moTa };
                db.DICHVU.Add(obj);
                db.SaveChanges();
            } 
        }
        public void Delete(string maDV)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from dv in db.DICHVU
                           where dv.MaDV == maDV
                           select dv).Single();
                db.DICHVU.Remove(obj);
                db.SaveChanges();
            }
        }
        public void Update(string maDV, string tenDV, int giaTien, string trangThai, string moTa)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from dv in db.DICHVU
                           where dv.MaDV == maDV
                           select dv).Single();

                if (string.IsNullOrEmpty(maDV.ToString()) != true)
                    obj.MaDV = maDV;

                if (string.IsNullOrEmpty(tenDV) != true)
                    obj.TenDichVu = tenDV;

                if (string.IsNullOrEmpty(giaTien.ToString()) != true)
                    obj.GiaTien = giaTien;

                if (string.IsNullOrEmpty(trangThai.ToString()) != true)
                    obj.TrangThai = trangThai;

                if (string.IsNullOrEmpty(giaTien.ToString()) != true)
                    obj.GiaTien = giaTien;

                if (string.IsNullOrEmpty(moTa) != true)
                    obj.MoTa = moTa;

                db.SaveChanges();
            }
        }
        public bool IsMa(string maDV)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from dv in db.DICHVU
                               where dv.MaDV == maDV
                               select dv.MaDV).ToList();
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

        public List<DichVu> GetList()
        {
            List<DichVu> list = new List<DichVu>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listPhong = from dv in db.DICHVU
                                orderby dv.MaDV ascending
                                select dv;
                foreach (var item in listPhong)
                {
                    list.Add(item);
                    /*string[] mang = {item.MaSV,item.TiengAnh.ToString(),item.TinHoc.ToString(),item.GDTC.ToString().ToString(), item.DiemTB.ToString() };
                    list[0]=(item.MaSV);*/
                }
                return list;
            }
        }
        public List<DichVu> GetList(string maDV)
        {
            List<DichVu> list = new List<DichVu>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listPhong = from dv in db.DICHVU
                                where dv.MaDV == maDV
                                select dv;
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
