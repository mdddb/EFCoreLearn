using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_EmpStat")]
    public partial class TbEmpStat
    {
        public TbEmpStat()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(10)]
        public string Descr { get; set; }
        [Column("SIDAC")]
        [StringLength(10)]
        public string Sidac { get; set; }

        [InverseProperty("EmpStatNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
