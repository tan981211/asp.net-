using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net实训_.Controllers
{
    //业主收费
    //管理收费
    public class ChargeController : Controller
    {
        // GET: Charge
        public string Index()
        {
            return "张跃制作的ChargeController";
        }
        public ActionResult chargeUser()//业主收费页
        {

            return View();
        }
        public ActionResult chargeAdmin()//管理收费页
        {
            return View();
        }
    }
}