using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_WBS")]
    public partial class TbWb
    {
        public TbWb()
        {
            GroupsSpecifications = new HashSet<GroupsSpecification>();
            TsworkedHours = new HashSet<TsworkedHour>();
        }

        [Column("WBSid")]
        [StringLength(20)]
        public string Wbsid { get; set; }
        [Column("WBSDescr")]
        [StringLength(256)]
        public string Wbsdescr { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [Column("ID")]
        public Guid ID { get; set; }
        [Column("JobCodeID")]
        [StringLength(10)]
        public string JobCodeID { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("JobCodeId")]
        [InverseProperty("TbWbs")]
        public virtual TbJobCode JobCode { get; set; }
        [InverseProperty("GroupDefaultWbs")]
        public virtual ICollection<GroupsSpecification> GroupsSpecifications { get; set; }
        [InverseProperty("TimeSheetWbs")]
        public virtual ICollection<TsworkedHour> TsworkedHours { get; set; }
    }
}
