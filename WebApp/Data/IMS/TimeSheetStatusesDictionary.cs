using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TimeSheetStatusesDictionary")]
    public partial class TimeSheetStatusesDictionary
    {
        public TimeSheetStatusesDictionary()
        {
            TimeSheets = new HashSet<TimeSheet>();
            TsemployeeDates = new HashSet<TsemployeeDate>();
            TsworkedHours = new HashSet<TsworkedHour>();
        }

        [Key]
        [Column("StatusID")]
        public short StatusID { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }

        [InverseProperty("TsStatus")]
        public virtual ICollection<TimeSheet> TimeSheets { get; set; }
        [InverseProperty("Status")]
        public virtual ICollection<TsemployeeDate> TsemployeeDates { get; set; }
        [InverseProperty("Status")]
        public virtual ICollection<TsworkedHour> TsworkedHours { get; set; }
    }
}
