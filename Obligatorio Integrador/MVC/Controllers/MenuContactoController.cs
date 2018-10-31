using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Dominio;

namespace MVC.Controllers
{
    public class MenuContactoController : Controller
    {
        BLL.ContactoController cc = new BLL.ContactoController();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Agregar(Contacto contacto)
        {
            Contacto nuevo = cc.Agregar(contacto);
            if (nuevo != null)
                return Json(new { success = true, data = nuevo }, JsonRequestBehavior.AllowGet);
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Modificar(Contacto c)
        {
            cc.Modificar(c);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Borrar(String rut,String nombre)
        {
            cc.Borrar(rut,nombre);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "MenuPrincipal"));
        }
        public ActionResult ListarProveedores()
        {
            ProveedorController pc = new ProveedorController();
            return Json(new { success = true, data = pc.Lista() }, JsonRequestBehavior.AllowGet);
        }
    }
}