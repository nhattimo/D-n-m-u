using DTO;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL
{
    public class NguoiDungDAL
    {
        public void InsertNguoiDung(int MaTK,string hoVaTen, byte tuoi, string gioiTinh, string quocTich, string SDT, string Email, string diaChi, string CCCD)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var objND = new NguoiDung() { HoVaTen = hoVaTen, Tuoi = tuoi, GioiTinh = gioiTinh, QuocTich = quocTich, SDT = SDT, Email = Email, DiaChi = diaChi, CCCD = CCCD, MaTK = MaTK };
                db.NGUOIDUNG.Add(objND);
                db.SaveChanges();
            }
        }
        public void Update(string CCCD, int soPhong)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from nd in db.NGUOIDUNG
                           where nd.CCCD == CCCD
                           select nd).Single();
                obj.SoPhong = soPhong;
                db.SaveChanges();
            }
        }
        public bool IsCCCD(string CCCD)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from CC in db.NGUOIDUNG
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
        public bool IsSoPhong(int soPhong)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from nd in db.NGUOIDUNG
                           where nd.SoPhong == soPhong
                           select nd.CCCD).ToList();
                if (obj.Count >= 1)
                    return true;
                return false;
            }
        }
        public string GetCCCD(int MaTK)
        {
            string item = "";
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from CC in db.NGUOIDUNG
                           where CC.MaTK == MaTK
                           select CC.CCCD).ToList();
                if (obj.Count > 0)
                {
                    obj.ForEach(t => item = t);
                    return item;
                }
                else
                    return item;
            }
        }
        public string GetName(string CCCD)
        {
            string item = "";
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from nd in db.NGUOIDUNG
                           where nd.CCCD == CCCD 
                           select nd.HoVaTen).ToList();
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
                var obj = (from nd in db.NGUOIDUNG
                           where nd.MaTK == maTK
                           select nd.HoVaTen).ToList();
                if (obj.Count > 0)
                {
                    obj.ForEach(t => item = t);
                    return item;
                }
                else
                    return item;
            }
        }
        public List<NguoiDung> GetListNguoiDung()
        {
            List<NguoiDung> list = new List<NguoiDung>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listND = from nd in db.NGUOIDUNG
                                orderby nd.Tuoi ascending
                             select nd;
                foreach (var item in listND)
                {
                    list.Add(item);
                    /*string[] mang = {item.MaSV,item.TiengAnh.ToString(),item.TinHoc.ToString(),item.GDTC.ToString().ToString(), item.DiemTB.ToString() };
                    list[0]=(item.MaSV);*/
                }
                return list;
            }
        }
        public List<NguoiDung> GetNguoiDungTheoSoP(int soPhong)
        {
            List<NguoiDung> list = new List<NguoiDung>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listND = from nd in db.NGUOIDUNG
                             where nd.SoPhong == soPhong
                             select nd;
                foreach (var item in listND)
                {
                    list.Add(item);
                }
                return list;
            }
        }
        public List<NguoiDung> GetList(int tk)
        {
            List<NguoiDung> list = new List<NguoiDung>();
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var listND = from nd in db.NGUOIDUNG
                             where nd.MaTK == tk
                             select nd;
                foreach (var item in listND)
                {
                    list.Add(item);
                }
                return list;
            }
        }
    }
}
