using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data.IMS;

namespace WebApp.Areas.Test.Controllers
{
    [Area(AreaNames.Test)]
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices]IMSContext db)
        {
            return View(db.TbEmployees);
        }
    }
}