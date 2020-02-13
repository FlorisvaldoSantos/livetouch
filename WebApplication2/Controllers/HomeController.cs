using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(Usuario usuariologado)
        {
            if (usuariologado.Token == "")
                return RedirectToAction("Login", "Login");

            Servico servico = new Servico();

            servico.GetCarros(usuariologado);

            return View();
        }

        public ActionResult About()
        { 
            ViewData["Message"] = "App desenvolvido para prova Técnica LiveTouch";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
