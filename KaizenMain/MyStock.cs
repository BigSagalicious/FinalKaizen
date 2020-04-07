using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyStock
    {
        private String stockID, equipType, suppID, stockDesc;
        private int qtyInStock;
        private double purPrice, rentalPrice, servicePrice;

        public MyStock()
        {
            this.stockID = ""; this.equipType = ""; this.suppID = ""; this.stockDesc = "";
            this.qtyInStock = 0;
            this.purPrice = 0.00; this.rentalPrice= 0.00; this.servicePrice = 0.00;
        }

        public MyStock(string stockID, string equipType, string suppID, string stockDesc,  int qtyInStock = 0, double purPrice = 0.00, double rentalPrice = 0.00, double servicePrice = 0.00)
        {
            this.stockID = stockID; this.equipType = equipType; this.suppID = suppID; this.stockDesc = stockDesc;
            this.qtyInStock = qtyInStock;
            this.purPrice = purPrice; this.rentalPrice = rentalPrice; this.servicePrice = servicePrice;
        }

        public string StockID
        {
            get { return stockID; }
            set 
           {
                if (MyValidation.VailidIDCode("EQ", stockID))
                {
                    stockID = value;
                }
                else
                    throw new MyException("Stock ID must contain 'EQ-' ");
            }
         
        }

        public string EquipType
        {
            get { return equipType; }
            set
            {
                equipType = value;
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


        public double PurPrice
        {
            get { return purPrice; }
            set { purPrice = value; }
        }

        public double RentalPrice
        {
            get { return rentalPrice; }
            set { rentalPrice = value; }
        }

        public double ServicePrice
        {
            get { return servicePrice; }
            set { servicePrice = value; }
        }
    }
}
