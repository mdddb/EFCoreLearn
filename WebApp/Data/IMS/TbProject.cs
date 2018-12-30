using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Project")]
    public partial class TbProject
    {
        public TbProject()
        {
            TbEmployees = new HashSet<TbEmployee>();
            TmsmissionRequestsAddData = new HashSet<TmsmissionRequestsAddData>();
        }

        [Key]
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(100)]
        public string Descr { get; set; }
        [StringLength(100)]
        public string DescrLoc { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [StringLength(10)]
        public string Manager { get; set; }
        [StringLength(6)]
        public string BussUnit { get; set; }

        [ForeignKey("BussUnit")]
        [InverseProperty("TbProjects")]
        public virtual TbBussUnit BussUnitNavigation { get; set; }
        [InverseProperty("EmpProjNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
        [InverseProperty("ProjectToCharge")]
        public virtual ICollection<TmsmissionRequestsAddData> TmsmissionRequestsAddData { get; set; }
    }
}
