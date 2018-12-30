using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Nationalization")]
    public partial class TbNationalization
    {
        public TbNationalization()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(40)]
        public string Descr { get; set; }

        [InverseProperty("EmpNationalNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
