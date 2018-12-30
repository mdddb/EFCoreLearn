using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSApprovalMatrixStagesToApprovers")]
    public partial class TmsapprovalMatrixStagesToApprover
    {
        [Column("ApprovalMatrixStage_ID")]
        public Guid ApprovalMatrixStageID { get; set; }
        [Column("Employee_BadgeNumber")]
        [StringLength(10)]
        public string EmployeeBadgeNumber { get; set; }
        public bool IsMainApprover { get; set; }

        [ForeignKey("ApprovalMatrixStageId")]
        [InverseProperty("TmsapprovalMatrixStagesToApprovers")]
        public virtual TmsapprovalMatricesStage ApprovalMatrixStage { get; set; }
        [ForeignKey("EmployeeBadgeNumber")]
        [InverseProperty("TmsapprovalMatrixStagesToApprovers")]
        public virtual TbEmployee EmployeeBadgeNumberNavigation { get; set; }
    }
}
