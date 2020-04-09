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

        public MyTransDetails()
        {

            this.transDetsID = ""; this.transID = ""; this.stockID = "";
            this.qty = 0;
        }
        public MyTransDetails(string transDetsID, string transID, string stockID, int qty)
        {
            this.transDetsID = transDetsID; this.transID = transID; this.stockID = stockID; this.qty = qty;;            
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
    }
}
