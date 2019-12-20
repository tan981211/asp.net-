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
            return View();
        }

        public ActionResult compalinUser()
        {
            var data = db.complain.Select(p => new Complain1(p.complainId,p.complainType,p.complainDesc,p.complainDate));
            return View(data);
        }
        public ActionResult handleUser()
        {
            return View();
        }
        public ActionResult compalinAdmin()
        {
            return View();
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