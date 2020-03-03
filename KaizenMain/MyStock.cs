using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyStock
    {
        private String stockID, prodID, suppID, stockDesc;
        private int qtyInStock;
        private double recPrice;

        public MyStock()
        {
            this.stockID = ""; this.prodID = ""; this.suppID = ""; this.stockDesc = "";
            this.qtyInStock = 0;
            this.recPrice = 0.00;
        }

        public MyStock(string stockID, string prodID, string suppID, string stockDesc,  int qtyInStock = 0, double recPrice = 0.00)
        {
            this.stockID = stockID; this.prodID = prodID; this.suppID = suppID; this.stockDesc = stockDesc;
            this.qtyInStock = qtyInStock;
            this.recPrice = recPrice;
        }

        public string StockID
        {
            get { return stockID; }
            set
            {
                if (MyValidation.VailidIDCode("ST", stockID))
                {
                    stockID = value;
                }
                else
                    throw new MyException("Stock ID must contain 'ST-' ");
            }
        }

        public string ProdID
        {
            get { return prodID; }
            set
            {
                if (MyValidation.VailidIDCode("PR", prodID))
                {
                    prodID = value;
                }
                else
                    throw new MyException("Stock ID must contain 'PR-' ");
            }
        }

        public string SuppID
        {
            get { return suppID; }
            set
            {
                if (MyValidation.VailidIDCode("SU", suppID))
                {
                    suppID = value;
                }
                else
                    throw new MyException("Stock ID must contain 'SU-' ");
            }
        }

        public string StockDesc
        {
            get { return stockDesc; }
            set
            {
                if (MyValidation.validLength(value, 2, 80) && MyValidation.validLetterNumberWhitespace(value))
                {
                    stockDesc = value;
                }
                else
                    throw new MyException("Description must be 2-80 letters");
            }
        }
        public int QtyInStock
        {
            get { return qtyInStock; }
            set { qtyInStock = value; }
        }

        public double RecPrice
        {
            get { return recPrice; }
            set { recPrice = value; }
        }
    }
}
