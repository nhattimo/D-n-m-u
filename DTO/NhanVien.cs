using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table("NHANVIEN")]
    public class NhanVien
    {
        [Key]
        [MaxLength(5)]
        public string MaNV { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string TenNV { get; set; }

        [MaxLength(12)]
        [Column(TypeName = "VARCHAR")]
        public string CCCD { get; set; }
        public string SDT { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(3)]
        public string GioiTinh { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        public string DiaChi { get; set; }
        [Column(TypeName = "Money")]
        public decimal Luong { get; set; }
        public DateTime NgayVaoLam { get; set; }
        
        public int MaTK { get; set; }
        [ForeignKey("MaTK")]
        public virtual TaiKhoan TAIKHOAN { get; set; }
    }
}
