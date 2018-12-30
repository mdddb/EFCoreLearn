using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSLeaveRequestsAddData")]
    public partial class TmsleaveRequestsAddData
    {
        [Column("ID")]
        public Guid ID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartOfWork { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("TmsleaveRequestsAddData")]
        public virtual Tmsrequest IdNavigation { get; set; }
    }
}
