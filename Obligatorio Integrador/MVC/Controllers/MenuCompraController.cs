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
    public class MenuCompraController : Controller
    {
        LineaFacturaController lfc = new LineaFacturaController();
        FacturaCompraController fcc = new FacturaCompraController();
        ArticuloProveedorController apc = new ArticuloProveedorController();
        ProveedorController pc = new ProveedorController();
        public ActionResult Index()
        {
            Session["lineaFacs"] = new List<LineaFac>();
            return View();
        }
        public ActionResult ListarProveedores()
        {
            return Json(new { success = true, data = pc.Lista() }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "MenuLogin"));
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
                    if (linea.articuloProveedor == lineaFac.articuloProveedor)
                    {
                        linea.cantidad = lineaFac.cantidad;
                        return Json(new { success = true, data = lineaFac, modificar = true }, JsonRequestBehavior.AllowGet);
                    }
                }
                lineaFacs.Add(lineaFac);
                Session["lineaFacs"] = lineaFacs;
                return Json(new { success = true, data = lineaFac,modificar=false }, JsonRequestBehavior.AllowGet);
            } 
        }
        public ActionResult AgregarCompra(Compra c)
        {
            FacturaCompra fac = fcc.Agregar(c.fecha,c.proveedor);
            List<LineaFac> lineaFacs = (List<LineaFac>)Session["lineaFacs"];
            foreach (LineaFac li in lineaFacs)
            {
                li.factura = fac.id;
            }
            var dsds = lfc.AgregarLista(lineaFacs);
            return Json(new { success = true, data = fac }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListaFacturaCompra()
        {
            return Json(new { sucess = true, data = fcc.Lista() }, JsonRequestBehavior.AllowGet);
        }
    }
}