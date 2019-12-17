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
        public JsonResult indexBack()
        {
            total t1=new total();
            t1.chargeNum = new List<int>();
            t1.unchargeNum = new List<int>();
            t1.compalinNum = new List<int>();
            t1.repairSolveNum = db.repairAdmin.Where(d => d.isSolve).Count();
            t1.repairUnSolveNum = db.repairAdmin.Where(d => !d.isSolve).Count();
            var cn = db.charge.Where(p => p.isPay).GroupBy(d => d.chargeDate.Month).Select(p => p.Count()).ToList();
            var ucn = db.charge.Where(p => !p.isPay).GroupBy(d => d.chargeDate.Month).Select(p=>p.Count()).ToList();
            var cnn = db.complain.GroupBy(d => d.complainDate.Month).Select(p=>p.Count()).ToList();
            foreach(int i in cn)
                t1.chargeNum.Add(i);
            foreach (int i in ucn)
                t1.unchargeNum.Add(i);
            foreach (int i in cnn)
                t1.compalinNum.Add(i);
            return Json(t1, "text/html", JsonRequestBehavior.AllowGet);
        }
    }
}