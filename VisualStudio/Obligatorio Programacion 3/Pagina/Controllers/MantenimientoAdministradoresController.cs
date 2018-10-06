using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pagina.Models;
using BLL;
using Dominio;

namespace Pagina.Controllers
{
    public class MantenimientoAdministradoresController : Controller
    {
        AdministradorController administradorController = new AdministradorController();
        public ActionResult Index()
        {
            ViewBag.administradores = administradorController.DarAdministradores();
            return View();
        }
        public ActionResult Agregar(Administrador adm)
        {
            return Json(new { success = administradorController.Agregar(adm) != null ? true : false, data = adm }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Regresar()
        {
            return RedirectToAction("Index", "AdministradoresMenu");
        }
        public ActionResult Borrar(Administrador adm)
        {
            administradorController.Borrar(adm.Mail);
            return Json(new { success = true, data = adm }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Modificar(Administrador adm)
        {
            administradorController.Modificar(adm);
            return Json(new { success = true, data = adm }, JsonRequestBehavior.AllowGet);
        }
    }
}