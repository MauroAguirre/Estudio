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
    public class MenuListadoPrecioArticuloProveedorController : Controller
    {
        ProveedorController pc = ProveedorController.Instancia();
        ArticuloController ac = ArticuloController.Instancia();
        ArticuloProveedorController apc = ArticuloProveedorController.Instancia();
        public ActionResult MenuListadoPrecioArticuloProveedor()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            return View();
        }
        public ActionResult ListarProveedores()
        {
            return Json(new { success = true, data = pc.Lista() }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListarArticulosProveedor(Proveedor p)
        {
            List<ArticuloProveedor> lista = apc.Lista(p.rut);
            List<ArticuloProveedor> articulosprov = new List<ArticuloProveedor>();
            Boolean esta = false;
            foreach (ArticuloProveedor l in lista)
            {
                esta = false;
                foreach (ArticuloProveedor artPro in articulosprov)
                {
                    if (artPro.articulo == l.articulo)
                    {
                        esta = true;
                        break;
                    }
                }
                if (!esta)
                    articulosprov.Add(l);
            }
            return Json(new { success = true, data = articulosprov }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListarPrecios(ArticuloProv a)
        {
            List<ArticuloProveedor> lista = apc.PorArticuloProveedor(a.articulo, a.proveedor);
            List<string> fechas = new List<string>();
            foreach(ArticuloProveedor art in lista)
            {
                fechas.Add(art.fecha.ToString().Substring(0, 10));
            }
            return Json(new { success = true, data = lista ,fechas}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
    }
}