using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cartfolo.Models;

namespace cartfolo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Sample Index";
            int hour = DateTime.Now.Hour;
            string greeting = "Hi";
            if (hour < 12)
            {
                greeting = "Good morning";
            }
            else
            {
                greeting = "Good Afternoon";
            }
            ViewBag.Greeting = greeting;
            ViewBag.Username = User.Identity.Name;
            ViewBag.CurrentDate = DateTime.Now;
            return View();
        }

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(GuestAccount account)
        {
            return View("Thank you!", account);
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
    }
}