using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("LPOAdditionalServices")]
    public partial class LpoadditionalService
    {
        [Column("ID")]
        public Guid ID { get; set; }
        [Column("OrderID")]
        public Guid OrderID { get; set; }
        [Column("TypeID")]
        public byte TypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public decimal? Price { get; set; }
        [Column("CurrencyID")]
        [StringLength(3)]
        public string CurrencyID { get; set; }

        [ForeignKey("CurrencyId")]
        [InverseProperty("LpoadditionalServices")]
        public virtual TbCurrency Currency { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("LpoadditionalServices")]
        public virtual Lpoorder Order { get; set; }
        [ForeignKey("TypeId")]
        [InverseProperty("LpoadditionalServices")]
        public virtual LpoadditionalServiceType Type { get; set; }
    }
}
