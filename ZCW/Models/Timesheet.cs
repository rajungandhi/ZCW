using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZCW.Models
{
    public class Timesheet
    {
        public Timesheet()
        {

        }
        public int TimesheetID { get; set; }

        public void getTimesheet(int timesheetID)
        {
            //Shelve changes

            //Conflict changes
            var projectId = 23424;
            var timesheetID = 1234;
        }
    }
}