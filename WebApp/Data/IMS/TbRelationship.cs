using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Relationship")]
    public partial class TbRelationship
    {
        public TbRelationship()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public byte Code { get; set; }
        [Required]
        [StringLength(30)]
        public string Descr { get; set; }

        [InverseProperty("EmpKinRelNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
