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
    public class MenuRegistroController : Controller
    {
        RegistroController rc = RegistroController.Instancia();
        ArticuloController ac = ArticuloController.Instancia();
        public ActionResult MenuRegistro()
        {
            if (Session["conectado"] == null)
                return RedirectToAction("MenuLogin", "MenuLogin");
            return View();
        }
        public ActionResult ListaRegistro()
        {
            List<Registro> lista = rc.Lista();
            List<String> fechas = new List<string>();
            for (int i = 0; i < lista.Count; i++)
            {
                fechas.Add(lista.ElementAt(i).fecha.ToString().Substring(0, 10));
            }
            return Json(new { success = true, data = lista,fechas }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListaArticulosStock()
        {
            List<Articulo> lista = ac.Lista();
            List<ArtStocEstado> listado = new List<ArtStocEstado>();
            foreach (Articulo a in lista)
            {
                string estado;
                int stock = rc.Stock_Producto(a.id);
                if ( stock <= a.miniStock)
                    estado = "Critico";
                else
                    estado = "Correcto";
                listado.Add(new ArtStocEstado() { articulo=a,estado=estado,stock=stock});
            }
            return Json(new { success = true, data = listado }, JsonRequestBehavior.AllowGet);
        }
    }
}