using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    [Table("NGUOIDUNG")]
    public class NguoiDung
    {
        [Key] // khóa chính
        [MaxLength(12)]
        [Column(TypeName = "VARCHAR")]
        public string CCCD { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [MaxLength(30)]
        public string HoVaTen { get; set; }
        public byte Tuoi { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string QuocTich { get; set; }
        [MaxLength(3)]
        [Column(TypeName = "NVARCHAR")]
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        [Column(TypeName = "VARCHAR")]
        [MaxLength(100)]
        public string Email { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        public string DiaChi { get; set; }
        public int SoPhong { get; set; }
        public int MaTK { get; set; }
        [ForeignKey("MaTK")]
        public virtual TaiKhoan TAIKHOAN { get; set; }
    }
}
