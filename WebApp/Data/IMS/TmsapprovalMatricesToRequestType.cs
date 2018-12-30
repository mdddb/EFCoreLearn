using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSApprovalMatricesToRequestTypes")]
    public partial class TmsapprovalMatricesToRequestType
    {
        [Column("ApprovalMatrix_ID")]
        public Guid ApprovalMatrixID { get; set; }
        [Column("TMSRequestType_ID")]
        public short TmsrequestTypeID { get; set; }

        [ForeignKey("ApprovalMatrixId")]
        [InverseProperty("TmsapprovalMatricesToRequestTypes")]
        public virtual TmsapprovalMatrix ApprovalMatrix { get; set; }
        [ForeignKey("TmsrequestTypeId")]
        [InverseProperty("TmsapprovalMatricesToRequestTypes")]
        public virtual TmsrequestType TmsrequestType { get; set; }
    }
}
