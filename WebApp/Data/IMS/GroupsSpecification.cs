using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
    public partial class GroupsSpecification
    {
        public GroupsSpecification()
        {
            GroupsFlexibleMembersLists = new HashSet<GroupsFlexibleMembersList>();
            TimeSheetsToEmployees = new HashSet<TimeSheetsToEmployee>();
        }

        [Key]
        [Column("GroupUID")]
        public Guid GroupUid { get; set; }
        [Required]
        [StringLength(10)]
        public string GroupCode { get; set; }
        public string GroupDescription { get; set; }
        [StringLength(10)]
        public string GroupHeadEmployeeBadgeNumber { get; set; }
        [StringLength(10)]
        public string GroupSupervisorEmployeeBadgeNumber { get; set; }
        [StringLength(10)]
        public string GroupTimeKeeperEmployeeBadgeNumber { get; set; }
        [StringLength(10)]
        public string GroupCostControlEmployeeBadgeNumber { get; set; }
        [Column("GroupHeadB2BEmployeeBadgeNumber")]
        [StringLength(10)]
        public string GroupHeadB2bemployeeBadgeNumber { get; set; }
        [Column("GroupSupervisorB2BEmployeeBadgeNumber")]
        [StringLength(10)]
        public string GroupSupervisorB2bemployeeBadgeNumber { get; set; }
        [Column("GroupTimeKeeperB2BEmployeeBadgeNumber")]
        [StringLength(10)]
        public string GroupTimeKeeperB2bemployeeBadgeNumber { get; set; }
        [Column("GroupCostControlB2BEmployeeBadgeNumber")]
        [StringLength(10)]
        public string GroupCostControlB2bemployeeBadgeNumber { get; set; }
        public string Comment { get; set; }
        [Column("GroupDefaultJobCodeID")]
        [StringLength(10)]
        public string GroupDefaultJobCodeID { get; set; }
        [Column("GroupDefaultWBSID")]
        public Guid? GroupDefaultWbsid { get; set; }
        [Column("GroupDefaultTRCID")]
        [StringLength(10)]
        public string GroupDefaultTrcid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdateTime { get; set; }
        [StringLength(10)]
        public string LastUpdatedByBadge { get; set; }
        public string LastUpdatedByUsername { get; set; }
        public bool IsRemoved { get; set; }
        public string GroupName { get; set; }

        [ForeignKey("GroupCostControlB2bemployeeBadgeNumber")]
        [InverseProperty("GroupsSpecificationGroupCostControlB2bemployeeBadgeNumberNavigation")]
        public virtual TbEmployee GroupCostControlB2bemployeeBadgeNumberNavigation { get; set; }
        [ForeignKey("GroupCostControlEmployeeBadgeNumber")]
        [InverseProperty("GroupsSpecificationGroupCostControlEmployeeBadgeNumberNavigations")]
        public virtual TbEmployee GroupCostControlEmployeeBadgeNumberNavigation { get; set; }
        [ForeignKey("GroupDefaultJobCodeId")]
        [InverseProperty("GroupsSpecifications")]
        public virtual TbJobCode GroupDefaultJobCode { get; set; }
        [ForeignKey("GroupDefaultTrcid")]
        [InverseProperty("GroupsSpecifications")]
        public virtual TbTrc GroupDefaultTrc { get; set; }
        [ForeignKey("GroupDefaultWbsid")]
        [InverseProperty("GroupsSpecifications")]
        public virtual TbWb GroupDefaultWbs { get; set; }
        [ForeignKey("GroupHeadB2bemployeeBadgeNumber")]
        [InverseProperty("GroupsSpecificationGroupHeadB2bemployeeBadgeNumberNavigation")]
        public virtual TbEmployee GroupHeadB2bemployeeBadgeNumberNavigation { get; set; }
        [ForeignKey("GroupHeadEmployeeBadgeNumber")]
        [InverseProperty("GroupsSpecificationGroupHeadEmployeeBadgeNumberNavigations")]
        public virtual TbEmployee GroupHeadEmployeeBadgeNumberNavigation { get; set; }
        [ForeignKey("GroupSupervisorB2bemployeeBadgeNumber")]
        [InverseProperty("GroupsSpecificationGroupSupervisorB2bemployeeBadgeNumberNavigation")]
        public virtual TbEmployee GroupSupervisorB2bemployeeBadgeNumberNavigation { get; set; }
        [ForeignKey("GroupSupervisorEmployeeBadgeNumber")]
        [InverseProperty("GroupsSpecificationGroupSupervisorEmployeeBadgeNumberNavigations")]
        public virtual TbEmployee GroupSupervisorEmployeeBadgeNumberNavigation { get; set; }
        [ForeignKey("GroupTimeKeeperB2bemployeeBadgeNumber")]
        [InverseProperty("GroupsSpecificationGroupTimeKeeperB2bemployeeBadgeNumberNavigation")]
        public virtual TbEmployee GroupTimeKeeperB2bemployeeBadgeNumberNavigation { get; set; }
        [ForeignKey("GroupTimeKeeperEmployeeBadgeNumber")]
        [InverseProperty("GroupsSpecificationGroupTimeKeeperEmployeeBadgeNumberNavigations")]
        public virtual TbEmployee GroupTimeKeeperEmployeeBadgeNumberNavigation { get; set; }
        [ForeignKey("LastUpdatedByBadge")]
        [InverseProperty("GroupsSpecificationLastUpdatedByBadgeNavigations")]
        public virtual TbEmployee LastUpdatedByBadgeNavigation { get; set; }
        [InverseProperty("GroupsSpecificationsU")]
        public virtual ICollection<GroupsFlexibleMembersList> GroupsFlexibleMembersLists { get; set; }
        [InverseProperty("GroupU")]
        public virtual ICollection<TimeSheetsToEmployee> TimeSheetsToEmployees { get; set; }
    }
}
