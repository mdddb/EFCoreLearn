using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSRequests")]
    public partial class Tmsrequest
    {
        public Tmsrequest()
        {
            Lpoorders = new HashSet<Lpoorder>();
            Tmsapprovals = new HashSet<Tmsapproval>();
        }

        [Column("ID")]
        public Guid ID { get; set; }
        [StringLength(50)]
        public string RefNumber { get; set; }
        public byte Status { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(10)]
        public string EmployeeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime From { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? To { get; set; }
        [Column("TypeID")]
        public short? TypeID { get; set; }
        public string OtherTypeName { get; set; }
        public string Reason { get; set; }
        public bool TransitIsRequired { get; set; }
        [Column("Transit_Destination")]
        public string TransitDestination { get; set; }
        [Column("Transit_Route")]
        public string TransitRoute { get; set; }
        [Column("Transit_TicketDetails")]
        public string TransitTicketDetails { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdateTime { get; set; }
        [Column("LastUpdatedByEmployeeID")]
        [StringLength(10)]
        public string LastUpdatedByEmployeeID { get; set; }
        [Required]
        public string LastUpdatedByUserName { get; set; }
        [Column("MatrixID")]
        public Guid? MatrixID { get; set; }
        public string Notes { get; set; }
        [Column("NotificationInfo_Sent")]
        public bool NotificationInfoSent { get; set; }
        [Column("NotificationInfo__InfoJSON")]
        public string NotificationInfoInfoJson { get; set; }
        [Column("CurrentMatrixStageID")]
        public Guid? CurrentMatrixStageID { get; set; }
        public string CancellationReason { get; set; }
        [Column("_EmployeeHistorizationInfoJSON")]
        public string EmployeeHistorizationInfoJson { get; set; }
        public bool IsReset { get; set; }
        public int Version { get; set; }
        [Column("RepresentativeEmployeeID")]
        [StringLength(10)]
        public string RepresentativeEmployeeID { get; set; }
        [Column("_StageIDsMarkedToBeSkippedJSON")]
        public string StageIdsMarkedToBeSkippedJson { get; set; }

        [ForeignKey("CurrentMatrixStageId")]
        [InverseProperty("Tmsrequests")]
        public virtual TmsapprovalMatricesStage CurrentMatrixStage { get; set; }
        [ForeignKey("EmployeeId")]
        [InverseProperty("TmsrequestEmployees")]
        public virtual TbEmployee Employee { get; set; }
        [ForeignKey("LastUpdatedByEmployeeId")]
        [InverseProperty("TmsrequestLastUpdatedByEmployees")]
        public virtual TbEmployee LastUpdatedByEmployee { get; set; }
        [ForeignKey("MatrixId")]
        [InverseProperty("Tmsrequests")]
        public virtual TmsapprovalMatrix Matrix { get; set; }
        [ForeignKey("RepresentativeEmployeeId")]
        [InverseProperty("TmsrequestRepresentativeEmployees")]
        public virtual TbEmployee RepresentativeEmployee { get; set; }
        [ForeignKey("TypeId")]
        [InverseProperty("Tmsrequests")]
        public virtual TmsrequestType Type { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual TmsleaveRequestsAddData TmsleaveRequestsAddData { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual TmsmissionRequestsAddData TmsmissionRequestsAddData { get; set; }
        [InverseProperty("Tmsrequest")]
        public virtual ICollection<Lpoorder> Lpoorders { get; set; }
        [InverseProperty("Request")]
        public virtual ICollection<Tmsapproval> Tmsapprovals { get; set; }
    }
}
