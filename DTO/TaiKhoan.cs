using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table("TAIKHOAN")]
    public class TaiKhoan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int MaTK { get; set; }
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }
    }
}
