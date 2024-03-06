using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("THONGKE")]
    public class ThongKe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int Ma { get; set; }
        public int SoPhong { get; set; }
        public int SoGio { get; set; }

        public int SlDV { get; set; }

        [Column(TypeName = "Money")]
        public decimal GiaTienDV { get; set; }

        [Column(TypeName = "Money")]
        public decimal GiaTienPhong { get; set; }
        [Column(TypeName = "NVARCHAR")]

        public string MaNV { get; set; }
        [ForeignKey("MaNV")]
        public virtual NhanVien NHANVIEN { get; set; }

        public string CCCD { get; set; }
        [ForeignKey("CCCD")]
        public virtual NguoiDung NGUOIDUNG { get; set; }
        
        [Column(TypeName = "Money")]
        public decimal TongTien { get; set; }
    }    
}
