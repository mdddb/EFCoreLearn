using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPOFlightTickets")]
    public partial class LpoflightTicket
    {
        [Column("ID")]
        public Guid ID { get; set; }
        [Required]
        public string Number { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FlightTime { get; set; }
        [StringLength(30)]
        public string DepartureAirportCode { get; set; }
        [StringLength(30)]
        public string ArrivalAirportCode { get; set; }
        [Column("ClassID")]
        public byte ClassID { get; set; }
        public string Airline { get; set; }
        public decimal? Price { get; set; }
        [Column("CurrencyID")]
        [StringLength(3)]
        public string CurrencyID { get; set; }
        [Column("OrderID")]
        public Guid OrderID { get; set; }

        [ForeignKey("ClassId")]
        [InverseProperty("LpoflightTickets")]
        public virtual LpoflightTicketClass Class { get; set; }
        [ForeignKey("CurrencyId")]
        [InverseProperty("LpoflightTickets")]
        public virtual TbCurrency Currency { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("LpoflightTickets")]
        public virtual Lpoorder Order { get; set; }
    }
}
