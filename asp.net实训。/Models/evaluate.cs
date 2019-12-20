using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net实训_.Models
{
    public class evaluate
    {
        public string name { get; set; }
        public DateTime repairDate { get; set; }
        public DateTime repairingDate { get; set; }
        public bool isAccetp { get; set; }
        public bool isSolve { get; set; }
        public string evaluateText { get; set; }
        public int repairId { get; set; }
        public evaluate(string name, DateTime repairDate, DateTime repairingDate, bool isAccetp, bool isSolve,string evaluateText,int repairId)
        {
            this.name = name;
            this.repairDate = repairDate;
            this.repairingDate = repairingDate;
            this.isAccetp = isAccetp;
            this.isSolve = isSolve;
            this.evaluateText = evaluateText;
            this.repairId = repairId;
        }

        
    }
}