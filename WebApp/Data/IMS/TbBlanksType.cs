using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_BlanksTypes")]
    public partial class TbBlanksType
    {
        public TbBlanksType()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        public string Type { get; set; }
        [Column("NameRU")]
        public string NameRu { get; set; }
        [Column("NameEN")]
        public string NameEn { get; set; }
        [Column("NameKZ")]
        public string NameKz { get; set; }
        public string Company { get; set; }

        [InverseProperty("BlanksTypesCodeNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
