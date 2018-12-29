using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.HRMS;

namespace WebApp.Data.Identity
{
    public class User : IdentityUser<string>
    {
        public User() : base() { }
        public User(string userName) : base(userName) { }


        [ForeignKey(nameof(LinkedEmployee))]
        public Guid? EmployeeID { get; set; }
        public virtual Employee LinkedEmployee { get; set; }
    }
}