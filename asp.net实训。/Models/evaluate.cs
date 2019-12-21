using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net实训_.Models
{
    public class evaluate
    {
        public int repairId { get; set; }
        public int userid { get; set; }
        public string name { get; set; }
        public string repperName { get; set; }
        public string repairType { get; set; }
        public DateTime repairDate { get; set; }
        public DateTime repairingDate { get; set; }
        public string repperPhone { get; set; }
        public bool isAccetp { get; set; }
        public bool isSolve { get; set; }
        public string isAccetp1 { get; set; }
        public string isSolve1 { get; set; }
        public string evaluateText { get; set; }
  
        public evaluate(string name, DateTime repairDate, DateTime repairingDate, bool isAccetp, bool isSolve,string evaluateText,int repairId)
        {
            this.name = name;
            this.repairDate = repairDate;
            this.repairingDate = repairingDate;
            this.isAccetp = isAccetp;
            this.isSolve = isSolve;
            this.evaluateText = evaluateText;
            this.repairId = repairId;
            if (isAccetp == true)
                this.isAccetp1 = "是";
            else
                this.isAccetp1 = "否";
            this.isSolve = isSolve;
            if (isSolve == true)
                this.isSolve1 = "是";
            else
                this.isSolve1 = "否";
        }

        public evaluate(int repairId, int userid, string name, string repperName, string repairType, DateTime repairDate, DateTime repairingDate, string repperPhone, bool isAccetp, bool isSolve, string evaluateText)
        {
            this.repairId = repairId;
            this.userid = userid;
            this.name = name;
            this.repperName = repperName;
            this.repairType = repairType;
            this.repairDate = repairDate;
            this.repairingDate = repairingDate;
            this.repperPhone = repperPhone;
            this.isAccetp = isAccetp;
            this.isSolve = isSolve;
            this.evaluateText = evaluateText;
            if (isAccetp == true)
                this.isAccetp1 = "是";
            else
                this.isAccetp1 = "否";
            this.isSolve = isSolve;
            if (isSolve == true)
                this.isSolve1 = "是";
            else
                this.isSolve1 = "否";
        }
    }
}