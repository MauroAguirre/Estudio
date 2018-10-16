using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Dominio;

namespace MVC.Controllers
{
    public class MenuUsuarioController : Controller
    {
        UsuarioController uc = new UsuarioController();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AgregarUsuario(Usuario u)
        {
            if (uc.Agregar(u))
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Modificar(Usuario u)
        {
            uc.Modificar(u);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Borrar(Usuario u)
        {
            uc.Borrar(u.mail);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "MenuPrincipal"));
        }
        public ActionResult ListaUsuarios() {
            return Json(new { success = true, data = uc.Lista() }, JsonRequestBehavior.AllowGet);
        }
    }
}