using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : AppBaseController
    {
        [HttpGet("Get")]
        public object Get()
        {
            IMSDB.ChangeTracker.LazyLoadingEnabled = false;
            //return db.Users.First();
            return IMSDB.TbEmployees.Include(e => e.TmsrequestEmployees).First(e => e.TmsrequestEmployees.Any());
        }
    }
}