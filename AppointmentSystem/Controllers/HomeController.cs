using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppointmentSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Doctor()
        {
            return RedirectToAction("Index", "Doctors");
        }

        public ActionResult Patient()
        {
            return RedirectToAction("Index", "Patients");
        }
    }
}