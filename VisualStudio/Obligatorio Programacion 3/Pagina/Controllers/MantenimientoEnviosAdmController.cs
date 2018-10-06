using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pagina.Models;
using BLL;

namespace Pagina.Controllers
{
    public class MantenimientoEnviosAdmController : Controller
    {
        EnvioController envioController = new EnvioController();
        DireccionesController direccionesController = new DireccionesController();
        public ActionResult Index()
        {
            ViewBag.direcciones = direccionesController.Lista_de_Direcciones();
            ViewBag.envios = envioController.DarTodosEnvios();
            return View();
        }
        public ActionResult CambiarEnvio(EnvCam e)
        {
            return Json(new { success = true, data = envioController.CambiarEnvio(e.Estado,e.Direccion,int.Parse(e.Id)) }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Regresar()
        {
            return RedirectToAction("Index", "AdministradoresMenu");
        }
    }
}