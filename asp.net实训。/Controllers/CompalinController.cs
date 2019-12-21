using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp.net实训_.Models;
namespace asp.net实训_.Controllers
{
    //业主投诉
    //管理投诉
    
    public class CompalinController : Controller
    {
        safeDataContext db = new safeDataContext();
        // GET: Compalin
        public ActionResult Index()
        {
            if (Request.Cookies["email"] == null)
                return RedirectToAction("../Home/login");
            return View();
        }

        public ActionResult compalinUser()
        {
            if (Request.Cookies["email"] == null)
                return RedirectToAction("../Home/login");
            int id = getId();
            var data = db.complain.Where(p=>p.userId==id).Select(p => new Complain1(p.complainId,p.complainType,p.complainDesc,p.complainDate));
            return View(data);
        }
        public ActionResult handleUser()
        {
            if (Request.Cookies["email"] == null)
                return RedirectToAction("../Home/login");
            return View();
        }
        public ActionResult compalinAdmin()
        {
            if (Request.Cookies["email"] == null)
                return RedirectToAction("../Home/login");
            var data = db.complain.Select(p=>new Complain1(p.complainId,p.complainType,p.complainDesc,p.userId,p.complainDate));
            return View(data);
        }
        public JsonResult changeComplain(int id,string desc)
        {
            var data = db.complain.Select(p => p).Where(p => p.complainId == id);
            if (data != null)
            {
                foreach(complain r in data)
                {
                    r.complainDesc = desc;
                }
                db.SubmitChanges();
                return Json(true);
            }
            return Json(false);
        }
        public JsonResult insertComplain(string type)
        {
            bool flag = false;
            try
            {
                complain complain = new complain();
                complain.complainType = type;
                complain.userId = getId();
                complain.complainDate = DateTime.Now;
                db.complain.InsertOnSubmit(complain);
                db.SubmitChanges();
                flag = true;
                return Json(flag);
            }
            catch (Exception e)
            {
                return Json(false);
            }

        }
        public int getId()
        {
            String s1 = null;
            if (Request.Cookies["email"] != null)
                s1 = Request.Cookies["email"].Value;
            user data = db.user.Where(p => p.userEmail == s1).First();
            return data.userId;
        }

    }
}