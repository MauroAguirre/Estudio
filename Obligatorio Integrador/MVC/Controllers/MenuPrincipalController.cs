using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class MenuPrincipalController : Controller
    {
        public ActionResult MenuPrincipal()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            return View();
        }
        public ActionResult Usuarios()
        {
            return Json(Url.Action("MenuUsuario", "MenuUsuario"));
        }
        public ActionResult Articulos()
        {
            return Json(Url.Action("MenuArticulo", "MenuArticulo"));
        }
        public ActionResult Proveedores()
        {
            return Json(Url.Action("MenuProveedor", "MenuProveedor"));
        }
        public ActionResult Contactos()
        {
            return Json(Url.Action("MenuContacto", "MenuContacto"));
        }
        public ActionResult Comunicaciones()
        {
            return Json(Url.Action("MenuComunicacion", "MenuComunicacion"));
        }
        public ActionResult ArticulosProveedor()
        {
            return Json(Url.Action("MenuArticuloProveedor", "MenuArticuloProveedor"));
        }
        public ActionResult Compras()
        {
            return Json(Url.Action("MenuCompra", "MenuCompra"));
        }
        public ActionResult Ventas()
        {
            return Json(Url.Action("MenuVenta", "MenuVenta"));
        }
        public ActionResult Registros()
        {
            return Json(Url.Action("MenuRegistro", "MenuRegistro"));
        }
        public ActionResult MenuListadoArticuloBajos()
        {
            return Json(Url.Action("MenuListadoArticuloBajos", "MenuListadoArticuloBajos"));
        }
        public ActionResult ArticulosDebajo40()
        {
            return Json(Url.Action("MenuListadoArticulos40", "MenuListadoArticulos40"));
        }
        public ActionResult PrecioArticuloProveedor()
        {
            return Json(Url.Action("MenuListadoPrecioArticuloProveedor", "MenuListadoPrecioArticuloProveedor"));
        }
        public ActionResult Salir()
        {
            Session["conectado"] = null;
            return Json(Url.Action("MenuLogin", "MenuLogin"));
        }
    }
}