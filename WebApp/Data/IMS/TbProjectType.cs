using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_ProjectType")]
    public partial class TbProjectType
    {
        public TbProjectType()
        {
            TbWorkLocations = new HashSet<TbWorkLocation>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }

        [InverseProperty("ProjTypeNavigation")]
        public virtual ICollection<TbWorkLocation> TbWorkLocations { get; set; }
    }
}
