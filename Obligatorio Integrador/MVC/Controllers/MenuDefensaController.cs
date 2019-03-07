using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using BLL;
using Common;

namespace MVC.Controllers
{
    public class MenuDefensaController : Controller
    {
        ArticuloController ac = ArticuloController.Instancia();
        ProveedorController pc = ProveedorController.Instancia();
        public ActionResult MenuDefensa()
        {
            return View();
        }
        public ActionResult ListaArticulos()
        {
            return Json(new { success = true, data = ac.Lista() }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Buscar(Articulo articulo)
        {
            List<Proveedor> proveedores = pc.ProveedoresDeArticulos(articulo.id);
            List<ProveedorContactos> listita = new List<ProveedorContactos>();
            foreach (Proveedor p in proveedores)
            {
                ProveedorContactos nuevo = new ProveedorContactos();
                nuevo.contactos = new string[4];
                nuevo.proveedor = p;
                for (int i = 0; i < 4; i++)
                {
                    nuevo.contactos[i] = "No tiene";
                }
                int num = 0;
                foreach (Contacto c in p.contactos)
                {
                    nuevo.contactos[num] = c.nombre;
                    num++;
                    c.proveedor = null;
                }
                listita.Add(nuevo);
            }
            return Json(new { success = true, data = listita }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("MenuPrincipal", "MenuPrincipal"));
        }
    }
}