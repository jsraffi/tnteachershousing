using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tnteachershousing.Controllers
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

        public ActionResult overview()
        {
            return View();
        }

        public ActionResult mission_statement()
        {
            return View();
        }

        public ActionResult management_team()
        {
            return View();
        }

        public ActionResult core_values()
        {
            return View();
        }

        
    }
}