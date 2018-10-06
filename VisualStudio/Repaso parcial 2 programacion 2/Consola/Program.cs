using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int direccion;
            bool correcto;
            string respuesta;
            Complejo_Vacacional sistema = Complejo_Vacacional.Instancia;
            do
            {
                Console.Clear();
                Console.WriteLine("hola chiquilin que queres hacer?");
                Console.WriteLine("");
                Console.WriteLine("1 - Alta de alojamiento");
                Console.WriteLine("2 - Alta de cliente");
                Console.WriteLine("3 - Alta de estadia");
                Console.WriteLine("4 - Nos vemos");
                Console.WriteLine("5 - Mostrar cabañas");
                respuesta = Console.ReadLine();
                correcto = int.TryParse(respuesta, out direccion);
                if (!correcto)
                    direccion = 5;
                switch (direccion)
                {
                    case 1:
                        do
                        {
                            Alojamiento alojamiento;
                            Console.Clear();
                            Console.WriteLine("Que tipo de alojamiento quiere agregar:");
                            Console.WriteLine("1 - Cabaña");
                            Console.WriteLine("2 - Apart_Hotel");
                            respuesta = Console.ReadLine();
                            correcto = int.TryParse(respuesta, out direccion);
                            if (!correcto)
                                direccion = 5;
                            Console.WriteLine("Ingrese ubicacion:");
                            string ubicacion = Console.ReadLine();
                            Console.WriteLine("Ingrese codigo:");
                            string codigo = Console.ReadLine();
                            Console.WriteLine("Ingrese cantidad maxima de huespedes:");
                            int canMaxHuespedes = int.Parse(Console.ReadLine());
                            switch (direccion)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese cantidad de habitaciones:");
                                    int cantidadHabitaciones = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Tiene aire acondicionado?:");
                                    Console.WriteLine("1 - si");
                                    Console.WriteLine("2 - no");
                                    respuesta = Console.ReadLine();
                                    bool aireCondicionado;
                                    if (respuesta == "1")
                                        aireCondicionado = true;
                                    else
                                        aireCondicionado = false;
                                    Console.WriteLine("Tiene parrillero individual?:");
                                    Console.WriteLine("1 - si");
                                    Console.WriteLine("2 - no");
                                    respuesta = Console.ReadLine();
                                    bool parrilleroIndividual = true;
                                    if (respuesta == "1")
                                        aireCondicionado = true;
                                    else
                                        aireCondicionado = false;
                                    alojamiento = new Cabaña(cantidadHabitaciones, aireCondicionado, parrilleroIndividual, codigo, ubicacion, canMaxHuespedes);
                                    sistema.Alta_de_Alojamiento(alojamiento);
                                    direccion = 1;
                                    break;
                                case 2:
                                    Console.WriteLine("Tiene garage privado?:");
                                    Console.WriteLine("1 - si");
                                    Console.WriteLine("2 - no");
                                    respuesta = Console.ReadLine();
                                    bool garajePrivado = true;
                                    if (respuesta == "1")
                                        garajePrivado = true;
                                    else
                                        garajePrivado = false;
                                    direccion = 1;
                                    break;
                                default:
                                    break;
                            }
                        } while (direccion != 1);
                        Console.WriteLine("Alojamiento agregado");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("cliente");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("estadia");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("nos vemos");
                        Console.ReadKey();
                        break;
                    case 5:
                        MostarAlojamientos(sistema.DarAlojamientos());
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("error");
                        Console.ReadKey();
                        break;
                }

            } while (direccion != 4);
        }
        static void MostarAlojamientos(List<Alojamiento> alojamientos)
        {
            Console.WriteLine("         Alojamientos:");
            Console.WriteLine("");
            foreach (Alojamiento a in alojamientos)
            {
                Console.WriteLine(a);
                Console.WriteLine("");
            }
        }
    }
}
