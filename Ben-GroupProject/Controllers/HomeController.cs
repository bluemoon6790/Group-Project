using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ben_GroupProject.Models;

namespace Ben_GroupProject.Controllers
{
    public class HomeController : Controller
    {
        private Database1Entities db = new Database1Entities();

        public ActionResult Index()
        {

            return View(db.Labs.Include("Equipments").ToArray());
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