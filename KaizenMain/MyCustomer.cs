﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyCustomer
    {
        private String surname, forename, street, town, county, postcode, telNo, email;

        public MyCustomer()
        {

            this.CustomerNo = 0;
            this.email = "";this.surname = ""; this.forename = ""; this.street = ""; this.town = ""; this.county = "";
            this.postcode = ""; this.telNo = "";
        }

        public MyCustomer(int customerNo, string title, string surname, string forename, string street, string town, string county,
           string postcode, string telNo, string email)
        {
            this.CustomerNo = customerNo;
            this.surname = surname; this.forename = forename; this.street = street; this.town = town; this.county = county;
            this.postcode = postcode; this.telNo = telNo; this.email = email;

        }

        public int CustomerNo { get; set; }



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
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetter(value))
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
                if (MyValidation.validLength(value, 2, 40) && MyValidation.validLetter(value))
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

    }
}
