using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace repaso_parcial_maurin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.hola = "Bienvenido";
            ViewBag.otra = "Chabon";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Agregar()
        {
            ViewBag.hola = "hola";
            using (var db = new TelevisionContext())
            {
                Paquete paquete = new Paquete() { descripcion = "dsads", nombre = "Buenasos canales" ,id=1};
                db.SaveChanges();
                PaqueteCanal paquetecanal = new PaqueteCanal() { Canal = db.canales.Find(1), paquete = db.paquetes.Find(1),id=1 };
                db.SaveChanges();
                Venta venta1 = new Venta() { cliente = db.clientes.Find(1), costo = 30, fecha = DateTime.Now, paquete = db.paquetes.Find(1) ,id=1};
                db.SaveChanges();
                //ViewBag.otra = db.paquetes.SqlQuery("select * from Paquetes").ToList()[0].nombre;
            }
            return View("~/Views/Home/Index.cshtml");
        }
    }
}