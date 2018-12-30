using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_JobCode")]
    public partial class TbJobCode
    {
        public TbJobCode()
        {
            GroupsSpecifications = new HashSet<GroupsSpecification>();
            TbWbs = new HashSet<TbWb>();
            TsworkedHours = new HashSet<TsworkedHour>();
        }

        [Key]
        [Column("JobCodeID")]
        [StringLength(10)]
        public string JobCodeID { get; set; }
        [StringLength(256)]
        public string Description { get; set; }
        [StringLength(20)]
        public string Type { get; set; }
        [StringLength(50)]
        public string Referent { get; set; }
        [StringLength(20)]
        public string ControllerGroup { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        public bool IsActive { get; set; }

        [InverseProperty("GroupDefaultJobCode")]
        public virtual ICollection<GroupsSpecification> GroupsSpecifications { get; set; }
        [InverseProperty("JobCode")]
        public virtual ICollection<TbWb> TbWbs { get; set; }
        [InverseProperty("TimeSheetJobCode")]
        public virtual ICollection<TsworkedHour> TsworkedHours { get; set; }
    }
}
