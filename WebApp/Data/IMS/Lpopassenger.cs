using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPOPassengers")]
    public partial class Lpopassenger
    {
        [Column("ID")]
        public Guid ID { get; set; }
        [Column("TicketsPurchaseOrderID")]
        public Guid TicketsPurchaseOrderID { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [Column("DependantPassengerTypeID")]
        public short? DependantPassengerTypeID { get; set; }

        [ForeignKey("DependantPassengerTypeId")]
        [InverseProperty("Lpopassengers")]
        public virtual LpodependantPassengerType DependantPassengerType { get; set; }
        [ForeignKey("TicketsPurchaseOrderId")]
        [InverseProperty("Lpopassengers")]
        public virtual Lpoorder TicketsPurchaseOrder { get; set; }
    }
}
