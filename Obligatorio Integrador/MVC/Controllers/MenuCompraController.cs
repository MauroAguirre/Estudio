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
    public class MenuCompraController : Controller
    {
        LineaFacturaController lfc = LineaFacturaController.Instancia();
        FacturaCompraController fcc = FacturaCompraController.Instancia();
        ArticuloProveedorController apc = ArticuloProveedorController.Instancia();
        ProveedorController pc = ProveedorController.Instancia();
        public ActionResult MenuCompra()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            Session["lineaFacs"] = new List<LineaFac>();
            return View();
        }
        public ActionResult ListarProveedores()
        {
            return Json(new { success = true, data = pc.Lista() }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
        public ActionResult ListarArticulosProveedor(ArticuloProv articuloProv)
        {
            return Json(new { sucess = true, data = apc.Lista_ultima_fecha(articuloProv.proveedor) }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ResetiarListaEspera()
        {
            Session["lineaFacs"] = new List<LineaFac>();
            return Json(new { success = true}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Agregar_ModificarListarFacturaEspera(LineaFac lineaFac)
        {
            if (lineaFac.cantidad < 1)
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            else
            {
                List<LineaFac> lineaFacs = (List<LineaFac>)Session["lineaFacs"];
                foreach (LineaFac linea in lineaFacs)
                {
                    if (linea.articulo == lineaFac.articulo)
                    {
                        linea.cantidad = lineaFac.cantidad;
                        linea.precio = lineaFac.precio;
                        return Json(new { success = true, data = lineaFac, modificar = true }, JsonRequestBehavior.AllowGet);
                    }
                }
                lineaFacs.Add(lineaFac);
                Session["lineaFacs"] = lineaFacs;
                return Json(new { success = true, data = lineaFac,modificar=false }, JsonRequestBehavior.AllowGet);
            } 
        }
        public ActionResult CambiarTotal()
        {
            int costo = 0;
            List<LineaFac> lineaFacs = (List<LineaFac>)Session["lineaFacs"];
            foreach (LineaFac linea in lineaFacs)
            {
                costo += linea.precio;
            }
            return Json(new { success = true, data = costo }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Borrar_lineafacturaespera(LineaFac lineaFac)
        {
            List<LineaFac> lineaFacs = (List<LineaFac>)Session["lineaFacs"];
            foreach (LineaFac linea in lineaFacs)
            {
                if (linea.articulo == lineaFac.articulo)
                {
                    lineaFacs.Remove(linea);
                    break;
                }
            }
            return Json(new { success = true, data = lineaFac, modificar = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AgregarCompra(Compra c)
        {
            List<LineaFac> lineaFacs = (List<LineaFac>)Session["lineaFacs"];
            if(lineaFacs.Count==0)
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            FacturaCompra fac = fcc.Agregar(DateTime.Today, c.proveedor);
            foreach (LineaFac li in lineaFacs)
            {
                lfc.Agregar(li.cantidad,li.precio, fac.id, li.articulo, true);
            }
            int total = fcc.TotalFactura(fac.id);
            return Json(new { success = true, data = fac,fecha=fac.fecha.ToString().Substring(0, 10) ,total}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListaFacturaCompra(Compra c)
        {
            List<FacturaCompra> lista = fcc.Lista(c.proveedor);
            List<string> fechas = new List<string>();
            List<int> totales = new List<int>();
            foreach (FacturaCompra fac in lista)
            {
                totales.Add(fcc.TotalFactura(fac.id));
                fechas.Add(fac.fecha.ToString().Substring(0, 10));
            }
            return Json(new { sucess = true, data = lista,fechas ,totales}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Imprimir(FacturaTipo f)
        {
            Session["factura"] = f;
            return Json(Url.Action("MenuImprimir", "MenuImprimir"));
        }
    }
}