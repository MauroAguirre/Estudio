using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using BLL;
using MVC.Models;

namespace MVC.Controllers
{
    public class MenuComunicacionController : Controller
    {
        ProveedorController pc = ProveedorController.Instancia();
        ContactoController cc = ContactoController.Instancia();
        ComunicacionController comc = ComunicacionController.Instancia();
        public ActionResult MenuComunicacion()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            return View();
        }
        public ActionResult ListarProveedores()
        {
            return Json(new { success = true, data = pc.Lista() }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListaContactos(Proveedor p)
        {
            return Json(new { success = true, data = cc.Lista(p.rut) }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListaComunicaciones()
        {
            List<Comunicacion> lista = comc.Lista();
            List<string> fechas = new List<string>();
            foreach (Comunicacion c in lista)
            {
                fechas.Add(c.fecha.ToString().Substring(0,10));
            }
            return Json(new { success = true, data = lista ,fechas}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Agregar(Comunication c)
        {
            if(c.contacto==0)
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            if (c.comentario == null)
                c.comentario = "";
            Comunicacion nueva = comc.Agregar(new Comunicacion() { comentario = c.comentario, fecha = DateTime.Today, tipo = c.tipo }, c.contacto);
            string fecha = nueva.fecha.ToString().Substring(0,10);
            return Json(new { success = true,data=  nueva,fecha}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
    }
}