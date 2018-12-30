using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_HOBUnit")]
    public partial class TbHobunit
    {
        public TbHobunit()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        [StringLength(6)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Descr { get; set; }
        public bool? Status { get; set; }

        [InverseProperty("EmpHobunitNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
