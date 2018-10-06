using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using BLL;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteController cc = new ClienteController();
            Cliente cliente1 = new Cliente() { Nombre = "Pedro", Apellido = "Aguirre", Mail = "Pedro@gmail.com", Telefono = 1231323 };
            Cliente cliente2 = new Cliente() { Nombre = "Lautaro", Apellido = "Caceres", Mail = "Lauta@gmail.com", Telefono = 1231231 };
            Cliente cliente3 = new Cliente() { Nombre = "Ezequiel", Apellido = "aeasease", Mail = "Ezezez@gmail.com", Telefono = 5435345 };
            cc.Agregar(cliente1);
            cc.Agregar(cliente2);
            cc.Agregar(cliente3);
            foreach (Cliente c in cc.DarClientes())
            {
                Console.WriteLine(c.Id + " " + c.Nombre + " " + c.Apellido + " " + c.Mail + " " + c.Telefono + "\n");
            }
            Console.ReadKey();
        }
    }
}
