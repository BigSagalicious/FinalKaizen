using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyTrans
    {
        private String transID, transType, custID;
        private double balOwed, transTotal;
        private char paid;
        private DateTime transOn;

        public MyTrans()
        {
            this.transID = ""; this.transType = ""; this.custID = "";
            this.balOwed = 0.00; this.transTotal = 0.00;
            this.paid = '\0';
            this.transOn = new DateTime();
        }

        public MyTrans(string transID, string transType, string custID, double balOwed, double transTotal, char paid ,DateTime transOn)
        {
            this.transID = transID; this.transType = transType; this.custID = custID;
            this.balOwed = balOwed; this.transTotal = transTotal;
            this.paid = paid;
            this.transOn = transOn; 
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
            set {
                if (MyValidation.vaidCustID(custID))
                { transType = value; }
                else
                    throw new MyException("Please Enter Valid Customer ID");
            }
        }
        public double BalOwed
        {
            get { return balOwed; }
            set
            {
                if (MyValidation.validNumber(transType))
                { balOwed = value; }
                else
                    throw new MyException("Please Add Items to order");
            }
        }

        public double TransTotal
        {
            get { return transTotal; }
            set
            {
                if (MyValidation.validNumber(transType))
                { transTotal = value; }
                else
                    throw new MyException("Please Add Items to order");
            }
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

    }
}
