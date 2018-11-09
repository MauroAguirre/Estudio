using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using MVC.Models;
using BLL;

namespace MVC.Controllers
{
    public class MenuImprimirController : Controller
    {
        FacturaCompraController fcc = FacturaCompraController.Instancia();
        FacturaVentaController fvc = FacturaVentaController.Instancia();
        public ActionResult MenuImprimir()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            return View();
        }
        public ActionResult Listar()
        {
            int total;
            FacturaTipo fac = (FacturaTipo)Session["factura"];
            Factura factura;
            if (fac.compra)
            {
                total = fcc.TotalFactura(fac.factura);
                factura = fcc.UnaFactura(fac.factura);
            }
            else
            {
                total = fvc.TotalFactura(fac.factura);
                factura = fvc.UnaFactura(fac.factura);
            }
            string fecha = factura.fecha.ToString().Substring(0,10);
            return Json(new { success = true, data = factura,fac.compra,fecha,total }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
    }
}