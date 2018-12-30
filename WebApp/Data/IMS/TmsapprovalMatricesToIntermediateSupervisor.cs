using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSApprovalMatricesToIntermediateSupervisors")]
    public partial class TmsapprovalMatricesToIntermediateSupervisor
    {
        [Column("ApprovalMatrix_ID")]
        public Guid ApprovalMatrixID { get; set; }
        [Column("Employee_BadgeNumber")]
        [StringLength(10)]
        public string EmployeeBadgeNumber { get; set; }

        [ForeignKey("ApprovalMatrixId")]
        [InverseProperty("TmsapprovalMatricesToIntermediateSupervisors")]
        public virtual TmsapprovalMatrix ApprovalMatrix { get; set; }
        [ForeignKey("EmployeeBadgeNumber")]
        [InverseProperty("TmsapprovalMatricesToIntermediateSupervisors")]
        public virtual TbEmployee EmployeeBadgeNumberNavigation { get; set; }
    }
}
