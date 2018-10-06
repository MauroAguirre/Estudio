using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pagina.Controllers
{
    public class UsuariosMenuController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Paquetes()
        {
            return RedirectToAction("Index","MantenimientoPaquetes");
        }
        public ActionResult Envios()
        {
            return RedirectToAction("Index", "MantenimientoEnviosUsuario");
        }
    }
}