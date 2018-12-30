using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_MedInsurance")]
    public partial class TbMedInsurance
    {
        public TbMedInsurance()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }
        public double? Premium { get; set; }

        [InverseProperty("EmpMedInsNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
