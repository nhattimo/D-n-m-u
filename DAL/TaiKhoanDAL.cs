using DTO;
using System;
using System.Linq;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public void InsertTaiKhoan(string tenTK, string MK, string Role)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var objTK = new TaiKhoan() { TenTK = tenTK, MatKhau = MK, VaiTro = Role };
                db.TAIKHOAN.Add(objTK);
                db.SaveChanges();
            }
        }
        public void Delete(int maTK)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from tk in db.TAIKHOAN
                           where tk.MaTK == maTK
                           select tk).Single();
                db.TAIKHOAN.Remove(obj);
                db.SaveChanges();
            }
        }
        public bool IsTenTK(string Tentk)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from tk in db.TAIKHOAN
                               where tk.TenTK == Tentk
                               select tk.TenTK).ToList();
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
        public bool IsMa(int maTK)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from tk in db.TAIKHOAN
                            where tk.MaTK == maTK
                            select tk.MaTK).ToList();
                // nếu có trả về true 
                if (obj.Count >= 1)
                    return true;
                // ngược lại trả về false
                return false;
            }
        }
        public int GetMa(string Tentk)
        {
            int ma = 0;
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from maTK in db.TAIKHOAN
                           where maTK.TenTK == Tentk
                           select maTK.MaTK).ToList();
                if (obj.Count >= 1)
                {
                    obj.ForEach(t => ma = t);
                    return ma;
                }
                else
                    return ma;
            }
        }
        public string GetTk(int maTK)
        {
            string taiKhoan = "";
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from tk in db.TAIKHOAN
                           where tk.MaTK == maTK
                           select tk.TenTK).ToList();
                if (obj.Count >= 1)
                {
                    obj.ForEach(t => taiKhoan = t);
                    return taiKhoan;
                }
                else
                    return taiKhoan;
            }
        }
        public string GetMK(int maTK)
        {
            string matKhau = "";
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var obj = (from mk in db.TAIKHOAN
                           where mk.MaTK == maTK
                           select mk.MatKhau).ToList();
                if (obj.Count >= 1)
                {
                    obj.ForEach(t => matKhau = t);
                    return matKhau;
                }
                else
                    return matKhau;
            }
        }
        public string DangNhapShowRole(string tenTK, string matKhau)
        {
            string role = string.Empty;
            using (AppQLKSContext db = new AppQLKSContext())
            {
                var result = (from us in db.TAIKHOAN
                              where us.TenTK == tenTK && us.MatKhau == matKhau
                              select us.VaiTro).ToList();
                if (result.Count >= 1)
                    result.ForEach(r => role = r);
                return role;

            }
        }
    }
}
