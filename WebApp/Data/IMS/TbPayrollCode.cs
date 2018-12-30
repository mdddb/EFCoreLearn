using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_PayrollCode")]
    public partial class TbPayrollCode
    {
        [Key]
        [StringLength(5)]
        public string Code { get; set; }
        [StringLength(250)]
        public string Descr { get; set; }
        [StringLength(250)]
        public string DescLoc { get; set; }
        [Column("payDC")]
        public int PayDc { get; set; }
        [Column("payGross")]
        public int PayGross { get; set; }
        public int LabourCost { get; set; }
        public int Display { get; set; }
    }
}
