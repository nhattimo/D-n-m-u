using System.Data.Entity;
using DTO;

namespace DAL
{
    public class AppQLKSContext : DbContext
    {
        public AppQLKSContext() : base(@"Server = NHATTIMO\MSSQLSERVER01; Database = App_QLKS_3Layer_EF_CodeFirst; Trusted_Connection = true;")
        {

        }
        public DbSet<TaiKhoan> TAIKHOAN { get; set; }
        public DbSet<NguoiDung> NGUOIDUNG { get; set; }
        public DbSet<Phong> PHONG { get; set; }
        public DbSet<NhanVien> NHANVIEN { get; set; }
        public DbSet<DatPhong> DATPHONG { get; set; }
        public DbSet<PhieuThue> PHIEUTHUE { get; set; }
        public DbSet<HoaDon> HOADON { get; set; }
        public DbSet<DichVu> DICHVU { get; set; }
        public DbSet<DatDichVu> DATDICHVU { get; set; }
        public DbSet<ThongKe> THONGKE { get; set; }

    }
}
