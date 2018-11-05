using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using BLL;

namespace MVC.Controllers
{
    public class MenuRegistroController : Controller
    {
        RegistroController rc = new RegistroController();
        public ActionResult Index()
        {
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
    }
}