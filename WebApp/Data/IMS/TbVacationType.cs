using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_VacationType")]
    public partial class TbVacationType
    {
        [Key]
        public short Code { get; set; }
        [StringLength(40)]
        public string Descr { get; set; }
    }
}
