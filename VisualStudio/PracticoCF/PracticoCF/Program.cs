using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace PracticoCF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new RestauranteContext())
            {
                string salir = string.Empty;
                while (salir != "0")
                {
                    //Crear y guardar clientes y direcciones
                    Console.WriteLine("Ingrese el nombre para cliente: ");
                    var nom = Console.ReadLine();

                    Console.WriteLine("Ingrese el apellido del cliente: ");
                    var ape = Console.ReadLine();

                    Console.WriteLine("Ingrese el mail del cliente: ");
                    var mail = Console.ReadLine();

                    Console.WriteLine("Ingrese la cedula del cliente: ");
                    var ci = Console.ReadLine();

                    Console.WriteLine("Ingrese la calle del cliente: ");
                    var calle = Console.ReadLine();

                    Console.WriteLine("Ingrese el numero de puerta del cliente: ");
                    var numero = int.Parse(Console.ReadLine());

                    var cliente = new Cliente { Nombre = nom, Apellido = ape, Ci = ci ,Mail = mail};
                    cliente.Direcciones.Add(new Direccion { Calle = calle, Numero = numero, ElCliente = cliente });

                    db.Clientes.Add(cliente);
                    db.SaveChanges();

                    Console.WriteLine("Para Salir 0, Cualquier otra tecla para ingresar otro cliente. ");
                    salir = Console.ReadLine();
                }
                //Mostrar todos los clientes de la base de datos
                var query = from b in db.Clientes orderby b.Apellido, b.Nombre select b;

                Console.WriteLine("Todos los Clientes de la base de datos: ");
                foreach (var item in query)
                {
                    string linea = item.Nombre + " " + item.Apellido + " "+item.Mail;
                    if (item.Direcciones.Count > 0)
                        linea += ", " + item.Direcciones[0].Calle + " " + item.Direcciones[0].Numero;
                    Console.WriteLine(linea);
                }
                Console.WriteLine("Presione una tecla para slair...");
                Console.ReadKey();
            }
        }
    }
}
