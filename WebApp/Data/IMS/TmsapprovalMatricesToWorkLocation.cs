using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSApprovalMatricesToWorkLocations")]
    public partial class TmsapprovalMatricesToWorkLocation
    {
        [Column("ApprovalMatrix_ID")]
        public Guid ApprovalMatrixID { get; set; }
        [Column("WorkLocation_Code")]
        public short WorkLocationCode { get; set; }

        [ForeignKey("ApprovalMatrixId")]
        [InverseProperty("TmsapprovalMatricesToWorkLocations")]
        public virtual TmsapprovalMatrix ApprovalMatrix { get; set; }
        [ForeignKey("WorkLocationCode")]
        [InverseProperty("TmsapprovalMatricesToWorkLocations")]
        public virtual TbWorkLocation WorkLocationCodeNavigation { get; set; }
    }
}
