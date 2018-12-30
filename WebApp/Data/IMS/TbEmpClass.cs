using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_EmpClass")]
    public partial class TbEmpClass
    {
        public TbEmpClass()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        [StringLength(4)]
        public string Code { get; set; }
        [StringLength(30)]
        public string Descr { get; set; }
        [StringLength(2)]
        public string Level { get; set; }

        [InverseProperty("EmpClassNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
