using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_MVC.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TimeCalculator()
        {
            return View();  
        }

        [HttpPost]
        public ActionResult TimeCalculator(FormCollection formCollection)
        {
            int hours = Convert.ToInt32(formCollection["Hours"]);
            int minutes = Convert.ToInt32(formCollection["Minutes"]);
            int seconds = Convert.ToInt32(formCollection["Seconds"]);

            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
            double total = ts.TotalSeconds;

            ViewBag.hours = hours; 
            ViewBag.minutes = minutes; 
            ViewBag.seconds = seconds;
            ViewBag.total = total;

            return View("TimeCalculatorResult");
        }

    }
}