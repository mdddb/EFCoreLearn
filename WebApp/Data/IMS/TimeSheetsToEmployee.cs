using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
    public partial class TimeSheetsToEmployee
    {
        public TimeSheetsToEmployee()
        {
            TsemployeeDates = new HashSet<TsemployeeDate>();
            TsworkedHours = new HashSet<TsworkedHour>();
        }

        [Column("ID")]
        public Guid ID { get; set; }
        [StringLength(10)]
        public string EmployeeBadgeNumber { get; set; }
        public string Comment { get; set; }
        [Column("TimeSheetUID")]
        public Guid TimeSheetUid { get; set; }
        public bool IsDeletedFromTheGroup { get; set; }
        [Column("GroupUID")]
        public Guid GroupUid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EmployeeDeletedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EmplyeeAddedToTheGroupDate { get; set; }

        [ForeignKey("EmployeeBadgeNumber")]
        [InverseProperty("TimeSheetsToEmployees")]
        public virtual TbEmployee EmployeeBadgeNumberNavigation { get; set; }
        [ForeignKey("GroupUid")]
        [InverseProperty("TimeSheetsToEmployees")]
        public virtual GroupsSpecification GroupU { get; set; }
        [ForeignKey("TimeSheetUid")]
        [InverseProperty("TimeSheetsToEmployees")]
        public virtual TimeSheet TimeSheetU { get; set; }
        [InverseProperty("Tsemployee")]
        public virtual ICollection<TsemployeeDate> TsemployeeDates { get; set; }
        [InverseProperty("Tsemployee")]
        public virtual ICollection<TsworkedHour> TsworkedHours { get; set; }
    }
}
