using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Common;

namespace MVC.Controllers
{
    public class MenuArticuloController : Controller
    {
        ArticuloController ac = ArticuloController.Instancia();
        public ActionResult MenuArticulo()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            return View();
        }
        public ActionResult Agregar(Articulo a)
        {
            Articulo nuevo = ac.Agregar(a);
            if (nuevo  != null)
                return Json(new { success = true ,data = nuevo}, JsonRequestBehavior.AllowGet);
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Modificar(Articulo a)
        {
            if (ac.Modificar(a))
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Borrar(Articulo a)
        {
            ac.Borrar(a.id);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
        public ActionResult Lista()
        {
            return Json(new { success = true, data = ac.Lista() }, JsonRequestBehavior.AllowGet);
        }
    }
}