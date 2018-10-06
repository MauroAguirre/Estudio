using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ejemplo dos capas");
            
            cliente c = new cliente();
            c.nombre ="ana";
            c.id = 1;
            c.ultimaOperacion = DateTime.Now;
            c.estado = 0;
            cliente.insertarCliente(c);

            Console.Read();
            

        }
    }
}
