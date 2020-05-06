using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyPayment
    {
            private String payID, transID, custID;
        private double payAmount;
        private DateTime payDate;

            public MyPayment()
            {

                this.payID = "";
                this.transID = ""; this.payAmount = 0.00; this.payDate = new DateTime(); this.custID = "";     
             }

            public MyPayment(string payID, string transID, double payAmount, DateTime payDate, string custID)
            {
                this.payID = payID;
                this.transID = transID; this.payAmount = payAmount; this.custID = custID; this.payDate = payDate;

            }

        public string PayID
        {
            get { return payID; }
            set
            {
                if (MyValidation.VailidIDCode("PY", payID))
                {
                    payID = value;
                }
                else
                    throw new MyException("Pay ID must start with 'PY-' ");
            }

        }

        public string TransID
        {
            get { return transID; }
            set
            {
                if (MyValidation.VailidIDCode("TR", transID))
                {
                    transID = value;
                }
                else
                    throw new MyException("Trans ID must start with 'TR-' ");
            }

        }

        public double PayAmount
        {
            get { return payAmount; }
            set
            { payAmount = value; }
        }
        public DateTime PayDate
        {
            get { return payDate; }
            set { payDate = value; }
        }

        public string CustID
        {
            get { return custID; }
            set
            {
                if (MyValidation.vaidCustID(custID))
                { custID = value; }
                else
                    throw new MyException("Please Enter Valid Customer ID");
            }
        }

        }
    }

