using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSMissionRequestsAddData")]
    public partial class TmsmissionRequestsAddData
    {
        [Column("ID")]
        public Guid ID { get; set; }
        [Column("ProjectToChargeID")]
        [StringLength(10)]
        public string ProjectToChargeID { get; set; }
        public string MissionDestination { get; set; }
        public string TransportationMeans { get; set; }
        public string AccomodationDetails { get; set; }
        [Column("Phone_Needed")]
        public bool PhoneNeeded { get; set; }
        [Column("Phone_RoamingNeeded")]
        public bool PhoneRoamingNeeded { get; set; }
        [Column("Phone_Number")]
        public string PhoneNumber { get; set; }
        public string CarRentalDetails { get; set; }
        [Column("_AdvancePaymentsJSON")]
        public string AdvancePaymentsJson { get; set; }
        public string ProjectToChargeName { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("TmsmissionRequestsAddData")]
        public virtual Tmsrequest IdNavigation { get; set; }
        [ForeignKey("ProjectToChargeId")]
        [InverseProperty("TmsmissionRequestsAddData")]
        public virtual TbProject ProjectToCharge { get; set; }
    }
}
