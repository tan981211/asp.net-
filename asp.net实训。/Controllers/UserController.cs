using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp.net实训_.Models;
namespace asp.net实训_.Controllers
{
    //业主
    //业主管理
    public class UserController : Controller
    {
        safeDataContext db = new safeDataContext();
        // GET: User
        public string Index()
        {
            return "张跃制作的UserController";
        }
        //业主个人信息页
        public ActionResult user()
        {
            return View();
        }
        //管理业主页
        public ActionResult userAdmin()
        {
            var u1 = db.user.Select(p => new users { userId = p.userId, userName = p.userName, userMail = p.userEmail, userPhone = p.userPhone, userAdress = p.userAddress, userPassword = p.userPassword });
            return View(u1.ToList());

        }
        //业主修改
        public void userUpdate(users u)
        {
            var u1 = db.user.Where(p => p.userId == u.userId);
            foreach (user us in u1)
            {
                us.userName = u.userName;
                us.userPhone = u.userPhone;
                us.userAddress = u.userAdress;
                us.userEmail = u.userMail;
            }
            db.SubmitChanges();
        }
        //业主插入
        public string userInsert(users u)
        {
            var uh = db.user.Where(p => p.userEmail == u.userMail);
            if (uh != null && uh.Count() > 0)
            {
                return "失败";
            }
            else
            {
                user u1 = new user();
                u1.userEmail = u.userMail;
                u1.userAddress = u.userAdress;
                u1.userName = u.userName;
                u1.userPassword = u.userPassword;
                u1.userPhone = u.userPhone;
                db.user.InsertOnSubmit(u1);
                db.SubmitChanges();
            }
       
            return "";
        }
    }
}