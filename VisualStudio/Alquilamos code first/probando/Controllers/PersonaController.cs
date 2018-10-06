using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using BLL;
using probando.Models;
namespace probando.Controllers
{
    public class PersonaController : Controller
    {
        ClienteController clienteController = new ClienteController();
        FuncionarioController funcionarioController = new FuncionarioController();
        public ActionResult Index()
        {
            Personas personas = new Personas(clienteController.DarClientes(), funcionarioController.DarFuncionarios());
            return View(personas);
        }
        [ActionName("AltaCliente")]
        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            clienteController.Agregar(cliente);
            return RedirectToAction("Index", "Persona");
        }
        [ActionName("AltaFuncionario")]
        [HttpPost]
        public ActionResult Index(Funcionario funcionario)
        {
            funcionarioController.Agregar(funcionario);
            return RedirectToAction("Index", "Persona");
        }
        public ActionResult Modificar(Cliente cliente)
        {
            clienteController.Eliminar(cliente);
            return RedirectToAction("Index", "Persona");
        }
    }
}