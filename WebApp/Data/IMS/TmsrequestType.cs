using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("TMSRequestTypes")]
    public partial class TmsrequestType
    {
        public TmsrequestType()
        {
            TmsapprovalMatricesStagesToSkips = new HashSet<TmsapprovalMatricesStagesToSkip>();
            TmsapprovalMatricesToRequestTypes = new HashSet<TmsapprovalMatricesToRequestType>();
            Tmsrequests = new HashSet<Tmsrequest>();
        }

        [Column("ID")]
        public short ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string NameRu { get; set; }
        public byte Type { get; set; }
        [Column("_FormDataJSON")]
        public string FormDataJson { get; set; }
        public string PrefixForRefNumbers { get; set; }
        public bool ForBatchCreation { get; set; }
        public string EmployeeCategory { get; set; }
        public int? Order { get; set; }
        public bool? IsNotActive { get; set; }

        [InverseProperty("RequestType")]
        public virtual ICollection<TmsapprovalMatricesStagesToSkip> TmsapprovalMatricesStagesToSkips { get; set; }
        [InverseProperty("TmsrequestType")]
        public virtual ICollection<TmsapprovalMatricesToRequestType> TmsapprovalMatricesToRequestTypes { get; set; }
        [InverseProperty("Type")]
        public virtual ICollection<Tmsrequest> Tmsrequests { get; set; }
    }
}
