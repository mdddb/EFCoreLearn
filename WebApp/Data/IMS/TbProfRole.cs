using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_ProfRole")]
    public partial class TbProfRole
    {
        public TbProfRole()
        {
            TbAmendmentNewProleNavigations = new HashSet<TbAmendment>();
            TbAmendmentOldProleNavigations = new HashSet<TbAmendment>();
            TbEmployees = new HashSet<TbEmployee>();
            TbStaffMovementNewProleNavigations = new HashSet<TbStaffMovement>();
            TbStaffMovementOldProleNavigations = new HashSet<TbStaffMovement>();
        }

        [Key]
        [StringLength(8)]
        public string Code { get; set; }
        [Required]
        [StringLength(60)]
        public string Descr { get; set; }
        public bool? Status { get; set; }
        [StringLength(2)]
        public string Area { get; set; }
        [StringLength(4)]
        public string Family { get; set; }

        [ForeignKey("Area")]
        [InverseProperty("TbProfRoles")]
        public virtual TbProfRoleArea AreaNavigation { get; set; }
        [ForeignKey("Family")]
        [InverseProperty("TbProfRoles")]
        public virtual TbRoleFamily FamilyNavigation { get; set; }
        [InverseProperty("NewProleNavigation")]
        public virtual ICollection<TbAmendment> TbAmendmentNewProleNavigations { get; set; }
        [InverseProperty("OldProleNavigation")]
        public virtual ICollection<TbAmendment> TbAmendmentOldProleNavigations { get; set; }
        [InverseProperty("EmpProleNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
        [InverseProperty("NewProleNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementNewProleNavigations { get; set; }
        [InverseProperty("OldProleNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementOldProleNavigations { get; set; }
    }
}
