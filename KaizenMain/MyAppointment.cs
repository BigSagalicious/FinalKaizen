using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyAppointment
    {
        private String appID, transID, staffID,appTime;
        private int duration;
        private DateTime  appDate, dateBooked;


        public MyAppointment()
        {

            this.appID = ""; this.transID = ""; this.staffID = "";
            this.duration = 0; this.appTime = ""; this.appDate = new DateTime(); this.dateBooked = new DateTime();
        }
        public MyAppointment(int duration, string appID, string transID, string staffID, string appTime, DateTime appDate, DateTime dateBooked)
        {
            this.duration = duration;this.appID = appID; this.transID = transID;this.staffID = staffID;this.appTime = appTime;this.appDate = appDate;
            this.dateBooked = dateBooked;

        }

        public string AppID
        {
            get { return appID; }
            set { appID = value; }

           
        }

        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }


        }

        public string TransID
        {
            get { return transID; }
            set { transID = value; }


        }

        public DateTime Appdate
        {
            get { return appDate; }
            set { appDate = value; }

        }

        public DateTime DateBooked
        {
            get { return dateBooked; }
            set { dateBooked = value; }

        }

        public String AppTime
        {
            get { return appTime; }
            set { appTime = value; }

        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

    }
        
          

    





        }

    

