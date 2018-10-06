using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            do
            {
                Console.Clear();
                Console.WriteLine("Cual es tu nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Hello " + nombre);
                Console.WriteLine("Cual es tu edad " + nombre);
                edad = int.Parse(Console.ReadLine());
                if (edad >= 18)
                    Console.WriteLine("Sos mayor");
                else
                    Console.WriteLine("Sos Menor");
                for (int i = 1; i < edad; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            } while (edad != 0);
            Cliente uncliente = new Cliente();
            uncliente.Cedula = 20;
            Console.WriteLine(uncliente.Cedula);
            Console.ReadKey();
        }
    }
}
