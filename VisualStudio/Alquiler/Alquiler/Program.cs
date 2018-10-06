using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;
using BLL;

namespace Alquiler
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteController clienteController = new ClienteController();
            string nombre = "pablo";
            int id= 1;
            clienteController.Agregar(id, nombre);
            
        }
    }
}
