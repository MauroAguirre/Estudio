using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Dominio;
using MVC.Models;

namespace MVC.Controllers
{
    public class MenuContactoController : Controller
    {
        BLL.ContactoController cc = new BLL.ContactoController();
        BLL.ProveedorController pc = new BLL.ProveedorController();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Agregar(ContactoProv contacto)
        {
            Contacto nuevo = cc.Agregar(contacto.proveedor,contacto.nombre,contacto.telefono);
            if (nuevo != null)
            {
                ContactoProv c = new ContactoProv() { nombre = nuevo.nombre, telefono = nuevo.telefono, proveedor = nuevo.proveedor.rut };
                return Json(new { success = true, data = c }, JsonRequestBehavior.AllowGet);
            }
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Modificar(ContactoProv c)
        {
            cc.Modificar(c.proveedor,c.nombre,c.telefono);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Borrar(ContactoProv c)
        {
            cc.Borrar(c.proveedor,c.nombre);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "MenuPrincipal"));
        }
        public ActionResult ListarProveedores()
        {
            return Json(new { success = true, data = pc.Lista() }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListarContactos(ContactoProv contacto)
        {
            var dsd = cc.Lista(contacto.proveedor);
            List<ContactoProv> contactos = new List<ContactoProv>();
            foreach(Contacto c in cc.Lista(contacto.proveedor))
            {
                contactos.Add(new ContactoProv() { nombre = c.nombre, telefono = c.telefono, proveedor = c.proveedor.rut });
            }
            return Json(new { success = true, data = contactos }, JsonRequestBehavior.AllowGet);
        }
    }
}