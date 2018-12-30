using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSBatchRequestGroupsToEmployees")]
    public partial class TmsbatchRequestGroupsToEmployee
    {
        [Column("GroupID")]
        public Guid GroupID { get; set; }
        [Column("EmployeeID")]
        [StringLength(10)]
        public string EmployeeID { get; set; }
        public bool TransitIsRequired { get; set; }
        public string TransitDestination { get; set; }

        [ForeignKey("EmployeeId")]
        [InverseProperty("TmsbatchRequestGroupsToEmployees")]
        public virtual TbEmployee Employee { get; set; }
        [ForeignKey("GroupId")]
        [InverseProperty("TmsbatchRequestGroupsToEmployees")]
        public virtual TmsbatchRequestGroup Group { get; set; }
    }
}
