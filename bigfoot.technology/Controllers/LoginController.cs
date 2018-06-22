﻿using bigfoot.technology.Models;
using bigfoot.technology.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace bigfoot.technology.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
       
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginViewModel lvm,string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(lvm.UserName, lvm.Password))
                {
                    FormsAuthentication.SetAuthCookie(lvm.UserName ,true);
                    if (ReturnUrl != null)
                    {
                        return Redirect(ReturnUrl);
                    }
                    else if (ReturnUrl == null && lvm.UserName=="admin")
                    { return Redirect("~/bigfoottechnologynepal/Dashboard"); }
                    else
                    { 
                        return Redirect("~/Home/Index");
                }




            }

            }
            return View(lvm);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Login");

        }
    }
}