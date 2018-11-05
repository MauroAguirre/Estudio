using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class MenuPrincipalController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Usuarios()
        {
            return Json(Url.Action("Index", "MenuUsuario"));
        }
        public ActionResult Articulos()
        {
            return Json(Url.Action("Index", "MenuArticulo"));
        }
        public ActionResult Proveedores()
        {
            return Json(Url.Action("Index", "MenuProveedor"));
        }
        public ActionResult Contactos()
        {
            return Json(Url.Action("Index", "MenuContacto"));
        }
        public ActionResult ArticulosProveedor()
        {
            return Json(Url.Action("Index", "MenuArticuloProveedor"));
        }
        public ActionResult Compras()
        {
            return Json(Url.Action("Index", "MenuCompra"));
        }
        public ActionResult Registros()
        {
            return Json(Url.Action("Index", "MenuRegistro"));
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "MenuLogin"));
        }
    }
}