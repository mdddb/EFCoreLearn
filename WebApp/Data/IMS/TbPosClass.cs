using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_PosClass")]
    public partial class TbPosClass
    {
        public TbPosClass()
        {
            TbPositions = new HashSet<TbPosition>();
        }

        [Key]
        [StringLength(1)]
        public string Code { get; set; }
        [StringLength(30)]
        public string Descr { get; set; }

        [InverseProperty("ClassNavigation")]
        public virtual ICollection<TbPosition> TbPositions { get; set; }
    }
}
