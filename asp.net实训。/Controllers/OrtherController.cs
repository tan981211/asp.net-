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
        safeDataContext safe = new safeDataContext();
        // GET: Orther
        public ActionResult Index()
        {
            return View();
        }
   

        public ActionResult indexAdmin()//管理员首页
        {
            return View();
        }
        public ActionResult indexUser()
        {
            string email = Request["email"];
            string password = Request["password"];
            var data = safe.user.Select(p=>new {p.userEmail,p.userPassword }).Where(p=>p.userEmail==email && p.userEmail==password );
            //if (data.Count() > 0 && data != null) {
 
            //   return indexAdmin(); }
            return indexAdmin();
        }
    }
}