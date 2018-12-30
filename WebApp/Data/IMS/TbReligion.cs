using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Religion")]
    public partial class TbReligion
    {
        [Key]
        public short Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }
    }
}
