using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Common;

namespace MVC.Controllers
{
    public class MenuProveedorController : Controller
    {
        ProveedorController pc = ProveedorController.Instancia();
        public ActionResult MenuProveedor()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
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
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
        public ActionResult Lista()
        {
            return Json(new { success = true, data = pc.Lista() }, JsonRequestBehavior.AllowGet);
        }
    }
}