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
            PaisController paisController = new PaisController();
            int pais,cual,direccion = 0;
            String nombre,respuesta,mail,fec,telefono,tipo,nombre_agenda;
            DateTime fecha;
            bool correcto;
            do
            {
                Console.Clear();
                Menu();
                respuesta = Console.ReadLine();
                correcto = int.TryParse(respuesta, out direccion); 
                switch (direccion)
                {
                    case 1:
                        agendaController.Mostrar();
                        Console.WriteLine("Eliga la base de datos a guardar el contacto");
                        nombre_agenda = agendaController.Nombre_agenda(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Ingrese el nombre del contacto");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el mail del contacto");
                        mail = Console.ReadLine();
                        Console.WriteLine("Ingrese la fecha de nacimiento del contacto");
                        fec = Console.ReadLine();
                        paisController.Mostrar();
                        Console.WriteLine("Eliga el numero del pais de del contacto");
                        pais = int.Parse(Console.ReadLine());
                        fecha = new DateTime(int.Parse(fec.Substring(6, 4)), int.Parse(fec.Substring(3, 2)), int.Parse(fec.Substring(0, 2)));
                        contactoController.Crear(nombre,mail,fecha,paisController.Elegir_Pais(pais), nombre_agenda);
                        break;
                    case 2:
                        contactoController.Mostrar();
                        Console.WriteLine("Eliga el numero del contacto para modificar");
                        cual = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nuevo mail");
                        respuesta = Console.ReadLine();
                        contactoController.Modificar_mail(cual,respuesta);
                        break;
                    case 3:
                        contactoController.Mostrar();
                        Console.WriteLine("Eliga el numero del contacto para eliminar");
                        cual = int.Parse(Console.ReadLine());
                        contactoController.Borrar(cual);
                        break;
                    case 4:
                        contactoController.Mostrar();
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el mail del contacto que quiere buscar");
                        respuesta = Console.ReadLine();
                        contactoController.Mostrar_contacto_por_mail(respuesta);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.WriteLine("Ingrese el nombre de la agenda");
                        respuesta = Console.ReadLine();
                        agendaController.Crear(respuesta);
                        break;
                    case 12:
                        agendaController.Mostrar();
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (direccion != 13);
        }
        public static void Menu()
        {
            Console.WriteLine("     Menu");
            Console.WriteLine("");
            Console.WriteLine("1-Alta de contacto");
            Console.WriteLine("2-Modificar contacto");
            Console.WriteLine("3-Eliminar contacto");
            Console.WriteLine("4-Mostrar contactos");
            Console.WriteLine("5-Buscar contacto por mail");
            Console.WriteLine("6-Buscar contacto por pais");
            Console.WriteLine("7-Agregar cita");
            Console.WriteLine("8-Modificar cita");
            Console.WriteLine("9-Eliminar cita");
            Console.WriteLine("10-Mostrar citas de un contacto");
            Console.WriteLine("11-Alta agenda");
            Console.WriteLine("12-Mostrar agendas");
        }
    }
}
