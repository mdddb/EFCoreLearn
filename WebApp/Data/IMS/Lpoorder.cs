using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPOOrders")]
    public partial class Lpoorder
    {
        public Lpoorder()
        {
            LpoadditionalServices = new HashSet<LpoadditionalService>();
            LpoflightTickets = new HashSet<LpoflightTicket>();
            Lpopassengers = new HashSet<Lpopassenger>();
        }

        [Column("ID")]
        public Guid ID { get; set; }
        [Column("TypeID")]
        public short TypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Number { get; set; }
        public short? NumberOfTickets { get; set; }
        public string Notes { get; set; }
        public decimal? TotalPrice { get; set; }
        [Column("CurrencyID")]
        [StringLength(3)]
        public string CurrencyID { get; set; }
        [Column("AuthorizerID")]
        public short? AuthorizerID { get; set; }
        [Column("PurposeID")]
        public short? PurposeID { get; set; }
        [Column("AgencyID")]
        public short? AgencyID { get; set; }
        [Column("AreaID")]
        public short? AreaID { get; set; }
        [Column("AccountToChargeID")]
        public short? AccountToChargeID { get; set; }
        [Column("ContactPersonID")]
        public short? ContactPersonID { get; set; }
        [Column("EmployeeID")]
        [StringLength(10)]
        public string EmployeeID { get; set; }
        [Column("EmployeeInfoJSON")]
        public string EmployeeInfoJson { get; set; }
        [Column("LastUpdateByID")]
        [StringLength(10)]
        public string LastUpdateByID { get; set; }
        [Required]
        public string LastUpdateByUsername { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdateTime { get; set; }
        [Column("TMSRequestID")]
        public Guid? TmsrequestID { get; set; }
        public byte Version { get; set; }
        [Required]
        public string CostCenterOrJobCodeToCharge { get; set; }

        [ForeignKey("AccountToChargeId")]
        [InverseProperty("Lpoorders")]
        public virtual LpoaccountsToCharge AccountToCharge { get; set; }
        [ForeignKey("AgencyId")]
        [InverseProperty("Lpoorders")]
        public virtual Lpoagency Agency { get; set; }
        [ForeignKey("AreaId")]
        [InverseProperty("Lpoorders")]
        public virtual LpoticketArea Area { get; set; }
        [ForeignKey("AuthorizerId")]
        [InverseProperty("Lpoorders")]
        public virtual Lpoauthorizer Authorizer { get; set; }
        [ForeignKey("ContactPersonId")]
        [InverseProperty("Lpoorders")]
        public virtual LpocontactPerson ContactPerson { get; set; }
        [ForeignKey("CurrencyId")]
        [InverseProperty("Lpoorders")]
        public virtual TbCurrency Currency { get; set; }
        [ForeignKey("EmployeeId")]
        [InverseProperty("LpoorderEmployees")]
        public virtual TbEmployee Employee { get; set; }
        [ForeignKey("LastUpdateById")]
        [InverseProperty("LpoorderLastUpdateBies")]
        public virtual TbEmployee LastUpdateBy { get; set; }
        [ForeignKey("PurposeId")]
        [InverseProperty("Lpoorders")]
        public virtual Lpopurpos Purpose { get; set; }
        [ForeignKey("TmsrequestId")]
        [InverseProperty("Lpoorders")]
        public virtual Tmsrequest Tmsrequest { get; set; }
        [ForeignKey("TypeId")]
        [InverseProperty("Lpoorders")]
        public virtual LpoorderType Type { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<LpoadditionalService> LpoadditionalServices { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<LpoflightTicket> LpoflightTickets { get; set; }
        [InverseProperty("TicketsPurchaseOrder")]
        public virtual ICollection<Lpopassenger> Lpopassengers { get; set; }
    }
}
