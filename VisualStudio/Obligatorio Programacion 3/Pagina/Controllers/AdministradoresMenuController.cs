using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pagina.Controllers
{
    public class AdministradoresMenuController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MantenimientoUsuarios()
        {
            return RedirectToAction("Index", "MantenimientoUsuarios");
        }
        public ActionResult MantenimientoAdministradores()
        {
            return RedirectToAction("Index", "MantenimientoAdministradores");
        }
        public ActionResult MantenimientoDirecciones()
        {
            return RedirectToAction("Index", "MantenimientoDirecciones");
        }
        public ActionResult MantenimientoEnviosAdministrador()
        {
            return RedirectToAction("Index", "MantenimientoEnviosAdm");
        }
    }
}