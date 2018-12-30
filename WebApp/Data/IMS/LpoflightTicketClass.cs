using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPOFlightTicketClasses")]
    public partial class LpoflightTicketClass
    {
        public LpoflightTicketClass()
        {
            LpoflightTickets = new HashSet<LpoflightTicket>();
        }

        [Column("ID")]
        public byte ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Column("HRMSTicketTypeID")]
        public byte? HrmsticketTypeID { get; set; }
        public bool? IsNotActive { get; set; }

        [ForeignKey("HrmsticketTypeId")]
        [InverseProperty("LpoflightTicketClasses")]
        public virtual TbTicketType HrmsticketType { get; set; }
        [InverseProperty("Class")]
        public virtual ICollection<LpoflightTicket> LpoflightTickets { get; set; }
    }
}
