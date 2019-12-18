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
        safeDataContext db = new safeDataContext();
        //插入数据
        public void insert(string name, string type)
        {
            repairAdmin repair = new repairAdmin();
            repair.repairType = type;
            repair.repairingDate = DateTime.Now;
            repair.repperName = "**";
            repair.repairingDate = DateTime.Now;
            repair.repperPhone = "****";
            repair.isAccept = false;
            repair.isSolve = false;
            repair.userId = getId();
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
            return View();
        }
        public ActionResult repairAdmin()
        {
            return View();
        }
        public ActionResult appriseUser()
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
                flag = false;
                return Json(flag);
            }
            
        }
   
    }
}