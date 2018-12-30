using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_CREA")]
    public partial class TbCrea
    {
        public TbCrea()
        {
            TbAmendmentNewCreaNavigations = new HashSet<TbAmendment>();
            TbAmendmentOldCreaNavigations = new HashSet<TbAmendment>();
            TbEmployees = new HashSet<TbEmployee>();
            TbPositions = new HashSet<TbPosition>();
        }

        [Key]
        [StringLength(2)]
        public string Code { get; set; }
        [StringLength(30)]
        public string Descr { get; set; }
        public double? Family { get; set; }
        public double? Single { get; set; }
        public double? Onshore { get; set; }
        public double? Offshore { get; set; }
        public double? Drilling { get; set; }
        public double? Quay { get; set; }

        [InverseProperty("NewCreaNavigation")]
        public virtual ICollection<TbAmendment> TbAmendmentNewCreaNavigations { get; set; }
        [InverseProperty("OldCreaNavigation")]
        public virtual ICollection<TbAmendment> TbAmendmentOldCreaNavigations { get; set; }
        [InverseProperty("EmpGradeNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
        [InverseProperty("CreaNavigation")]
        public virtual ICollection<TbPosition> TbPositions { get; set; }
    }
}
