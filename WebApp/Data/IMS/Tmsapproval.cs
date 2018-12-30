using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSApprovals")]
    public partial class Tmsapproval
    {
        [Column("ApproverID")]
        [StringLength(10)]
        public string ApproverID { get; set; }
        [Column("RequestID")]
        public Guid RequestID { get; set; }
        public bool Status { get; set; }
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Time { get; set; }
        public byte Level { get; set; }
        [Column("MatrixStageID")]
        public Guid? MatrixStageID { get; set; }
        [Column("MatrixStageInfo_Name")]
        public string MatrixStageInfoName { get; set; }
        [Column("MatrixStageInfo_ActionName")]
        public string MatrixStageInfoActionName { get; set; }
        [Column("NotificationInfo_Sent")]
        public bool NotificationInfoSent { get; set; }
        [Column("NotificationInfo__InfoJSON")]
        public string NotificationInfoInfoJson { get; set; }
        [Column("ApproverInfo_BadgeNumber")]
        public string ApproverInfoBadgeNumber { get; set; }
        [Column("ApproverInfo_FullName")]
        public string ApproverInfoFullName { get; set; }
        [Column("OnBehalfOfApproverID")]
        [StringLength(10)]
        public string OnBehalfOfApproverID { get; set; }
        [Column("OnBehalfOfApproverInfo_BadgeNumber")]
        public string OnBehalfOfApproverInfoBadgeNumber { get; set; }
        [Column("OnBehalfOfApproverInfo_FullName")]
        public string OnBehalfOfApproverInfoFullName { get; set; }
        public bool IsAcknowledgement { get; set; }
        public int RequestVersion { get; set; }

        [ForeignKey("ApproverId")]
        [InverseProperty("TmsapprovalApprovers")]
        public virtual TbEmployee Approver { get; set; }
        [ForeignKey("MatrixStageId")]
        [InverseProperty("Tmsapprovals")]
        public virtual TmsapprovalMatricesStage MatrixStage { get; set; }
        [ForeignKey("OnBehalfOfApproverId")]
        [InverseProperty("TmsapprovalOnBehalfOfApprovers")]
        public virtual TbEmployee OnBehalfOfApprover { get; set; }
        [ForeignKey("RequestId")]
        [InverseProperty("Tmsapprovals")]
        public virtual Tmsrequest Request { get; set; }
    }
}
