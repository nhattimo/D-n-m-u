using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    internal class DangNhapDAL
    {
        public string IsRole(string tentk, string mk)
        {
            using (AppQLKSContext db = new AppQLKSContext())
            {
                try
                {
                    var obj = (from tk in db.TAIKHOAN
                               where tk.TenTK == tentk
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
            return true;
        }
    }
}
