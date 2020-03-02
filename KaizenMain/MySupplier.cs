using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MySupplier
    {

        private String suppID, surname, forename, street, town, county, postcode, telNo, email,companyName;

        public MySupplier()
        {

            this.suppID = "";
            this.email = ""; this.surname = ""; this.forename = ""; this.street = ""; this.town = ""; this.county = "";
            this.postcode = ""; this.telNo = "";this.companyName = "";
        }

        public MySupplier(string suppID, string title, string surname, string forename, string street, string town, string county,
           string postcode, string telNo, string email,string companyName)
        {
            this.suppID = suppID;
            this.surname = surname; this.forename = forename; this.street = street; this.town = town; this.county = county;
            this.postcode = postcode; this.telNo = telNo; this.email = email;this.companyName = companyName;

        }

        public string SuppID
        {
            get { return suppID; }
            set
            {
                if (MyValidation.validLength(value, 6, 6) && MyValidation.validLetterNumberWhitespace(value))
                {
                    suppID = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("SuppID must be 6 characters long");
            }

        }



        public string Forename
        {
            get { return forename; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validForename(value))
                {
                    forename = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Forename must be 2-15 letters");

            }

        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validSurname(value))
                {
                    surname = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Forename must be 2-15 letters");

            }

        }

        public string Street
        {
            get { return street; }
            set
            {
                if (MyValidation.validLength(value, 5, 40) && MyValidation.validLetterNumberWhitespace(value))
                {
                    street = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Street must be 5-40 letters");
            }


        }

        public string Town
        {
            get { return town; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterWhitespace(value))
                {
                    town = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Town must be 2-20 letters");
            }


        }

        public string County
        {
            get { return county; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterWhitespace(value))
                {
                    county = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Street must be 2-20 letters");
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

        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    postcode = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Postcode must be 7-8 letters and alphanumeric only");
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
        public string CompanyName
        {
            get { return companyName; }
            set
            {
                if (MyValidation.validLength(value, 2, 40) && MyValidation.validLetterWhitespace(value))
                {
                    companyName = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Company Name must be 2-40 letters");
            }


        }

    }
}

