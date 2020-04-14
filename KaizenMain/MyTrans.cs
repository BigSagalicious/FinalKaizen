using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyTrans
    {
        private String transID, transType, custID;
        private double balOwed;
        private char paid;
        private DateTime transOn, startDate, endDate;

        public MyTrans()
        {
            this.transID = ""; this.transType = ""; this.custID = "";          
            this.balOwed = 0.00;
            this.paid = '\0';
            this.transOn = new DateTime(); this.startDate = new DateTime(); this.endDate = new DateTime();
        }

        public MyTrans(string transID, string transType, string custID, double balOwed ,char paid ,DateTime transOn, DateTime startDate, DateTime endDate)
        {
            this.transID = transID; this.transType = transType; this.custID = custID;
            this.balOwed = balOwed;
            this.paid = paid;
            this.transOn = transOn; this.startDate = startDate; this.endDate = endDate;
        }

        public string TransID
        {
            get { return transID; }
            set { transID = value; }
        }

        public string TransType
        {
            get { return transType; }
            set { transType = value; }
        }

        public string CustID
        {
            get { return custID; }
            set { custID = value; }
        }

        public double BalOwed
        {
            get { return balOwed; }
            set { balOwed = value; }
        }

        public char Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        public DateTime TransOn
        {
            get { return transOn; }
            set { transOn = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}
