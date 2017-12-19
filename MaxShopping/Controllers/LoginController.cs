using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingSite.Models;

namespace ShoppingSite.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login l)
        {
            return View();
        }

        public bool Checklogin()
        {
            bool chkLogin = false;
            
            return chkLogin;
        }
	}
}