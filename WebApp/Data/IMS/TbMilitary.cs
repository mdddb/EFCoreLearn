using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Military")]
    public partial class TbMilitary
    {
        [Key]
        [StringLength(10)]
        public string EmpBadge { get; set; }
        [StringLength(10)]
        public string RecordGroup { get; set; }
        [StringLength(16)]
        public string Specialty { get; set; }
        [StringLength(30)]
        public string Category { get; set; }
        [StringLength(60)]
        public string Fitness { get; set; }
        [StringLength(50)]
        public string Rank { get; set; }
        [StringLength(50)]
        public string MilitaryRank { get; set; }
        [StringLength(60)]
        public string DefenseDept { get; set; }
        [StringLength(255)]
        public string Family { get; set; }
        [StringLength(150)]
        public string Education { get; set; }
        [StringLength(20)]
        public string GenWorkExp { get; set; }
    }
}
