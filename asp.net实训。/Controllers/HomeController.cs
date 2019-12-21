using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net实训_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult login()
        {
            return View();
        }
        public ActionResult exit()
        {
            Response.Cookies["email"].Value= null;
            return RedirectToAction("login");
        }
    }
}