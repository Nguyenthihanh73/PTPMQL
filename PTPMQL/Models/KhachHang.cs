using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    { 
        [Key]
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        [MaxLength(15)]
        public string SoDienThoai { get; set; }
    }
}