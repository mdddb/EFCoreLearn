using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Marital")]
    public partial class TbMarital
    {
        public TbMarital()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        [StringLength(1)]
        public string Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }

        [InverseProperty("EmpMaritalNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
