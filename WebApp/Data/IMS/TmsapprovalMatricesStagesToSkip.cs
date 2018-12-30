using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSApprovalMatricesStagesToSkip")]
    public partial class TmsapprovalMatricesStagesToSkip
    {
        [Column("StageID")]
        public Guid StageID { get; set; }
        [Column("RequestTypeID")]
        public short RequestTypeID { get; set; }

        [ForeignKey("RequestTypeId")]
        [InverseProperty("TmsapprovalMatricesStagesToSkips")]
        public virtual TmsrequestType RequestType { get; set; }
        [ForeignKey("StageId")]
        [InverseProperty("TmsapprovalMatricesStagesToSkips")]
        public virtual TmsapprovalMatricesStage Stage { get; set; }
    }
}
