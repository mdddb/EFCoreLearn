using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_WorkLocation")]
    public partial class TbWorkLocation
    {
        public TbWorkLocation()
        {
            TbEmployees = new HashSet<TbEmployee>();
            TbStaffMovementNewWorkLocNavigations = new HashSet<TbStaffMovement>();
            TbStaffMovementOldWorkLocNavigations = new HashSet<TbStaffMovement>();
            TmsapprovalMatricesToWorkLocations = new HashSet<TmsapprovalMatricesToWorkLocation>();
        }

        [Key]
        public short Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Descr { get; set; }
        public short? ProjType { get; set; }
        [Column("WGroup")]
        public byte? Wgroup { get; set; }
        [Column("WArea")]
        [StringLength(8)]
        public string Warea { get; set; }
        [StringLength(150)]
        public string Address { get; set; }
        [StringLength(150)]
        public string AddressLoc { get; set; }
        [StringLength(150)]
        public string AddressKaz { get; set; }
        [Column("SIDAC")]
        [StringLength(6)]
        public string Sidac { get; set; }

        [ForeignKey("ProjType")]
        [InverseProperty("TbWorkLocations")]
        public virtual TbProjectType ProjTypeNavigation { get; set; }
        [InverseProperty("EmpWorkLocNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
        [InverseProperty("NewWorkLocNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementNewWorkLocNavigations { get; set; }
        [InverseProperty("OldWorkLocNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementOldWorkLocNavigations { get; set; }
        [InverseProperty("WorkLocationCodeNavigation")]
        public virtual ICollection<TmsapprovalMatricesToWorkLocation> TmsapprovalMatricesToWorkLocations { get; set; }
    }
}
