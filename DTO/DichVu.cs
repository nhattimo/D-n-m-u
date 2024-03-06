using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DTO
{
    [Table("DichVu")]
    public class DichVu
    {
 
        [MaxLength(5)]
        [Key]
        public string MaDV { get; set; }
            
        public string TenDichVu { get; set; }


        [Column(TypeName = "Money")]
        public decimal GiaTien { get; set; }

        public string TrangThai { get; set; }

        public string MoTa { get; set; }
    }
}
