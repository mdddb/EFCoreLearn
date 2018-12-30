using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_RoleFamily")]
    public partial class TbRoleFamily
    {
        public TbRoleFamily()
        {
            TbProfRoles = new HashSet<TbProfRole>();
        }

        [Key]
        [StringLength(4)]
        public string Code { get; set; }
        [StringLength(40)]
        public string Descr { get; set; }

        [InverseProperty("FamilyNavigation")]
        public virtual ICollection<TbProfRole> TbProfRoles { get; set; }
    }
}
