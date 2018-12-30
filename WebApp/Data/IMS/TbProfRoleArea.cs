using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_ProfRoleArea")]
    public partial class TbProfRoleArea
    {
        public TbProfRoleArea()
        {
            TbProfRoles = new HashSet<TbProfRole>();
        }

        [Key]
        [StringLength(2)]
        public string Code { get; set; }
        [StringLength(40)]
        public string Descr { get; set; }

        [InverseProperty("AreaNavigation")]
        public virtual ICollection<TbProfRole> TbProfRoles { get; set; }
    }
}
