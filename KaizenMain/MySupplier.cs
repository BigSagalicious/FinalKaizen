using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MySupplier
    {

        private String suppID,address, telNo, email,companyName,companyContact;

        public MySupplier()
        {

            this.suppID = "";
            this.email = ""; this.companyContact = ""; this.address = ""; this.telNo = "";this.companyName = "";
        }

        public MySupplier(string suppID, string title, string address, string companyContact,string telNo, string email,string companyName)
        {
            this.suppID = suppID;
            this.companyContact = companyContact; this.address = address; this.telNo = telNo; this.email = email;this.companyName = companyName;

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



        public string CompanyName
        {
            get { return companyName; }
            set
            {
                if (MyValidation.validLength(value, 2, 100) && MyValidation.validLetterWhitespace(value))
                {
                    companyName = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Company name must be 2-100 letters");

            }

        }

        public string CompanyContact
        {
            get { return companyContact; }
            set
            {
                if (MyValidation.validLength(value, 2, 100) && MyValidation.validForename(value))
                {
                    companyContact = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Company Contact must be 2-20 letters");

            }

        }
        public string Address
        {
            get { return address; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validSurname(value))
                {
                    address = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Address must be 2-50 letters");

            }

        }

        

        

        public string Email
        {
            get { return email; }
            set
            {
                if (MyValidation.validEmail(value))
                {
                    email = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Email must be 2-40 letters");
            }


        }

        

        public string TelNo
        {
            get { return telNo; }
            set
            {
                if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
                {
                    telNo = value;
                }
                else
                    throw new MyException("Telephone number must be 11-15 digits");
            }


        }
      

    }
}

