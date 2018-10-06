using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Ejercicio
    {
        static void Main(string[] args)
        {
            int numero;
            string dato;
            bool correcto;
            Console.WriteLine("1 Ingresar nombre\n2 Adivinar números\n3 Tabla\n9 Fin");
            dato = Console.ReadLine();
            correcto = int.TryParse(dato, out numero);
            while (!correcto) 
            {
                Console.Clear();
                Console.WriteLine("1 Ingresar nombre\n2 Adivinar números\n3 Tabla\n9 Fin");
                Console.WriteLine("Error, ingrese denuevo");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out numero);
            }
            Console.Clear();
            switch (numero) { 
                case 1:
                    Ingresar_Nombre();
                    break;
                case 2:
                    Adivinar_Numeros();
                    break;
                case 3:
                    Tabla();
                    break;
            }
        }
        private static void Ingresar_Nombre()
        {
            string nombre;
            string ingresar;
            int edad;
            bool correcto;
            do
            {
                Console.Clear();
                Console.WriteLine("Cual es tu nombre?");
                nombre = Console.ReadLine();
                if (nombre != "")
                {
                    Console.WriteLine("Cual es tu edad?");
                    ingresar = Console.ReadLine();
                    correcto = int.TryParse(ingresar, out edad);
                    while (!correcto)
                    {
                        Console.WriteLine("Error, ingrese denuevo la edad");
                        ingresar = Console.ReadLine();
                        correcto = int.TryParse(ingresar, out edad);
                    }
                    if (edad > 17 && edad < 26)
                        Console.WriteLine("Hola " + nombre);
                    else
                    {
                        if (edad > 25 && edad < 31)
                            Console.WriteLine("Te estas poniendo viejo " + nombre);
                        else
                        {
                            if (edad > 30 && edad < 46)
                                Console.WriteLine("Arriba " + nombre);
                        }
                    }
                    Console.ReadKey();
                }
            } while (nombre != "");
            Console.WriteLine("Nos fuimos");
            Console.ReadKey();
        }
        private static void Adivinar_Numeros()
        {
            int numero;
            string dato;
            bool correcto;
            Console.WriteLine("Ingrese un numero");
            dato = Console.ReadLine();
            correcto = int.TryParse(dato, out numero);
            while (!correcto)
            {
                Console.WriteLine("Error, ingrese un numero");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out numero);
            }
            Random aleatorio = new Random();
            int numAleatorio = aleatorio.Next(1, 6);
            if (numero == numAleatorio)
                Console.WriteLine("Correcto");
            else
                Console.WriteLine("Incorrecto, el numero era: " + numAleatorio);
            Console.ReadKey();
        }
        private static void Tabla()
        {
            int numero;
            string dato;
            bool correcto;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out numero);
                while (!correcto)
                {
                    Console.WriteLine("Error, ingrese un numero");
                    dato = Console.ReadLine();
                    correcto = int.TryParse(dato, out numero);
                }
                if (numero != 0)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(i + " x " + numero + " = " + numero * i);
                    }
                    Console.ReadKey();
                }
            } while (numero != 0);
        }
    }
}
