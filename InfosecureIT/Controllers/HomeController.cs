using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfosecureIT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our activities and services are as follows:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "To find out more...";

            return View();
        }
    }
}