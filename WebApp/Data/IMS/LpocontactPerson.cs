using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPOContactPersons")]
    public partial class LpocontactPerson
    {
        public LpocontactPerson()
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
        [InverseProperty("LpocontactPeople")]
        public virtual TbEmployee Employee { get; set; }
        [InverseProperty("ContactPerson")]
        public virtual ICollection<Lpoorder> Lpoorders { get; set; }
    }
}
