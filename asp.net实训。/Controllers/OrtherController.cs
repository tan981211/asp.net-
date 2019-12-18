using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp.net实训_.Models;

namespace asp.net实训_.Controllers
{
    //登录页
    //业主首页
    //管理员首页
    public class OrtherController : Controller
    {
        safeDataContext db = new safeDataContext();
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
            if (Request.Cookies["email"] == null)
                return RedirectToAction("../Home/login");
            return View();
        }

        public JsonResult config(string email,string password)
        {
            bool rsq;
            var data = db.user.Where(p => p.userEmail==(email) && p.userPassword == password);
            if (data.Count() > 0 && data != null)
            {
                if (Request.Cookies["email"] == null)
                {
                    HttpCookie cookie = new HttpCookie("email");
                    cookie.Value = email;
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }
                rsq = true;
            }
            else
                rsq = false;
            return Json(rsq);
        }
    }
}