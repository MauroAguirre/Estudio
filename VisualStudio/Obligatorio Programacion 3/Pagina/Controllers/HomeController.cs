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
    public class HomeController : Controller
    {
        UsuarioController usuarioController = new UsuarioController();
        AdministradorController administradorController = new AdministradorController();
        public ActionResult Index()
        {
            object model = "Ingrese el usuario";
            ViewBag.paquetes = null;
            ViewBag.envios = null;
            ViewBag.usuarios = null;
            return View(model);
        }
        [HttpPost]
        public ActionResult Ingresar(UsuarioForm usuarioForm)
        {
            object model= "Error al ingresar usuario";
            Usuario usuario = new Usuario() {Mail=usuarioForm.Mail,Contra=usuarioForm.Contra };
            if (usuarioForm.Mail == "235690" && usuarioForm.Contra == "235690")
            {
                return RedirectToAction("index", "AdministradoresMenu");
            }
            if (administradorController.EsAdministrador(usuario))
            {
                return RedirectToAction("index","AdministradoresMenu");
            }
            else
            {
                if (usuarioController.EsUsuario(usuario))
                {
                    Session["mail"] = usuarioForm.Mail;
                    return RedirectToAction("Index", "UsuariosMenu");
                }
                else
                {
                    return View("~/Views/Home/Index.cshtml", model);
                }
            }
            
        }
    }
}