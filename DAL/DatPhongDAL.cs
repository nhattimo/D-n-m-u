using DTO;
using System;
using System.Linq;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class DatPhongDAL
    {
        public void InsertDatPhong(string soPhong, string CCCD, string NgayNhanPhong, string NgayTraPhong)
        {
            DateTime thoiGian = DateTime.Now;
            string gio = thoiGian.Hour.ToString();
            gio += ":" + thoiGian.Minute.ToString();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = new DatPhong() { SoPhong = soPhong, CCCD = CCCD,ThoiGianDat = DateTime.Parse(gio), NgayNhanPhong = DateTime.Parse(NgayNhanPhong), NgayTraPhong = DateTime.Parse(NgayTraPhong) };
                db.DATPHONG.Add(obj);
                db.SaveChanges();
            }
        }
        public void Update(int MaDatPhong, string soP)
        {

            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from dp in db.DATPHONG
                           where dp.MaDP == MaDatPhong
                           select dp).Single();
                obj.SoPhong = soP;
                db.SaveChanges();
            }
        }
        public void Delete(int maDP)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from dp in db.DATPHONG
                           where dp.MaDP == maDP
                           select dp).Single();
                db.DATPHONG.Remove(obj);
                db.SaveChanges();
            }
        }
        public bool IsMa(int maDP)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from dp in db.DATPHONG
                               where dp.MaDP == maDP
                               select dp.MaDP).ToList();
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
        public string GetCCCD(int maDP)
        {
            string cccd = "";
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from dp in db.DATPHONG
                               where dp.MaDP == maDP
                               select dp.CCCD).ToList();
                    if (obj.Count >= 1)
                    {
                        obj.ForEach(t => cccd = t);
                        return cccd;
                    }
                    else
                        return cccd;
                }
                catch (Exception)
                {

                    return cccd;
                }

            }
        }
        public List<DatPhong> GetListDatPhong()
        {
            List<DatPhong> list = new List<DatPhong>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listdt = from dp in db.DATPHONG
                             orderby dp.SoPhong ascending
                             select dp;
                foreach (var item in listdt)
                {
                    list.Add(item);
                    /*string[] mang = {item.MaSV,item.TiengAnh.ToString(),item.TinHoc.ToString(),item.GDTC.ToString().ToString(), item.DiemTB.ToString() };
                    list[0]=(item.MaSV);*/
                }
                return list;
            }
        }
        public List<DatPhong> GetListDatPhongND(string CCCD)
        {
            List<DatPhong> list = new List<DatPhong>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listdt = from dp in db.DATPHONG
                             where dp.CCCD == CCCD
                             orderby dp.SoPhong ascending
                             select dp;
                foreach (var item in listdt)
                {
                    list.Add(item);
                }
                return list;
            }
        }
    }
}
