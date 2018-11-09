using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using BLL;

namespace MVC.Controllers
{
    public class MenuLoginController : Controller
    {
        UsuarioController uc = UsuarioController.Instancia();
        public ActionResult MenuLogin()
        {
            return View();
        }
        public ActionResult Ingresar(Usuario u)
        {
            if (uc.Verificar_login(u))
            {
                Session["conectado"] = "conectado";
                return Json(new { url = Url.Action("MenuPrincipal", "MenuPrincipal"), success = true});
            }
            else
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }
    }
}