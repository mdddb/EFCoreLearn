using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_EmpStatReason")]
    public partial class TbEmpStatReason
    {
        public TbEmpStatReason()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(50)]
        public string Descr { get; set; }

        [InverseProperty("EmpRelReasonNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
