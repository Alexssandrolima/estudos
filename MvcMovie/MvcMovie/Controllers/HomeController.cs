using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modificar este modelo para dar início a sua ASP.NET MVC aplicação.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sua aplicação na descrição pagina.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Seu contato na pagina.";

            return View();
        }
        public ActionResult Movies()
        {
            ViewBag.Message = "Filmes cadastrado pela aplicação";

            return View();
        }
    }
}
