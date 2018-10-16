using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Dominio;

namespace MVC.Controllers
{
    public class MenuArticuloController : Controller
    {
        ArticuloController ac = new ArticuloController();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AgregarArticulo(Articulo a)
        {
            if (ac.Agregar(a))
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Modificar(Articulo a)
        {
            ac.Modificar(a);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Borrar(Articulo a)
        {
            ac.Borrar(a.id);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "MenuPrincipal"));
        }
        public ActionResult ListaUsuarios()
        {
            return Json(new { success = true, data = ac.Lista() }, JsonRequestBehavior.AllowGet);
        }
    }
}