using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllergistSite.Controllers
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

        public ActionResult Physicians()
        {
            ViewData["Message"] = "Physicians";

            return View();
        }

        public ActionResult Offices()
        {
            ViewData["Message"] = "Offices";

            return View();
        }

        public ActionResult Services()
        {
            ViewData["Message"] = "Conditions we Treat";

            return View();
        }

        public ActionResult NewPatient()
        {
            ViewData["Message"] = "New to the Practice?";

            return View();
        }

        public ActionResult PollenMap()
        {
            ViewData["Message"] = "Pollen Levels in Your Area.";

            return View();
        }

        public ActionResult AppointmentForm()
        {
            ViewData["Message"] = "Schedule an Appointment!";

            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}