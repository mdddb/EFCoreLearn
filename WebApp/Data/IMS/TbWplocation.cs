using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_WPLocation")]
    public partial class TbWplocation
    {
        public TbWplocation()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(40)]
        public string Descr { get; set; }

        [InverseProperty("EmpWplocNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
