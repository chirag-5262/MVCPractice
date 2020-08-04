using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Timesheet
    {
        public int TimesheetNo { get; set; }
        public string CompanyName { get; set; }
        public string EmployeeName { get; set; }
        public string WeekOf { get; set; }
        public string ClockinDate { get; set; }
        public string ClockinDay { get; set; }
        public string Intime { get; set; }
        public string OutTime { get; set; }
        public int DailyTotal { get; set; }
        public int WeeklyTotal { get; set; }
    }
}