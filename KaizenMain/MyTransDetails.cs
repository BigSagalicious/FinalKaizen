using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyTransDetails
    {

        private String transDetsID, transID, stockID;
        private int qty;
        private DateTime startDate, endDate;

        public MyTransDetails()
        {

            this.transDetsID = ""; this.transID = ""; this.stockID = "";
            this.qty = 0;
            this.startDate = new DateTime(); this.endDate = new DateTime();
        }
        public MyTransDetails(string transDetsID, string transID, string stockID, int qty, DateTime startDate, DateTime endDate)
        {
            this.transDetsID = transDetsID; this.transID = transID; this.stockID = stockID; this.qty = qty; this.startDate = startDate; this.endDate = endDate;
        }

        public string TransDetsID
        {
            get { return transDetsID; }
            set { transDetsID = value; }
        }

        public string TransID
        {
            get { return transID; }
            set { transID = value; }
        }

        public string StockID
        {
            get { return stockID; }
            set { stockID = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
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
