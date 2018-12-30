using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Department")]
    public partial class TbDepartment
    {
        public TbDepartment()
        {
            TbEmployees = new HashSet<TbEmployee>();
            TmsapprovalMatricesToDepartments = new HashSet<TmsapprovalMatricesToDepartment>();
        }

        [Key]
        [StringLength(6)]
        public string Code { get; set; }
        [StringLength(60)]
        public string Descr { get; set; }
        [Column("HOD")]
        [StringLength(10)]
        public string Hod { get; set; }

        [InverseProperty("EmpDeptNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
        [InverseProperty("DepartmentCodeNavigation")]
        public virtual ICollection<TmsapprovalMatricesToDepartment> TmsapprovalMatricesToDepartments { get; set; }
    }
}
