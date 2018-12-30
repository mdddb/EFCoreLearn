using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
    public partial class EmployeesToRepresentative
    {
        [Column("EmployeeID")]
        [StringLength(10)]
        public string EmployeeID { get; set; }
        [Column("RepresentativeEmployeeID")]
        [StringLength(10)]
        public string RepresentativeEmployeeID { get; set; }
        [Column("CanCreateTMSRequests")]
        public bool CanCreateTmsrequests { get; set; }
        public bool CanApproveVacancyApplications { get; set; }
        public string AssignedByUsername { get; set; }

        [ForeignKey("EmployeeId")]
        [InverseProperty("EmployeesToRepresentativeEmployees")]
        public virtual TbEmployee Employee { get; set; }
        [ForeignKey("RepresentativeEmployeeId")]
        [InverseProperty("EmployeesToRepresentativeRepresentativeEmployees")]
        public virtual TbEmployee RepresentativeEmployee { get; set; }
    }
}
