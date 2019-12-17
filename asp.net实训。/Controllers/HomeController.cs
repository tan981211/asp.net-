using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net实训_.Controllers
{
    //控制器可删除
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult repairUser()
        {
            return View();
        }
        public ActionResult CompalinUser()
        {
            return View();
        }
       public ActionResult repairAdmin()
        {
            return View();
        }
        public ActionResult compailnAdmin()
        {
            return View();
        }
    }
}