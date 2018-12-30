using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_CostCenter")]
    public partial class TbCostCenter
    {
        public TbCostCenter()
        {
            TbEmployees = new HashSet<TbEmployee>();
            TbStaffMovementNewOccNavigations = new HashSet<TbStaffMovement>();
            TbStaffMovementOldOccNavigations = new HashSet<TbStaffMovement>();
        }

        [Key]
        [StringLength(6)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Descr { get; set; }
        [StringLength(10)]
        public string Referer { get; set; }

        [InverseProperty("EmpOccNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
        [InverseProperty("NewOccNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementNewOccNavigations { get; set; }
        [InverseProperty("OldOccNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementOldOccNavigations { get; set; }
    }
}
