using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSBatchRequestGroups")]
    public partial class TmsbatchRequestGroup
    {
        public TmsbatchRequestGroup()
        {
            TmsbatchRequestGroupsToEmployees = new HashSet<TmsbatchRequestGroupsToEmployee>();
        }

        [Column("ID")]
        public Guid ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty("Group")]
        public virtual ICollection<TmsbatchRequestGroupsToEmployee> TmsbatchRequestGroupsToEmployees { get; set; }
    }
}
