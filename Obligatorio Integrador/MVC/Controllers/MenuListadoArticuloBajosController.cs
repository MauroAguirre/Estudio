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
    public class MenuListadoArticuloBajosController : Controller
    {
        RegistroController rc = RegistroController.Instancia();
        ArticuloController ac = ArticuloController.Instancia();
        public ActionResult MenuListadoArticuloBajos()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            return View();
        }
        public ActionResult ListaArticulos()
        {
            List<Articulo> articulos = ac.Lista();
            List<ArticuloStock> lista = new List<ArticuloStock>();
            foreach (Articulo a in articulos)
            {
                int stock = rc.Stock_Producto(a.id);
                if (stock <= a.miniStock)
                 lista.Add(new ArticuloStock() {articulo=a,stock=stock });
            }
            return Json(new { success = true, data = lista }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
    }
}