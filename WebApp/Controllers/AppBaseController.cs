using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApp.Data;
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
                return _IMSDB ?? (_IMSDB = GetServiceOfType<IMSContext>());
            }
            set
            {
                _IMSDB = value;
            }
        }
        private DBContext _db { get; set; }
        protected DBContext db
        {
            get
            {
                return _db ?? (_db = GetServiceOfType<DBContext>());
            }
            set
            {
                _db = value;
            }
        }

        private IConfiguration _config { get; set; }
        protected IConfiguration config
        {
            get
            {
                return _config ?? (_config = GetServiceOfType<IConfiguration>());
            }
            set
            {
                _config = value;
            }
        }

        private T GetServiceOfType<T>()
        {
            return (T)HttpContext.RequestServices.GetService(typeof(T));
        }
    }
}