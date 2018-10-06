using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaAgenda.bll;

namespace MegaAgenda
{
    class Program
    {
        static void Main(string[] args)
        {

            AgendaController agendaController = new AgendaController();
            Console.WriteLine("nombre de la agenda");
            String nombre = Console.ReadLine();
            DateTime fechaCreacion = System.DateTime.Now;
            agendaController.crear(nombre, fechaCreacion);
            Console.ReadKey();

        }
    }
}
