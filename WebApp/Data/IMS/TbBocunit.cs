using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_BOCUnit")]
    public partial class TbBocunit
    {
        public TbBocunit()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        [StringLength(6)]
        public string Code { get; set; }
        [StringLength(30)]
        public string Descr { get; set; }
        public bool? Status { get; set; }

        [InverseProperty("EmpBocunitNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
