using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPOAgencies")]
    public partial class Lpoagency
    {
        public Lpoagency()
        {
            Lpoorders = new HashSet<Lpoorder>();
        }

        [Column("ID")]
        public short ID { get; set; }
        [Column("NameENG")]
        public string NameEng { get; set; }
        public bool? IsNotActive { get; set; }

        [InverseProperty("Agency")]
        public virtual ICollection<Lpoorder> Lpoorders { get; set; }
    }
}
