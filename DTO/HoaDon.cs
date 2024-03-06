using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace DTO
{
    [Table("HOADON")]
    public class HoaDon
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int MaHD { get; set; }
        public int TongSoGioThue  { get; set; }
        [Column(TypeName = "Money")]
        public decimal ThanhTien { get; set; }

        public int MaPhieu { get; set; }
        [ForeignKey("MaPhieu")]
        public virtual PhieuThue PHIEUTHUE { get; set; }
        public int MaDatDV { get; set; }
        [ForeignKey("MaDatDV")]
        public virtual DatDichVu DatDichVu { get; set; }
    }
}
