using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
    public partial class ApprovalMatricesToEmployee
    {
        [Column("EmployeeID")]
        [StringLength(10)]
        public string EmployeeID { get; set; }
        [Column("MatrixID")]
        public Guid MatrixID { get; set; }
        [Column("_RequestTypeIDsJSON")]
        public string RequestTypeIdsJson { get; set; }
        public bool ForCustomRequestTypes { get; set; }

        [ForeignKey("EmployeeId")]
        [InverseProperty("ApprovalMatricesToEmployees")]
        public virtual TbEmployee Employee { get; set; }
        [ForeignKey("MatrixId")]
        [InverseProperty("ApprovalMatricesToEmployees")]
        public virtual TmsapprovalMatrix Matrix { get; set; }
    }
}
