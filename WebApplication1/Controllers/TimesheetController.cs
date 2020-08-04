using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TimesheetController : Controller
    {
        // GET: Timesheet
        public ActionResult Random()
        {
            var timesheet = new Timesheet() { CompanyName = "ABC" };


            return View(timesheet);
        }
    }
}