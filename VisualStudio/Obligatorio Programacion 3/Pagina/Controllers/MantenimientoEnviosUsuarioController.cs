using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Pagina.Models;
using Dominio;

namespace Pagina.Controllers
{
    public class MantenimientoEnviosUsuarioController : Controller
    {
        EnvioController envioController = new EnvioController();
        PaquetesController paquetesController = new PaquetesController();
        public ActionResult Index()
        {
            List<Paquete> paquetesSeleccionados = new List<Paquete>();
            Session["paquetes"] = paquetesSeleccionados;
            string mail = Session["mail"] as string;
            ViewBag.mail = mail;
            ViewBag.paquetes = paquetesController.DarPaquetesDeUsuarioDisponibles(mail);
            ViewBag.envios = envioController.DarEnviosDeUsuario(mail);
            return View();
        }
        public ActionResult Regresar()
        {
            return RedirectToAction("Index", "UsuariosMenu");
        }
        public ActionResult AgregarPaq(IdMail idMail)
        {
            var paquetes = paquetesController.AgregarPaq(Session["paquetes"] as List<Paquete>, idMail.Id,idMail.Mail);
            if (paquetes != null)
            {
                Session["paquetes"] = paquetes;
                Paquete paquete = paquetesController.DarUnPaquete(idMail.Id);
                return Json(new { success = true, data = paquete }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false , data = idMail }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult BorrarPaq(IdMail idMail)
        {
            List<Paquete> paquetes = Session["paquetes"] as List<Paquete>;
            paquetes = paquetesController.BorrarPaq(paquetes, idMail.Id);
            Session["paquetes"] = paquetes;
            return Json(new { success = true, data = idMail }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AgregarEnv(Envitito env)
        {
            List<Paquete> paquetitos = Session["paquetes"] as List<Paquete>;
            env.Paquetes = paquetitos;
            List<Paquete> paq = envioController.Agregar(env.Envio, env.Llegada, env.Direccion, env.Mail,env.Paquetes);
            if (paq != null)
            {
                Session["paquetes"] = new List<Paquete>();
                return Json(new { success = true, data = paquetitos }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, data = paq }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}