using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TimeSheet")]
    public partial class TimeSheet
    {
        public TimeSheet()
        {
            TimeSheetsToEmployees = new HashSet<TimeSheetsToEmployee>();
        }

        [Key]
        [Column("TimeSheetUID")]
        public Guid TimeSheetUid { get; set; }
        [Column(TypeName = "date")]
        public DateTime TimeSheetDateTime { get; set; }
        public string Comment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdateTime { get; set; }
        [StringLength(10)]
        public string LastUpdatedByBadge { get; set; }
        public string LastUpdatedByUsername { get; set; }
        public bool IsRemoved { get; set; }
        [Column("TS_Status_ID")]
        public short TsStatusID { get; set; }
        [Column("TSName")]
        public string Tsname { get; set; }

        [ForeignKey("LastUpdatedByBadge")]
        [InverseProperty("TimeSheets")]
        public virtual TbEmployee LastUpdatedByBadgeNavigation { get; set; }
        [ForeignKey("TsStatusId")]
        [InverseProperty("TimeSheets")]
        public virtual TimeSheetStatusesDictionary TsStatus { get; set; }
        [InverseProperty("TimeSheetU")]
        public virtual TimeSheetDetail TimeSheetDetail { get; set; }
        [InverseProperty("TimeSheetU")]
        public virtual ICollection<TimeSheetsToEmployee> TimeSheetsToEmployees { get; set; }
    }
}
