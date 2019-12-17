using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net实训_.Controllers
{

    //登录页
    //业主首页
    //管理员首页
    public class OrtherController : Controller
    {
        // GET: Orther
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult indexAdmin()//管理员首页
        {
            return View();
        }
    }
}