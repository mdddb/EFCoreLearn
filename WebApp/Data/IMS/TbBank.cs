using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Bank")]
    public partial class TbBank
    {
        public TbBank()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(80)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [Column("SWIFT")]
        [StringLength(20)]
        public string Swift { get; set; }
        [StringLength(20)]
        public string BankCode { get; set; }
        [StringLength(20)]
        public string BranchCode { get; set; }

        [InverseProperty("EmpBankNameNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
