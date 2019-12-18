using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net实训_.Models
{
    //管理员首页需要的字段数据
    public class total
    {
        //维修解决人数
        public int repairSolveNum
        {
            get;
            set;
        }
        //维修未解决人数
        public int repairUnSolveNum
        {
            get;
            set;
        }
        //每月收费人数
        public int[] chargeNum
        {
            get;
            set;
        }
        //每月欠费人数
        public int[] unchargeNum
        {
            get;
            set;
        }
        //每页投诉人数
        public int[] compalinNum
        {
            get;
            set;
        }
    }
}