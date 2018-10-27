using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Dominio;

namespace MVC.Controllers
{
    public class MenuProveedorController : Controller
    {
        ProveedorController pc = new ProveedorController();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Agregar(Proveedor p)
        {
            Proveedor nuevo = pc.Agregar(p);
            if (nuevo != null)
                return Json(new { success = true, data = nuevo }, JsonRequestBehavior.AllowGet);
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Modificar(Proveedor p)
        {
            pc.Modificar(p);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Borrar(Proveedor p)
        {
            pc.Borrar(p.rut);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "MenuPrincipal"));
        }
        public ActionResult Lista()
        {
            return Json(new { success = true, data = pc.Lista() }, JsonRequestBehavior.AllowGet);
        }
    }
}