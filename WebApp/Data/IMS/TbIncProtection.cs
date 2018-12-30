using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_IncProtection")]
    public partial class TbIncProtection
    {
        public TbIncProtection()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }
        public double? Premium { get; set; }

        [InverseProperty("EmpIncProtNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
