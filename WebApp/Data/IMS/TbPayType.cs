using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_PayType")]
    public partial class TbPayType
    {
        public TbPayType()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }

        [InverseProperty("EmpPayTypeNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
