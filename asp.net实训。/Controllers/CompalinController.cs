using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net实训_.Controllers
{
    //业主投诉
    //管理投诉
    public class CompalinController : Controller
    {
        // GET: Compalin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult compalinUser()
        {
            return View();
        }
        public ActionResult compalinAdmin()
        {
            return View();
        }
    }
}