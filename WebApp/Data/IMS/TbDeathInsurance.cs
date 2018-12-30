using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_DeathInsurance")]
    public partial class TbDeathInsurance
    {
        public TbDeathInsurance()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        public double? Amount { get; set; }
        public double? Premium { get; set; }

        [InverseProperty("EmpDeathInsNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
