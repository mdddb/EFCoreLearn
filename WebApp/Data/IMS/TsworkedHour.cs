using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TSWorkedHours")]
    public partial class TsworkedHour
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column("TSEmployeeID")]
        public Guid TsemployeeID { get; set; }
        [Column("ID")]
        public Guid ID { get; set; }
        [Required]
        [StringLength(3)]
        public string Hours { get; set; }
        [Column("StatusID")]
        public short StatusID { get; set; }
        public string Comment { get; set; }
        [Column("TimeSheetJobCodeID")]
        [StringLength(10)]
        public string TimeSheetJobCodeID { get; set; }
        [Column("TimeSheetWBSID")]
        public Guid? TimeSheetWbsid { get; set; }
        [Column("TimeSheetTRCID")]
        [StringLength(10)]
        public string TimeSheetTrcid { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("TsworkedHours")]
        public virtual TimeSheetStatusesDictionary Status { get; set; }
        [ForeignKey("TimeSheetJobCodeId")]
        [InverseProperty("TsworkedHours")]
        public virtual TbJobCode TimeSheetJobCode { get; set; }
        [ForeignKey("TimeSheetTrcid")]
        [InverseProperty("TsworkedHours")]
        public virtual TbTrc TimeSheetTrc { get; set; }
        [ForeignKey("TimeSheetWbsid")]
        [InverseProperty("TsworkedHours")]
        public virtual TbWb TimeSheetWbs { get; set; }
        [ForeignKey("TsemployeeId")]
        [InverseProperty("TsworkedHours")]
        public virtual TimeSheetsToEmployee Tsemployee { get; set; }
        [ForeignKey("Date,TsemployeeId")]
        [InverseProperty("TsworkedHours")]
        public virtual TsemployeeDate TsemployeeDate { get; set; }
    }
}
