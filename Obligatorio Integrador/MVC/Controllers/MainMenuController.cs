using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class MainMenuController : Controller
    {
        // GET: MainMenu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Usuarios()
        {
            return Json(Url.Action("Index", "Users"));
        }
        public ActionResult Salir()
        {
            return Json(Url.Action("Index", "Login"));
        }
    }
}