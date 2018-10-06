using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using BLL;

namespace Alquilamos_code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteController clienteController = new ClienteController();

            string nombre = "pedro";
            int documento = 3213123;
            clienteController.Agregar(documento, nombre);

            //clienteController.Mostrar();
            foreach (Cliente cliente in clienteController.DarClientes())
            {
                Console.WriteLine(cliente.ID + " " + cliente.Nombre + " " + cliente.Documento+"\n");
            }
            Console.ReadKey();
        }
    }
}
