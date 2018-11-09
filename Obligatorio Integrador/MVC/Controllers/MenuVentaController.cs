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
    public class MenuVentaController : Controller
    {
        RegistroController rc = RegistroController.Instancia();
        ArticuloController ac = ArticuloController.Instancia();
        FacturaVentaController fvc = FacturaVentaController.Instancia();
        LineaFacturaController lfc = LineaFacturaController.Instancia();
        public ActionResult MenuVenta()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            Session["lista"] = new List<ArticuloStock>();
            return View();
        }
        public ActionResult ListarArticulosConStock()
        {
            List<ArticuloStock> lista = new List<ArticuloStock>();
            List<Articulo> articulos = ac.Lista();
            foreach (Articulo a in articulos)
            {
                lista.Add(new ArticuloStock() { articulo = a, stock =rc.Stock_Producto(a.id)});
            }
            return Json(new { success = true ,lista}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AgregarListaEsperaFactura(ArticuloStock a)
        {
            List<ArticuloStock> lista = (List<ArticuloStock>) Session["lista"];
            if (a.stock < 1)
                return Json(new { success = false,cambio=true }, JsonRequestBehavior.AllowGet);
            if(rc.Stock_Producto(a.id)-a.stock<0)
                return Json(new { success = false, cambio=false }, JsonRequestBehavior.AllowGet);
            Boolean cambio;
            if (rc.Stock_Producto(a.id) - a.stock <= ac.Buscar(a.id).miniStock)
                cambio = false;
            else
                cambio = true;
            foreach (ArticuloStock art in lista)
            {
                if (art.id == a.id)
                {
                    art.precio = a.precio;
                    art.stock = a.stock;
                    return Json(new { success = true, data = a ,modificar=true, cambio }, JsonRequestBehavior.AllowGet);
                }
            }
            lista.Add(a);
            return Json(new { success = true,data=a ,modificar=false, cambio }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult BorrarListaEsperaFactura(ArticuloStock a)
        {
            List<ArticuloStock> lista = (List<ArticuloStock>)Session["lista"];
            foreach(ArticuloStock art in lista)
            {
                if (art.id == a.id)
                {
                    lista.Remove(art);
                    break;
                }
            }
            return Json(new { success = true, data = a }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ResetearListaEsperaFactura()
        {
            Session["lista"] = new List<ArticuloStock>();
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ResetiarTotal()
        {
            int costo = 0;
            List<ArticuloStock> lista = (List<ArticuloStock>)Session["lista"];
            foreach (ArticuloStock linea in lista)
            {
                costo += linea.precio;
            }
            return Json(new { success = true, data = costo }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
        //
        public ActionResult AgregarVenta(Venta c)
        {
            List<ArticuloStock> lineaFacs = (List<ArticuloStock>)Session["lista"];
            if (lineaFacs.Count == 0)
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            FacturaVenta fac = fvc.Agregar(DateTime.Today,c.descripcion );
            foreach (ArticuloStock li in lineaFacs)
            {
                lfc.Agregar(li.stock, li.precio, fac.id, li.id, false);
            }
            int total = fvc.TotalFactura(fac.id);
            return Json(new { success = true, data = fac, fecha = fac.fecha.ToString().Substring(0, 10), total }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListaFacturaVenta()
        {
            List<FacturaVenta> lista = fvc.Lista();
            List<string> fechas = new List<string>();
            List<int> totales = new List<int>();
            foreach (FacturaVenta fac in lista)
            {
                totales.Add(fvc.TotalFactura(fac.id));
                fechas.Add(fac.fecha.ToString().Substring(0, 10));
            }
            return Json(new { sucess = true, data = lista, fechas, totales }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Imprimir(FacturaTipo f)
        {
            Session["factura"] = f;
            return Json(Url.Action("MenuImprimir", "MenuImprimir"));
        }
    }
}