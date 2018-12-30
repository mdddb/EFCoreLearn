using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPODependantPassengerTypes")]
    public partial class LpodependantPassengerType
    {
        public LpodependantPassengerType()
        {
            Lpopassengers = new HashSet<Lpopassenger>();
        }

        [Column("ID")]
        public short ID { get; set; }
        [Column("NameENG")]
        public string NameEng { get; set; }

        [InverseProperty("DependantPassengerType")]
        public virtual ICollection<Lpopassenger> Lpopassengers { get; set; }
    }
}
