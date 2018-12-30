using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSApprovalMatricesToBusinessUnits")]
    public partial class TmsapprovalMatricesToBusinessUnit
    {
        [Column("ApprovalMatrix_ID")]
        public Guid ApprovalMatrixID { get; set; }
        [Column("BusinessUnit_Code")]
        [StringLength(6)]
        public string BusinessUnitCode { get; set; }

        [ForeignKey("ApprovalMatrixId")]
        [InverseProperty("TmsapprovalMatricesToBusinessUnits")]
        public virtual TmsapprovalMatrix ApprovalMatrix { get; set; }
        [ForeignKey("BusinessUnitCode")]
        [InverseProperty("TmsapprovalMatricesToBusinessUnits")]
        public virtual TbBussUnit BusinessUnitCodeNavigation { get; set; }
    }
}
