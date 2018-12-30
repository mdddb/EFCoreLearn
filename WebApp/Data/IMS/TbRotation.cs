using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Rotation")]
    public partial class TbRotation
    {
        public TbRotation()
        {
            TbAmendmentNewRotationNavigations = new HashSet<TbAmendment>();
            TbAmendmentOldRotationNavigations = new HashSet<TbAmendment>();
            TbEmployeeEmpRotation2Navigation = new HashSet<TbEmployee>();
            TbEmployeeEmpRotationNavigations = new HashSet<TbEmployee>();
            TbStaffMovementNewRotationNavigations = new HashSet<TbStaffMovement>();
            TbStaffMovementOldRotationNavigations = new HashSet<TbStaffMovement>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }
        public short? DayOn { get; set; }
        public short? DayOff { get; set; }
        [Column("HL")]
        public byte? Hl { get; set; }
        public double? RotHour { get; set; }
        public double? RotDay { get; set; }
        public int? Coeff { get; set; }
        public double? CalHour { get; set; }
        public double? CalHourArr { get; set; }
        public double? HourDay { get; set; }
        public double? CalDaysMonth { get; set; }
        public double? CalDaysYear { get; set; }
        public double? HoursYear { get; set; }
        public double? AveDaysMonth { get; set; }
        public double? AveHoursMonth { get; set; }
        [Column("ADayOn")]
        public short? AdayOn { get; set; }
        [Column("ADayOff")]
        public short? AdayOff { get; set; }

        [InverseProperty("NewRotationNavigation")]
        public virtual ICollection<TbAmendment> TbAmendmentNewRotationNavigations { get; set; }
        [InverseProperty("OldRotationNavigation")]
        public virtual ICollection<TbAmendment> TbAmendmentOldRotationNavigations { get; set; }
        [InverseProperty("EmpRotation2Navigation")]
        public virtual ICollection<TbEmployee> TbEmployeeEmpRotation2Navigation { get; set; }
        [InverseProperty("EmpRotationNavigation")]
        public virtual ICollection<TbEmployee> TbEmployeeEmpRotationNavigations { get; set; }
        [InverseProperty("NewRotationNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementNewRotationNavigations { get; set; }
        [InverseProperty("OldRotationNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovementOldRotationNavigations { get; set; }
    }
}
