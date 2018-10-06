using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pagina.Models;
using BLL;
using Dominio;
namespace Pagina.Controllers
{
    public class MantenimientoUsuariosController : Controller
    {
        UsuarioController usuarioController = new UsuarioController();
        public ActionResult Index()
        {
            ViewBag.usuarios = usuarioController.DarUsuarios();
            return View();
        }
        public ActionResult Agregar(Usuario usu)
        {
            return Json(new { success = usuarioController.Agregar(usu) != null ? true : false, data = usu }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Regresar()
        {
            return RedirectToAction("Index", "AdministradoresMenu");
        }
        public ActionResult Borrar(Usuario usu)
        {
            usuarioController.Borrar(usu.Mail);
            return Json(new { success = true, data = usu }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Modificar(Usuario usu)
        {
            usuarioController.Modificar(usu);
            return Json(new { success = true, data = usu }, JsonRequestBehavior.AllowGet);
        }
    }
}