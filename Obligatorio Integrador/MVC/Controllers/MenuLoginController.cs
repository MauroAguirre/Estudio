using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using BLL;

namespace MVC.Controllers
{
    public class MenuLoginController : Controller
    {
        UsuarioController uc = new UsuarioController();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ingresar(Usuario u)
        {
            if (uc.Verificar_login(u))
            {
                return Json(Url.Action("Index", "MenuPrincipal"));
            }
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }
    }
}