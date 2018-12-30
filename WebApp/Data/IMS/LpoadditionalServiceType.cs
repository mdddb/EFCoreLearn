using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPOAdditionalServiceTypes")]
    public partial class LpoadditionalServiceType
    {
        public LpoadditionalServiceType()
        {
            LpoadditionalServices = new HashSet<LpoadditionalService>();
        }

        [Column("ID")]
        public byte ID { get; set; }
        [Required]
        public string Name { get; set; }
        public bool? IsNotActive { get; set; }

        [InverseProperty("Type")]
        public virtual ICollection<LpoadditionalService> LpoadditionalServices { get; set; }
    }
}
