using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_AmendmentCode")]
    public partial class TbAmendmentCode
    {
        public TbAmendmentCode()
        {
            TbAmendments = new HashSet<TbAmendment>();
        }

        [Key]
        public int Code { get; set; }
        [StringLength(50)]
        public string Descr { get; set; }
        [Column("IFFactor")]
        public short? Iffactor { get; set; }

        [InverseProperty("TypeCodeNavigation")]
        public virtual ICollection<TbAmendment> TbAmendments { get; set; }
    }
}
