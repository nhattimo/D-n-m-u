using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    [Table ("PHONG")]
    public class Phong
    {
        [Key] // khóa chính
        [MaxLength (5)]
        public string SoPhong { get; set; }
        [Column(TypeName = "NVARCHAR")]
        public string LoaiPhong {get; set; }
        [Column(TypeName = "NVARCHAR")]
        public string LoaiGiuong { get; set; }
        [Column(TypeName = "Money")]
        public decimal GiaTien { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength (250)]
        public string MoTa { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
        public string TrangThai { get; set; }    
    }
}
