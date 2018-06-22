using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bigfoot.technology.Areas.bigfoottechnologynepal.Controllers
{
    [Authorize(Roles ="Admin,User")]
    public class AdminController:Controller
    {
    }
}