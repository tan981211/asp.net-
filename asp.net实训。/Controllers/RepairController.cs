using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp.net实训_.Models;

namespace asp.net实训_.Controllers
{
    
    //业主报修
    //管理维修
    public class RepairController : Controller
    {
        safeDataContext db = new safeDataContext();
        //插入数据
        public void insert(string name, string type)
        {
            repairAdmin repair = new repairAdmin();
            repair.userId = getId();
            repair.repairType = type;
            repair.repairedDate = DateTime.Now;
            repair.repperName = "**";
            repair.repairingDate = DateTime.Now;
            repair.isAccept = false;
            repair.isSolve = false;
          
            db.repairAdmin.InsertOnSubmit(repair);
            db.SubmitChanges();
        }

        //通过cookie[email]查询id
        public int getId()
        {
            String s1=null;
            if(Request.Cookies["email"] != null)
                 s1 = Request.Cookies["email"].Value;
            user data = db.user.Where(p => p.userEmail == s1).First();
            return data.userId;
        }


        // GET: Repair
        public ActionResult repairUser()
        {
            var data = db.repairAdmin.Select(p => new evaluate(p.repperName, p.repairedDate, p.repairingDate, p.isAccept, p.isSolve,p.evaluateText,p.repairId));
            return View(data);
        }
        public ActionResult repairAdmin()
        {
            return View();
        }

        public JsonResult addRepair(string name,string type)
        {
            bool flag=false;
            try
            {
                insert(name, type); 
                flag = true;
                return Json(flag);
            }
            catch(Exception e)
            {
                return Json(false);
            }
            
        }
        public JsonResult addEval(int date,string eval)
        {
           
            var data = db.repairAdmin.Where(p => p.repairId == date);
            if (data != null&&data.Count()>0)
            {
                try
                {
                    
                    foreach (repairAdmin r in data)
                    {
                        r.evaluateText = eval;
                    }
                    db.SubmitChanges();
                    return Json(true);
                }
                catch(Exception e)
                {
                    return Json(false);
                }
            }
            return Json(false);
        }


    }
}