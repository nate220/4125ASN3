using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4125ASSN3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Who We Are";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "VehicleSearch.com";

            return View();
        }
    }
}