using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TSEmployeeDates")]
    public partial class TsemployeeDate
    {
        public TsemployeeDate()
        {
            TsworkedHours = new HashSet<TsworkedHour>();
        }

        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("TSEmployeeID")]
        public Guid TsemployeeID { get; set; }
        [StringLength(3)]
        public string SumOfWorkedHoursOnIndicatedDate { get; set; }
        [Column("StatusID")]
        public short StatusID { get; set; }
        public string Comment { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("TsemployeeDates")]
        public virtual TimeSheetStatusesDictionary Status { get; set; }
        [ForeignKey("TsemployeeId")]
        [InverseProperty("TsemployeeDates")]
        public virtual TimeSheetsToEmployee Tsemployee { get; set; }
        [InverseProperty("TsemployeeDate")]
        public virtual ICollection<TsworkedHour> TsworkedHours { get; set; }
    }
}
