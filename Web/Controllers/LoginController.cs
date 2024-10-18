using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Web.Models;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        private MakersEntities db = new MakersEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            //var user = db.Usuarios.FirstOrDefault(u => u.NombreUsuario == username);

            //if (user != null && user.Contrasena == password)
            //{
            //    return true;
            //}

            return RedirectToAction("Index", "Prestamos");
        }

    }
}