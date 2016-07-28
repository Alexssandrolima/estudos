using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()   //o mvc 4 ja cria a view diretamente.
        {
            return View();   // o mvc 4 ja manda mostra diretamente a view da pasta view,
        }

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // GET: /HelloWorld/Welcome/   criado por alexssandro 

//        public string Welcome()
//        {
//            return "This is the Welcome action method...";
//        }

        //public string Welcome(string name, int numTimes = 1)
        //{

        //    return HttpUtility.HtmlEncode("Olá, " + name + ", Seu tempo é: " + numTimes);
        //}
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Olá, " + name;
            ViewBag.NumTimes = numTimes;

            return View();

        }
    }
}
