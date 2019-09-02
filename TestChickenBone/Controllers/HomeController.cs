using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestChickenBone.Models;

namespace TestChickenBone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Demo()
        {
            var person = new Person()
            {
                FirstName = "Stefan",
                LastName = "Korfitz",
                Age = 36
            };
            
            ViewBag.Message = "Your demo page.";
            ViewData["Person"] = person;

            return View("~/Views/Home/Demo.cshtml", person);
        }
    }
}