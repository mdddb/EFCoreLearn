using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_TicketType")]
    public partial class TbTicketType
    {
        public TbTicketType()
        {
            LpoflightTicketClasses = new HashSet<LpoflightTicketClass>();
            TbEmployees = new HashSet<TbEmployee>();
        }

        [Key]
        public byte Code { get; set; }
        [StringLength(20)]
        public string Descr { get; set; }

        [InverseProperty("HrmsticketType")]
        public virtual ICollection<LpoflightTicketClass> LpoflightTicketClasses { get; set; }
        [InverseProperty("EmpTicketNavigation")]
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
