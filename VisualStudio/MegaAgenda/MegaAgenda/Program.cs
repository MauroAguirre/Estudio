using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace MegaAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaController agendaController = new AgendaController();
            ContactoController contactoController = new ContactoController();
            int direccion = 0;
            string respuesta;
            string mail;
            string fec;
            do
            {
                Console.Clear();
                Menu();
                respuesta = Console.ReadLine();
                bool correcto = int.TryParse(respuesta, out direccion);
                string cual, nuevo;
                switch (direccion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre de la agenda");
                        string nombre = Console.ReadLine();
                        DateTime fecha = DateTime.Now;
                        agendaController.Crear(nombre, fecha);
                        break;
                    case 2:
                        agendaController.Mostrar();
                        Console.WriteLine("Eliga la agenda a modificar");
                        cual = Console.ReadLine();
                        Console.WriteLine("Eliga el nuevo nombre de la agenda");
                        nuevo = Console.ReadLine();
                        agendaController.Modificar(cual, nuevo);
                        break;
                    case 3:
                        agendaController.Mostrar();
                        Console.WriteLine("Eliga la agenda a borrar");
                        cual = Console.ReadLine();
                        agendaController.Borrar(cual);
                        break;
                    case 4:
                        agendaController.Mostrar();
                        Console.WriteLine("presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        agendaController.Mostrar();
                        Console.WriteLine("Eliga una agenda para agregar el contacto");
                        cual = Console.ReadLine();
                        Console.WriteLine("Ingrese nombre de contacto");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese mail de contacto");
                        mail = Console.ReadLine();
                        Console.WriteLine("Ingrese la fecha de nacimiento del contacto");
                        fec = Console.ReadLine();
                        DateTime fechaNacimiento = new DateTime(int.Parse(fec.Substring(6, 4)), int.Parse(fec.Substring(3, 2)), int.Parse(fec.Substring(0, 2)));
                        //DateTime fechaNacimiento = DateTime.Now;
                        contactoController.Crear(nombre, fechaNacimiento, mail,cual);
                        break;
                    case 6:
                        agendaController.Mostrar();
                        Console.WriteLine("Eliga la agenda que quiera ver los contactos");
                        cual = Console.ReadLine();
                        contactoController.Mostrar(cual);
                        Console.WriteLine("presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                }
            } while (direccion != 8);
        }
        public static void Menu()
        {
            Console.WriteLine("     Menu");
            Console.WriteLine("");
            Console.WriteLine("1-Alta de agenda");
            Console.WriteLine("2-Modificar agenda");
            Console.WriteLine("3-Borrar agenda");
            Console.WriteLine("4-Ver agenda");
            Console.WriteLine("5-Alta de contacto");
            Console.WriteLine("6-Ver contactos");
            Console.WriteLine("7-Borrar agenda");
            Console.WriteLine("8-Salir");
        }
    }
}
