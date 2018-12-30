using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_KeyResource")]
    public partial class TbKeyResource
    {
        public TbKeyResource()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(30)]
        public string Descr { get; set; }

        [InverseProperty("EmpKeyResNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
