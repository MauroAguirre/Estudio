using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Dominio;

namespace MVC.Controllers
{
    public class UsersController : Controller
    {
        UsuarioController uc = new UsuarioController();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AgregarUsuario(Usuario u)
        {
            if (uc.AgregarUsuario(u))
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "MainMenu"));
        }
    }
}