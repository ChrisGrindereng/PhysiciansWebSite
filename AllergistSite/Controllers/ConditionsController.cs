using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllergistSite.Controllers
{
    public class ConditionsController : Controller
    {
        // GET: Conditions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult allergicRhinitis()
        {
            return View();
        }

        public ActionResult nonallergicRhinitis()
        {
            return View();
        }

        public ActionResult asthma()
        {
            return View();
        }

        public ActionResult sinusitus()
        {
            return View();
        }

        public ActionResult skinDisease()
        {
            return View();
        }

        public ActionResult foodAllergy()
        {
            return View();
        }

        public ActionResult venom()
        {
            return View();
        }

        public ActionResult anaphylaxis()
        {
            return View();
        }
    }
}