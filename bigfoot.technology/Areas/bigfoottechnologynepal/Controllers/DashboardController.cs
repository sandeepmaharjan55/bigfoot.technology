using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bigfoot.technology.Areas.bigfoottechnologynepal.Controllers
{
    public class DashboardController : AdminController
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}