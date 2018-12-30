using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSApprovalMatricesToDepartments")]
    public partial class TmsapprovalMatricesToDepartment
    {
        [Column("ApprovalMatrix_ID")]
        public Guid ApprovalMatrixID { get; set; }
        [Column("Department_Code")]
        [StringLength(6)]
        public string DepartmentCode { get; set; }

        [ForeignKey("ApprovalMatrixId")]
        [InverseProperty("TmsapprovalMatricesToDepartments")]
        public virtual TmsapprovalMatrix ApprovalMatrix { get; set; }
        [ForeignKey("DepartmentCode")]
        [InverseProperty("TmsapprovalMatricesToDepartments")]
        public virtual TbDepartment DepartmentCodeNavigation { get; set; }
    }
}
