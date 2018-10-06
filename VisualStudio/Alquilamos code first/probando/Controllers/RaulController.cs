using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using probando.Models;
using Dominio;
using BLL;
namespace probando.Controllers
{
    public class RaulController : Controller
    {
        // GET: Raul
        public ActionResult Index()
        {
            Raul raul = new Raul() { Nombre = "pepe"};
            return View(raul);
            
        }
        /*
        [ActionName("Save")]
        [HttpPost]
        public ActionResult Index()
        {
            Raul raul = new Raul() { Nombre = "pepe" };
            return View(raul);

        }
        */
        public ActionResult Save(Raul raul)
        {
            //ClienteController clienteController = new ClienteController();
            //Cliente cliente = new Cliente() { Documento = int.Parse(raul.Apellido),Nombre = raul.Nombre};
            //clienteController.Agregar(cliente);
            return View(raul);
        }
    }
}