using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingSite.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration/
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
	}
}