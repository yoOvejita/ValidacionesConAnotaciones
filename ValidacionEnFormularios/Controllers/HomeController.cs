using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidacionEnFormularios.Models;

namespace ValidacionEnFormularios.Controllers
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
        [HttpGet]
        public ActionResult EjemploValidacion() {
            return View();
        }
        [HttpPost]
        public ActionResult EjemploValidacion(Cuenta cuenta)
        {
            if (ModelState.IsValid) {
                ViewBag.cuenta = cuenta;
                return View("Success");
            }
            return View("EjemploValidacion");

        }
    }
}