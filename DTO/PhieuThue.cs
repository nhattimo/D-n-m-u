using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table("PHIEUTHUE")]
    public class PhieuThue
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int MaPhieu { get; set; }
        public DateTime NgayNhanPhong { get; set; }
        public DateTime NgayTraPhong { get; set; }

        [MaxLength(5)]
        public string SoPhong { get; set; }
        [ForeignKey("SoPhong")]
        public virtual Phong PHONG { get; set; }

        public string CCCD { get; set; }
        [ForeignKey("CCCD")]
        public virtual NguoiDung NGUOIDUNG { get; set; }

        public string MaNV { get; set; }
        [ForeignKey("MaNV")]
        public virtual NhanVien NHANVIEN { get; set; }

        public string TrangThai { get; set; }

    }
}
