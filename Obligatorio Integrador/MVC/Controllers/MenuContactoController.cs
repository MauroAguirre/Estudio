using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Common;
using MVC.Models;

namespace MVC.Controllers
{
    public class MenuContactoController : Controller
    {
        ContactoController cc = ContactoController.Instancia();
        ProveedorController pc = ProveedorController.Instancia();
        public ActionResult MenuContacto()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
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

        public ActionResult Modificar(Contacto c)
        {
            cc.Modificar(c.id,c.nombre,c.telefono);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Borrar(Contacto c)
        {
            cc.Borrar(c.id);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
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