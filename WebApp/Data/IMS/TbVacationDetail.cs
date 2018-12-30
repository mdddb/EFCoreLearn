using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_VacationDetail")]
    public partial class TbVacationDetail
    {
        [StringLength(10)]
        public string EmpBadge { get; set; }
        [Column(TypeName = "date")]
        public DateTime? RequestedDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? RequestedRetDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SiteTravelDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? IntlTravelDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? OriginTravelDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SiteArrivalDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PaidFromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PaidToDate { get; set; }
        [StringLength(10)]
        public string OrderNo { get; set; }
        public short VacType { get; set; }
        [StringLength(30)]
        public string Destination { get; set; }
        [StringLength(50)]
        public string Remarks { get; set; }
        [Column("ID")]
        public Guid ID { get; set; }
    }
}
