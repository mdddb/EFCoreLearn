using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_WPCategory")]
    public partial class TbWpcategory
    {
        public TbWpcategory()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public byte Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }

        [InverseProperty("EmpWpcatNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
