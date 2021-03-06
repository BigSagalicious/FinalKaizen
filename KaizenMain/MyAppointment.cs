﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyAppointment
    {
        private String appID, transID, staffID,appTime,appDesc;
        private int duration;
        private DateTime  appDate, dateBooked;
        //private TimeSpan appTime;


        public MyAppointment()
        {
            
            this.appID = ""; this.transID = ""; this.staffID = "";this.appDesc = "";
            this.duration = 0; this.appTime =""; this.appDate = new DateTime(2020,01,01); this.dateBooked = new DateTime(2020,01,01);
        }
        public MyAppointment(int duration, string appID,string description, string transID, string staffID, string appTime, DateTime appDate, DateTime dateBooked)
        {
            this.duration = duration;this.appID = appID; this.transID = transID;this.staffID = staffID;this.appTime = appTime;this.appDate = appDate;
            this.dateBooked = dateBooked; this.appDesc = description;

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

        public string AppTime
        {
            get { return appTime; }
            set { appTime = value; }

        }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (MyValidation.validIntNumber(value))
                {
                    duration = value;
                }

            }
        }

        public string AppDesc
        {
            get { return appDesc; }
            set { appDesc = value; }

        }
    }
        
          

    





        }

    

