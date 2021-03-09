using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{ 
    [Table("QuanLiNhapHangs")]
    public class QuanLiNhapHang
    {
        [Key]
        public string NgayNhapHang { get; set; }
        public string NgayGioNhaphang { get; set; }
        [MaxLength(15)]
        public string TienNhapHang { get; set; }

    }
}