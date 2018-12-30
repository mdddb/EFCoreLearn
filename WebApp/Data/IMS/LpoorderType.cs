using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPOOrderTypes")]
    public partial class LpoorderType
    {
        public LpoorderType()
        {
            Lpoorders = new HashSet<Lpoorder>();
        }

        [Column("ID")]
        public short ID { get; set; }
        [Column("NameENG")]
        public string NameEng { get; set; }
        public string Code { get; set; }
        public bool? IsNotActive { get; set; }

        [InverseProperty("Type")]
        public virtual ICollection<Lpoorder> Lpoorders { get; set; }
    }
}
