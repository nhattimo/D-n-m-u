using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DTO
{
    [Table("DatDichVu")]
    public class DatDichVu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDatDV { get; set; }
        public DateTime NgayNhanDV { get; set; }

        public string maDV { get; set; }
        [ForeignKey("maDV")]
        public virtual DichVu DichVu { get; set; }

        [MaxLength(5)]
        public string SoPhong { get; set; }
        [ForeignKey("SoPhong")]
        public virtual Phong PHONG { get; set; }

        public string TrangThai { get; set; }
        public string CCCD { get; set; }
        [ForeignKey("CCCD")]
        public virtual NguoiDung NGUOIDUNG { get; set; }
         
    }
}
