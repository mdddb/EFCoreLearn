using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_VisaType")]
    public partial class TbVisaType
    {
        public TbVisaType()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }

        [InverseProperty("EmpVisaTypeNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
