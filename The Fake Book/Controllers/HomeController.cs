using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace The_Fake_Book.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Meow Book is the purrfect site for cats!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Need assistance? Contact us today!";

            return View();
        }
    }
}