using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyStaff
    {
        private String staffID, job, telNo, email, jobDescription, forename,surname;

        public MyStaff()
        {

            this.staffID = "";
            this.email = ""; this.job = ""; this.jobDescription= ""; this.telNo = ""; this.forename = "";this.surname = "";
        }

        public MyStaff(string staffID, string job, string address, string jobDescription, string telNo, string email, string forename,string surname)
        {
            this.staffID = staffID;
            this.email = email; this.job = job; this.jobDescription = jobDescription; this.telNo = telNo; this.forename = forename; this.surname = surname;

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
                    throw new MyException("Name must be 2-15 letters");

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
                    throw new MyException("Name must be 2-15 letters");

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

        public string StaffID
        {
            get { return staffID; }
            set
            {
                if (MyValidation.VailidIDCode("ST", staffID))
                {
                    staffID = value;
                }
                else
                    throw new MyException("Stock ID must start with 'ST-' ");
            }

        }

        public string JobDescription
        {
            get { return jobDescription; }
            set
            {
                if (MyValidation.validLength(value, 2, 100))
                {
                    jobDescription = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Name must be 2-100 letters");

            }

        }

        public string Job
        {
            get { return job; }
            set
            {
                if (MyValidation.validLength(value, 2, 30))
                {
                    job = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Name must be 2-30 letters");

            }

        }



    }
}
