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
    public class MenuArticuloProveedorController : Controller
    {
        ProveedorController pc = ProveedorController.Instancia();
        ArticuloController ac = ArticuloController.Instancia();
        ArticuloProveedorController apc = ArticuloProveedorController.Instancia();
        public ActionResult MenuArticuloProveedor()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            return View();
        }
        public ActionResult Agregar(ArticuloProv articuloProv)
        {
            DateTime fec = DateTime.Now;
            fec.AddHours(DateTime.Now.Hour);
            ArticuloProveedor nuevo = apc.Agregar(articuloProv.proveedor, articuloProv.articulo, articuloProv.costo, fec);
            if (nuevo != null)
                return Json(new { success = true, data = nuevo, fecha = nuevo.fecha.ToString().Substring(0,10) }, JsonRequestBehavior.AllowGet);
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListarArticulosProveedor(ArticuloProv a)
        {
            List<ArticuloProveedor> lista = apc.Lista(a.proveedor);
            List<String> fechas = new List<string>();
            for (int i = 0; i < lista.Count; i++)
            {
                fechas.Add(lista.ElementAt(i).fecha.ToString().Substring(0, 10));
            }
            return Json(new { success = true, data = lista , fechas}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListarProveedores()
        {
            return Json(new { success = true, data = pc.Lista() }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListarArticulos()
        {
            return Json(new { success = true, data = ac.Lista() }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
    }
}