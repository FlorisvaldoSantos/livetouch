using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            var model = new Login();
            return View(model);
        }

        // POST: Login
        [HttpPost]
        public ActionResult Login(Login model)
        {
            if (model == null)
                return View(model);

            if (!TryValidadeModel(model))
                return View(model);

            Servico servico = new Servico();

            Usuario usuariologado = servico.GetUsuario(model);

            if (usuariologado.Token == null)
                return View(model);
           
            return RedirectToAction("Index", "Home", usuariologado);
        }

        private bool TryValidadeModel(Login model)
        {
            ModelState.Clear();

            if(model.Username == "" || model.Username == null)
            {
                ModelState.AddModelError("Username", "Informe o Login.");
                return false;
            }

            if(model.Password == "" || model.Password == null)
            {
                ModelState.AddModelError("Password", "Informe a senha.");
                return false;
            }

            return true;
        }


        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Login));
            }
            catch
            {
                return View();
            }
        }

      
    }
}