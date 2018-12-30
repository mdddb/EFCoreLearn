using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("GroupsFlexibleMembersList")]
    public partial class GroupsFlexibleMembersList
    {
        [Column("GroupsSpecificationsUID")]
        public Guid GroupsSpecificationsUid { get; set; }
        [StringLength(10)]
        public string EmployeeBadgeNumber { get; set; }

        [ForeignKey("EmployeeBadgeNumber")]
        [InverseProperty("GroupsFlexibleMembersLists")]
        public virtual TbEmployee EmployeeBadgeNumberNavigation { get; set; }
        [ForeignKey("GroupsSpecificationsUid")]
        [InverseProperty("GroupsFlexibleMembersLists")]
        public virtual GroupsSpecification GroupsSpecificationsU { get; set; }
    }
}
