using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_PensionGroup")]
    public partial class TbPensionGroup
    {
        public TbPensionGroup()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }
        [StringLength(50)]
        public string DescrLoc { get; set; }

        [InverseProperty("EmpPensionGroupNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
