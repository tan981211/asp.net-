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
        //public ActionResult login()
        //{
        //    return View();
        //}
        //管理员首页
        public ActionResult indexAdmin()
        {
            return View();
        }
        //业主首页
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
                Response.Cookies["email"].Value = email;
                rsq = true;
                return Json(rsq);
            } 
                rsq = false;
                return Json(rsq);
            
        }

        //管理员首页页面加载发送ajax请求返回json数据
        public JsonResult indexBack()
        {
            total t1 = new total();
            //数组类型初始化
            t1.chargeNum = new int[6];
            t1.unchargeNum = new int[6];
            t1.compalinNum = new int[12];
            //linq查询所需数据
            t1.repairSolveNum = db.repairAdmin.Where(d => d.isSolve).Count();//维修解决人数
            t1.repairUnSolveNum = db.repairAdmin.Where(d => !d.isSolve).Count(); //维修未解决人数
            var cn = db.charge.Where(p => p.isPay).GroupBy(d => d.chargeDate.Month).Select(p => new { month = p.Select(g => g.chargeDate.Month).First(), count = p.Count() }).ToList();//每月收费人数
            var ucn = db.charge.Where(p => !p.isPay).GroupBy(d => d.chargeDate.Month).Select(p => new { month = p.Select(g => g.chargeDate.Month).First(), count = p.Count() }).ToList(); //每月欠费人数
            var cnn = db.complain.GroupBy(d => d.complainDate.Month).Select(p => new { month = p.Select(g => g.complainDate.Month).First(), count = p.Count() }).ToList(); //每页投诉人数
            //将linq查询所需数据存入model
            for (int i = 0; i < cn.Count; i++)
                t1.chargeNum[cn[i].month - 1] = cn[i].count;
            for (int i = 0; i < ucn.Count; i++)
                t1.unchargeNum[ucn[i].month - 1] = ucn[i].count;
            for (int i = 0; i < cnn.Count; i++)
                t1.compalinNum[cnn[i].month - 1] = cnn[i].count;
            //返回json格式数据
            return Json(t1, "text/html", JsonRequestBehavior.AllowGet);
        }
    }
}