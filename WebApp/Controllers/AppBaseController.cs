using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data.IMS;

namespace WebApp
{
    public abstract class AppBaseController : Controller
    {
        private IMSContext _IMSDB { get; set; }
        protected IMSContext IMSDB
        {
            get
            {
                return _IMSDB ?? (_IMSDB = (IMSContext)HttpContext.RequestServices.GetService(typeof(IMSContext)));
            }
            set
            {
                _IMSDB = value;
            }
        }
    }
}