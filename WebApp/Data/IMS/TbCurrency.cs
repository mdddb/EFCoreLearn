using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Currency")]
    public partial class TbCurrency
    {
        public TbCurrency()
        {
            LpoadditionalServices = new HashSet<LpoadditionalService>();
            LpoflightTickets = new HashSet<LpoflightTicket>();
            Lpoorders = new HashSet<Lpoorder>();
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        [StringLength(3)]
        public string Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }
        [StringLength(5)]
        public string Symbol { get; set; }
        [Column("CCount")]
        public double? Ccount { get; set; }
        public double? Rate { get; set; }

        [InverseProperty("Currency")]
        public virtual ICollection<LpoadditionalService> LpoadditionalServices { get; set; }
        [InverseProperty("Currency")]
        public virtual ICollection<LpoflightTicket> LpoflightTickets { get; set; }
        [InverseProperty("Currency")]
        public virtual ICollection<Lpoorder> Lpoorders { get; set; }
        [InverseProperty("EmpCurrNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
