using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_BussUnit")]
    public partial class TbBussUnit
    {
        public TbBussUnit()
        {
            TbEmployees = new HashSet<TbEmployee>();
            TbProjects = new HashSet<TbProject>();
            TbStaffMovementNewBuNavigations = new HashSet<TbStaffMovement>();
            TbStaffMovementOldBuNavigations = new HashSet<TbStaffMovement>();
            TmsapprovalMatricesToBusinessUnits = new HashSet<TmsapprovalMatricesToBusinessUnit>();
        }

        [Key]
        [StringLength(6)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Descr { get; set; }
        public byte[] Logo { get; set; }

        [InverseProperty("EmpBussUnitNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
        [InverseProperty("BussUnitNavigation")]
        public virtual ICollection<TbProject> TbProjects { get; set; }
        [InverseProperty("NewBuNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementNewBuNavigations { get; set; }
        [InverseProperty("OldBuNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementOldBuNavigations { get; set; }
        [InverseProperty("BusinessUnitCodeNavigation")]
        public virtual ICollection<TmsapprovalMatricesToBusinessUnit> TmsapprovalMatricesToBusinessUnits { get; set; }
    }
}
