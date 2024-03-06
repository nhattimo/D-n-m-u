using DAL;
using System.IO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL TaiKhoanDAL = new TaiKhoanDAL();
        public bool InsertTaiKhoanAccess(string tenTK, string MK, string Role)
        {
            // nếu tài khoản đã tồn tại trả về false
            if (TaiKhoanDAL.IsTenTK(tenTK))
            {
                return false;
            }
            else
            {
                TaiKhoanDAL.InsertTaiKhoan(tenTK, MK, Role);
                return true;
            }
        }
        public bool DeleteAccess(int maTK)
        {
            if(IsMaAccess(maTK))
            {
                TaiKhoanDAL.Delete(maTK);
                return true;
            }
            return false;
        }
        public bool IsTenTK(string tenTaiKhoan)
        {
            if (TaiKhoanDAL.IsTenTK(tenTaiKhoan))
                return true;
            return false;
        }
        public bool IsMaAccess(int maTK)
        {
            if (TaiKhoanDAL.IsMa(maTK))
                return true;
            return false;
        }
        public string DangNhap (string tenTaiKhoan, string matKhau){
            string role = TaiKhoanDAL.DangNhapShowRole(tenTaiKhoan, matKhau);
            return role;

        }
        public int GetMaTK(string tenTaiKhoan)
        {
           return TaiKhoanDAL.GetMa(tenTaiKhoan);
        }
        public string GetTKAccess(int ma)
        {
            return TaiKhoanDAL.GetTk(ma);
        }
        public string GetMKAccess(int ma)
        {
            return TaiKhoanDAL.GetMK(ma);
        }


        public void SetMaTKFileStream(int maTK)
        {
            using (FileStream fs = new FileStream("data", FileMode.Create, FileAccess.ReadWrite))
            {
                
            }
            using (FileStream fs = new FileStream("data", FileMode.Truncate, FileAccess.ReadWrite))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(maTK);
                bw.Flush();
            }
        }
        public int GetMaTKFileStream()
        {
            int a = 0;
            using (FileStream fs = new FileStream("data", FileMode.Open, FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                a = br.ReadInt32();
            }
            return a;
        }
    }
}
