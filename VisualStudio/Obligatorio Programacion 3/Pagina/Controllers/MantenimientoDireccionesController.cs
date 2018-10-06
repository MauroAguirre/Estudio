using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using BLL;

namespace Pagina.Controllers
{
    public class MantenimientoDireccionesController : Controller
    {
        DireccionesController direccionesController = new DireccionesController();
        public ActionResult Index()
        {
            var direcciones = direccionesController.Lista_de_Direcciones();
            ViewBag.direcciones = direcciones;
            return View();
        }
        public ActionResult Agregar(Direccion dir)
        {
            return Json(new { success = direccionesController.Crear(dir.Nombre) != null ? true : false, data = dir }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Regresar()
        {
            return RedirectToAction("Index", "AdministradoresMenu");
        }
        public ActionResult Borrar(Direccion dir)
        {
            direccionesController.Borrar(dir.Nombre);
            return Json(new { success = true, data = dir }, JsonRequestBehavior.AllowGet);
        }
    }
}