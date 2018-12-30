using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_JobLevel")]
    public partial class TbJobLevel
    {
        public TbJobLevel()
        {
            TbAmendmentNewLevelNavigations = new HashSet<TbAmendment>();
            TbAmendmentOldLevelNavigations = new HashSet<TbAmendment>();
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(4)]
        public string Level { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }

        [InverseProperty("NewLevelNavigation")]
        public virtual ICollection<TbAmendment> TbAmendmentNewLevelNavigations { get; set; }
        [InverseProperty("OldLevelNavigation")]
        public virtual ICollection<TbAmendment> TbAmendmentOldLevelNavigations { get; set; }
        [InverseProperty("EmpLevelNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
