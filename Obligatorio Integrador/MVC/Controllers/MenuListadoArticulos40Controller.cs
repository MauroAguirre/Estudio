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
    public class MenuListadoArticulos40Controller : Controller
    {
        RegistroController rc = RegistroController.Instancia();
        ArticuloController ac = ArticuloController.Instancia();
        public ActionResult MenuListadoArticulos40()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            return View();
        }
        public ActionResult ListarArticulos40()
        {
            List<Articulo> articulos = ac.Articulos40();
            List<ArticuloStock> articulosStocks = new List<ArticuloStock>();
            foreach (Articulo a in articulos)
            {
                int stock = rc.Stock_Producto(a.id);
                articulosStocks.Add(new ArticuloStock() { articulo=a,stock=stock});
            }
            return Json(new { success = true, data = articulosStocks }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
    }
}