using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllergistSite.Controllers
{
    public class PatientPortalController : Controller
    {
        // GET: PatientPortal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UpdateInformation()
        {
            return View();
        }

        public ActionResult MyDocuments()
        {
            return View();
        }

        public ActionResult ViewAppointments()
        {
            return View();
        }

        public ActionResult AppointmentForm()
        {
            return View();
        }

        public ActionResult AppointmentSubmitted()
        {
            return View();
        }
    }
}