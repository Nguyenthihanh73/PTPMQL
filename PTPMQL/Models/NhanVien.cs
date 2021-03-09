using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
        [Table("NhanViens")]
        public class NhanVien
    {
            [Key]
            public string MaNhanVien { get; set; }
            public string TenNhanVien { get; set; }
            [MaxLength(15)]
            public string SoDienThoai { get; set; }
    }
}