using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("DanhMucs")]

    public class DanhMuc
    {

            [Key]
            public string MaDanhMuc { get; set; }
            public string TenDanhMuc { get; set; }
            [MaxLength(15)]
            public string PhanLoaiDanhMuc { get; set; }
        }
}