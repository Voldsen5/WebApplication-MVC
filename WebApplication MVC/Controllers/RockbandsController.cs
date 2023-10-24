using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_MVC.Controllers
{
    public class RockbandsController : Controller
    {
        // GET: Rockbands
        public ActionResult Index()
        {
            List<string> rockbands = new List<string>();
            rockbands.Add("Led Zeppelin");
            rockbands.Add("The Beatles");
            rockbands.Add("Queen");
            rockbands.Add("Bob Marley");
            ViewBag.Rockbands = rockbands;

            return View();
        }
    }
}