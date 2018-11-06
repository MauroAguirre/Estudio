using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using BLL;
using MVC.Models;

namespace MVC.Controllers
{
    public class MenuComunicacionController : Controller
    {
        ProveedorController pc = new ProveedorController();
        ContactoController cc = new ContactoController();
        ComunicacionController comc = new ComunicacionController();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListarProveedores()
        {
            return Json(new { sucess = true, data = pc.Lista() }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListaContactos(Proveedor p)
        {
            return Json(new { sucess = true, data = cc.Lista(p.rut) }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListaComunicaciones()
        {
            List<Comunicacion> lista = comc.Lista();
            List<string> fechas = new List<string>();
            foreach (Comunicacion c in lista)
            {
                fechas.Add(c.fecha.ToString().Substring(0,10));
            }
            return Json(new { sucess = true, data = lista ,fechas}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Agregar(Comunication c)
        {
            Comunicacion nueva = comc.Agregar(new Comunicacion() { comentario = c.comentario, fecha = DateTime.Today, tipo = c.tipo }, c.contacto);
            string fecha = nueva.fecha.ToString().Substring(0,10);
            return Json(new { sucess = true,data=  nueva,fecha}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "MenuPrincipal"));
        }
    }
}