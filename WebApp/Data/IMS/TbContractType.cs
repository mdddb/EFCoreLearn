using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_ContractType")]
    public partial class TbContractType
    {
        public TbContractType()
        {
            TbEmployeeEmpContrType2Navigation = new HashSet<TbEmployee>();
            TbEmployeeEmpContrTypeNavigations = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(30)]
        public string Descr { get; set; }
        [StringLength(30)]
        public string DescrLoc { get; set; }
        [StringLength(30)]
        public string DescrKaz { get; set; }

        [InverseProperty("EmpContrType2Navigation")]
        public virtual ICollection<TbEmployee> TbEmployeeEmpContrType2Navigation { get; set; }
        [InverseProperty("EmpContrTypeNavigation")]
        public virtual ICollection<TbEmployee> TbEmployeeEmpContrTypeNavigations { get; set; }
    }
}
