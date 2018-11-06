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
    public class MenuVentaController : Controller
    {
        RegistroController rc = new RegistroController();
        ArticuloController ac = new ArticuloController();
        public ActionResult Index()
        {
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
            if(a.stock<1)
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            foreach (ArticuloStock art in lista)
            {
                if (art.id == a.id)
                {
                    art.stock = a.stock;
                    return Json(new { success = true, data = a ,modificar=true}, JsonRequestBehavior.AllowGet);
                }
            }
            lista.Add(a);
            return Json(new { success = true,data=a ,modificar=false}, JsonRequestBehavior.AllowGet);
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
        /*
        public ActionResult AgregarVenta()
        {

        }
        */
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "MenuPrincipal"));
        }
    }
}