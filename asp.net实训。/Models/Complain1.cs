using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net实训_.Models
{
    public class Complain1
    {
        public Complain1(int complainid, string complainType, string complainDesc, DateTime complainDate)
        {
            this.complainid = complainid;
            this.complainType = complainType;
            this.complainDesc = complainDesc;
            this.complainDate = complainDate;
        }

        public Complain1(int complainid, string complainType, string complainDesc,int userid,DateTime complainDate)
        {
            this.complainid = complainid;
            this.complainType = complainType;
            this.complainDesc = complainDesc;
            this.complainDate = complainDate;
            this.userid = userid;
        }

        public int complainid { get; set; }
        public string complainType { get; set; }
        public string complainDesc { get; set; }
        public DateTime complainDate { get; set; }
        public int userid { get; set; }
    }
}