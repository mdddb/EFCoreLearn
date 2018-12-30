using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_EducationLevel")]
    public partial class TbEducationLevel
    {
        public TbEducationLevel()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public short Code { get; set; }
        [StringLength(30)]
        public string Descr { get; set; }
        [Column("GHRS_Mapping_Code")]
        [StringLength(10)]
        public string GhrsMappingCode { get; set; }

        [InverseProperty("EmpEduLevelNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
