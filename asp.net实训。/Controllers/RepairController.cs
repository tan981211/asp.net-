using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net实训_.Controllers
{
    //业主报修
    //管理维修
    public class RepairController : Controller
    {
        // GET: Repair
      
        public ActionResult repairUser()
        {
            return View();
        }
        public ActionResult repairAdmin()
        {
            return View();
        }
    }
}