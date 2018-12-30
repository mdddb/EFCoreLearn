using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_EmpGroup")]
    public partial class TbEmpGroup
    {
        public TbEmpGroup()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        [StringLength(3)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Descr { get; set; }
        [Column("SIDAC")]
        [StringLength(6)]
        public string Sidac { get; set; }

        [InverseProperty("EmpGroupNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
