using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPOAuthorizers")]
    public partial class Lpoauthorizer
    {
        public Lpoauthorizer()
        {
            Lpoorders = new HashSet<Lpoorder>();
        }

        [Column("ID")]
        public short ID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Column("EmployeeID")]
        [StringLength(10)]
        public string EmployeeID { get; set; }
        public bool? IsNotActive { get; set; }

        [ForeignKey("EmployeeId")]
        [InverseProperty("Lpoauthorizers")]
        public virtual TbEmployee Employee { get; set; }
        [InverseProperty("Authorizer")]
        public virtual ICollection<Lpoorder> Lpoorders { get; set; }
    }
}
