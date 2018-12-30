using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSApprovalMatricesStages")]
    public partial class TmsapprovalMatricesStage
    {
        public TmsapprovalMatricesStage()
        {
            TmsapprovalMatricesStagesToSkips = new HashSet<TmsapprovalMatricesStagesToSkip>();
            TmsapprovalMatrixStagesToApprovers = new HashSet<TmsapprovalMatrixStagesToApprover>();
            Tmsapprovals = new HashSet<Tmsapproval>();
            Tmsrequests = new HashSet<Tmsrequest>();
        }

        [Column("ID")]
        public Guid ID { get; set; }
        [Column("MatrixID")]
        public Guid MatrixID { get; set; }
        public byte Level { get; set; }
        public string Name { get; set; }
        public bool IsRemoved { get; set; }
        public string ActionName { get; set; }
        public bool CanChangeAndResetRequests { get; set; }
        public string MailAddressesToNotifyAfter { get; set; }
        public bool IsForAcknowledgement { get; set; }
        public bool CanChangeWithoutReset { get; set; }
        public bool NotifyEvenIfSkipped { get; set; }

        [ForeignKey("MatrixId")]
        [InverseProperty("TmsapprovalMatricesStages")]
        public virtual TmsapprovalMatrix Matrix { get; set; }
        [InverseProperty("Stage")]
        public virtual ICollection<TmsapprovalMatricesStagesToSkip> TmsapprovalMatricesStagesToSkips { get; set; }
        [InverseProperty("ApprovalMatrixStage")]
        public virtual ICollection<TmsapprovalMatrixStagesToApprover> TmsapprovalMatrixStagesToApprovers { get; set; }
        [InverseProperty("MatrixStage")]
        public virtual ICollection<Tmsapproval> Tmsapprovals { get; set; }
        [InverseProperty("CurrentMatrixStage")]
        public virtual ICollection<Tmsrequest> Tmsrequests { get; set; }
    }
}
