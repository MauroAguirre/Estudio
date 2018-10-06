using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Dominio;
using Pagina.Models;

namespace Pagina.Controllers
{
    public class MantenimientoPaquetesController : Controller
    {
        PaquetesController paquetesController = new PaquetesController();
        public ActionResult Index()
        {
            string mail = Session["mail"] as string;
            ViewBag.mail = mail;
            var paquetes = paquetesController.DarPaquetesDeUsuarioDisponibles(mail);
            ViewBag.paquetes = paquetesController.DarPaquetesDeUsuarioDisponibles(mail);
            return View();
        }
        public ActionResult Agregar(paqueton paq)
        {
            Paquete paquete = paquetesController.Agregar(paq.Mail, paq.Descripcion, paq.Cantidad, paq.Tamano);
            if (paquete == null)
            {
                return Json(new { success = false, data = paq }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                paq.Id = paquete.ID.ToString();
                return Json(new { success = true, data = paq }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Regresar()
        {
            return RedirectToAction("Index", "UsuariosMenu");
        }
        public ActionResult Borrar(paqueton paq)
        {
            paquetesController.Borrar(paq.Id);
            return Json(new { success = true, data = paq }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Modificar(paqueton paq)
        {
            bool opa = paquetesController.Modificar(paq.Descripcion, paq.Cantidad, paq.Tamano, paq.Id);
            return Json(new { success = opa, data = paq }, JsonRequestBehavior.AllowGet);
        }
    }
}