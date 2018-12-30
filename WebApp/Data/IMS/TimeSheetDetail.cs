using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
    public partial class TimeSheetDetail
    {
        [Key]
        [Column("TimeSheetUID")]
        public Guid TimeSheetUid { get; set; }
        public short CountOfWorkedHoursAtIndicatedArea { get; set; }
        public string Comment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdateTime { get; set; }
        [StringLength(10)]
        public string LastUpdatedByBadge { get; set; }
        public string LastUpdatedByUsername { get; set; }
        public bool IsRemoved { get; set; }

        [ForeignKey("LastUpdatedByBadge")]
        [InverseProperty("TimeSheetDetails")]
        public virtual TbEmployee LastUpdatedByBadgeNavigation { get; set; }
        [ForeignKey("TimeSheetUid")]
        [InverseProperty("TimeSheetDetail")]
        public virtual TimeSheet TimeSheetU { get; set; }
    }
}
