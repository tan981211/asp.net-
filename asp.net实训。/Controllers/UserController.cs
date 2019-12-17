using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net实训_.Controllers
{
    //业主
    //业主管理
    public class UserController : Controller
    {
        // GET: User
        public string Index()
        {
            return "张跃制作的UserController";
        }
        public ActionResult user()//业主个人信息页
        {
            return View();
        }
        public ActionResult userAdmin()//管理业主页
        {
            return View();
        }
    }
}