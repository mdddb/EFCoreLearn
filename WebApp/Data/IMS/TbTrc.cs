using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_TRC")]
    public partial class TbTrc
    {
        public TbTrc()
        {
            GroupsSpecifications = new HashSet<GroupsSpecification>();
            TsworkedHours = new HashSet<TsworkedHour>();
        }

        [Key]
        [Column("TRCCode")]
        [StringLength(10)]
        public string Trccode { get; set; }
        [Column("TRCDescr")]
        [StringLength(256)]
        public string Trcdescr { get; set; }
        [StringLength(20)]
        public string Type { get; set; }
        public bool IsActive { get; set; }

        [InverseProperty("GroupDefaultTrc")]
        public virtual ICollection<GroupsSpecification> GroupsSpecifications { get; set; }
        [InverseProperty("TimeSheetTrc")]
        public virtual ICollection<TsworkedHour> TsworkedHours { get; set; }
    }
}
