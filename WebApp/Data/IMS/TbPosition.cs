using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Position")]
    public partial class TbPosition
    {
        public TbPosition()
        {
            TbAmendmentNewPostNavigations = new HashSet<TbAmendment>();
            TbAmendmentOldPostNavigations = new HashSet<TbAmendment>();
            TbEmployeeEmpAposNavigations = new HashSet<TbEmployee>();
            TbEmployeeEmpCposNavigations = new HashSet<TbEmployee>();
            TbStaffMovementNewPostNavigations = new HashSet<TbStaffMovement>();
            TbStaffMovementOldPostNavigations = new HashSet<TbStaffMovement>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(100)]
        public string Descr { get; set; }
        [StringLength(100)]
        public string DescrLoc { get; set; }
        [StringLength(100)]
        public string DescrKaz { get; set; }
        [Column("CREA")]
        [StringLength(2)]
        public string Crea { get; set; }
        [StringLength(1)]
        public string Class { get; set; }

        [ForeignKey("Class")]
        [InverseProperty("TbPositions")]
        public virtual TbPosClass ClassNavigation { get; set; }
        [ForeignKey("Crea")]
        [InverseProperty("TbPositions")]
        public virtual TbCrea CreaNavigation { get; set; }
        [InverseProperty("NewPostNavigation")]
        public virtual ICollection<TbAmendment> TbAmendmentNewPostNavigations { get; set; }
        [InverseProperty("OldPostNavigation")]
        public virtual ICollection<TbAmendment> TbAmendmentOldPostNavigations { get; set; }
        [InverseProperty("EmpAposNavigation")]
        public virtual ICollection<TbEmployee> TbEmployeeEmpAposNavigations { get; set; }
        [InverseProperty("EmpCposNavigation")]
        public virtual ICollection<TbEmployee> TbEmployeeEmpCposNavigations { get; set; }
        [InverseProperty("NewPostNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementNewPostNavigations { get; set; }
        [InverseProperty("OldPostNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementOldPostNavigations { get; set; }
    }
}
