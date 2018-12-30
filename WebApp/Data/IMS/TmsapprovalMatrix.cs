using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSApprovalMatrices")]
    public partial class TmsapprovalMatrix
    {
        public TmsapprovalMatrix()
        {
            ApprovalMatricesToEmployees = new HashSet<ApprovalMatricesToEmployee>();
            TmsapprovalMatricesStages = new HashSet<TmsapprovalMatricesStage>();
            TmsapprovalMatricesToBusinessUnits = new HashSet<TmsapprovalMatricesToBusinessUnit>();
            TmsapprovalMatricesToDepartments = new HashSet<TmsapprovalMatricesToDepartment>();
            TmsapprovalMatricesToIntermediateSupervisors = new HashSet<TmsapprovalMatricesToIntermediateSupervisor>();
            TmsapprovalMatricesToRequestTypes = new HashSet<TmsapprovalMatricesToRequestType>();
            TmsapprovalMatricesToSupervisors = new HashSet<TmsapprovalMatricesToSupervisor>();
            TmsapprovalMatricesToWorkLocations = new HashSet<TmsapprovalMatricesToWorkLocation>();
            Tmsrequests = new HashSet<Tmsrequest>();
        }

        [Column("ID")]
        public Guid ID { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public short? Priority { get; set; }
        public bool IsRemoved { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdateTime { get; set; }
        [StringLength(10)]
        public string LastUpdatedByBadge { get; set; }
        public string LastUpdatedByUsername { get; set; }
        public bool ForCustomRequestTypes { get; set; }

        [ForeignKey("LastUpdatedByBadge")]
        [InverseProperty("TmsapprovalMatrices")]
        public virtual TbEmployee LastUpdatedByBadgeNavigation { get; set; }
        [InverseProperty("Matrix")]
        public virtual ICollection<ApprovalMatricesToEmployee> ApprovalMatricesToEmployees { get; set; }
        [InverseProperty("Matrix")]
        public virtual ICollection<TmsapprovalMatricesStage> TmsapprovalMatricesStages { get; set; }
        [InverseProperty("ApprovalMatrix")]
        public virtual ICollection<TmsapprovalMatricesToBusinessUnit> TmsapprovalMatricesToBusinessUnits { get; set; }
        [InverseProperty("ApprovalMatrix")]
        public virtual ICollection<TmsapprovalMatricesToDepartment> TmsapprovalMatricesToDepartments { get; set; }
        [InverseProperty("ApprovalMatrix")]
        public virtual ICollection<TmsapprovalMatricesToIntermediateSupervisor> TmsapprovalMatricesToIntermediateSupervisors { get; set; }
        [InverseProperty("ApprovalMatrix")]
        public virtual ICollection<TmsapprovalMatricesToRequestType> TmsapprovalMatricesToRequestTypes { get; set; }
        [InverseProperty("ApprovalMatrix")]
        public virtual ICollection<TmsapprovalMatricesToSupervisor> TmsapprovalMatricesToSupervisors { get; set; }
        [InverseProperty("ApprovalMatrix")]
        public virtual ICollection<TmsapprovalMatricesToWorkLocation> TmsapprovalMatricesToWorkLocations { get; set; }
        [InverseProperty("Matrix")]
        public virtual ICollection<Tmsrequest> Tmsrequests { get; set; }
    }
}
