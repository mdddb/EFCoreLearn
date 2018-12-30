using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_UnionGroup")]
    public partial class TbUnionGroup
    {
        public TbUnionGroup()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        [StringLength(3)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Descr { get; set; }

        [InverseProperty("EmpUnionNameNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
