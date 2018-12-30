using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Nationality")]
    public partial class TbNationality
    {
        public TbNationality()
        {
            TbEmployeeEmpCountryLocNavigations = new HashSet<TbEmployee>();
            TbEmployeeEmpCountryNavigations = new HashSet<TbEmployee>();
            TbEmployeeEmpNatNavigations = new HashSet<TbEmployee>();
        }

        [Key]
        [StringLength(3)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Descr { get; set; }
        [StringLength(30)]
        public string DescrLoc { get; set; }
        [StringLength(50)]
        public string Alias { get; set; }
        public short? NatGroup { get; set; }
        [Column("SIDAC")]
        [StringLength(5)]
        public string Sidac { get; set; }
        [Column("BCClass")]
        [StringLength(10)]
        public string Bcclass { get; set; }
        [Column("BFClass")]
        [StringLength(10)]
        public string Bfclass { get; set; }
        [Column("WCClass")]
        [StringLength(10)]
        public string Wcclass { get; set; }
        [Column("MMClass")]
        [StringLength(10)]
        public string Mmclass { get; set; }
        [Column("GHRS_Mapping_Code")]
        [StringLength(10)]
        public string GhrsMappingCode { get; set; }

        [ForeignKey("NatGroup")]
        [InverseProperty("TbNationalities")]
        public virtual TbNatGroup NatGroupNavigation { get; set; }
        [InverseProperty("EmpCountryLocNavigation")]
        public virtual ICollection<TbEmployee> TbEmployeeEmpCountryLocNavigations { get; set; }
        [InverseProperty("EmpCountryNavigation")]
        public virtual ICollection<TbEmployee> TbEmployeeEmpCountryNavigations { get; set; }
        [InverseProperty("EmpNatNavigation")]
        public virtual ICollection<TbEmployee> TbEmployeeEmpNatNavigations { get; set; }
    }
}
