using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net实训_.Models
{
    public class users
    {
      
        //业主编号
        public int userId
        {
            get;
            set;
        }
        //业主姓名
        public string userName
        {
            get;
            set;
        }
        //业主邮箱
        public string userMail
        {
            get;
            set;
        }
        //业主电话
        public string userPhone
        {
            get;
            set;
        }
        //业主地址
        public string userAdress
        {
            get;
            set;
        }
        //业主密码
        public string userPassword
        {
            get;
            set;
        }
    }
}