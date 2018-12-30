using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_NatGroup")]
    public partial class TbNatGroup
    {
        public TbNatGroup()
        {
            TbNationalities = new HashSet<TbNationality>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }

        [InverseProperty("NatGroupNavigation")]
        public virtual ICollection<TbNationality> TbNationalities { get; set; }
    }
}
