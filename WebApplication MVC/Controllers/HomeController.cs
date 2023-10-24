using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string name = "Kristoffer";
            int age = 23;
            DateTime birthday = new DateTime(2000,6,19);

            ViewBag.name = name;
            ViewBag.age = age;
            ViewBag.birthday = birthday;
            return View(new HomeModel("Kristoffer",23, new DateTime(2000, 6, 19)));
        }
    }
}