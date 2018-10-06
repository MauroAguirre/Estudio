using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            string esSmart;
            int tipos;
            bool correcto;
            int eleccion;
            bool nosFuimos = false;
            bool smart;
            int tamaño;
            Console.WriteLine("Ingrese marca");
            string marca = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingrese modelo");
            string modelo = Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("Que tipo es\n1-LED\n2-LCD\n3-Plasma\n4-TRC");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out tipos);
            }while(!correcto || tipos<1 || tipos>4);
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese tamaño");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out tamaño);
            }while(!correcto);
            do
            {
                Console.Clear();
                Console.WriteLine("Es smart");
                esSmart = Console.ReadLine();
                esSmart = esSmart.ToUpper();
                if (esSmart == "SI")
                    smart = true;
                else
                    smart = false;
            } while (esSmart != "SI" && esSmart != "NO");
            Television tv = new Television(marca, modelo, tipos, smart, tamaño);
            do
            {
                Console.Clear();
                Menu();
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out eleccion);
                while (!correcto)
                {
                    Console.Clear();
                    Menu();
                    Console.WriteLine("Error, vuelva a ingresar");
                    dato = Console.ReadLine();
                    correcto = int.TryParse(dato, out eleccion);
                }
                correcto=false;
                Console.Clear();
                switch(eleccion)
                {
                    case 1:
                        tv.CambiarEstado();
                        break;
                    case 2:
                        tv.AumentarBrillo();
                        break;
                    case 3:
                        tv.DisminuirBrillo();
                        break;
                    case 4:
                        tv.AumentarContraste();
                        break;
                    case 5:
                        tv.DisminuirContraste();
                        break;
                    case 6:
                        tv.SubirCanal();
                        break;
                    case 7:
                        tv.BajarCanal();
                        break;
                    case 8:
                        Console.WriteLine("Ingrese canal");
                        eleccion = int.Parse(Console.ReadLine());
                        tv.IngresarCanal(eleccion);
                        break;
                    case 9:
                        tv.SubirVolumen();
                        break;
                    case 10:
                        tv.BajarVolumen();
                        break;
                }
                Console.WriteLine(tv);
                Console.ReadKey();
            }while(!nosFuimos);
            
            
        }
        static void Menu()
        {
            Console.WriteLine("1-Cambiar el estado");
            Console.WriteLine("2-Aumentar el brillo");
            Console.WriteLine("3-Disminuir el brillo");
            Console.WriteLine("4-Aumentar el contraste");
            Console.WriteLine("5-Disminuir el contraste");
            Console.WriteLine("6-Subir el canal");
            Console.WriteLine("7-Bajar el canal");
            Console.WriteLine("8-Ingresar el canal");
            Console.WriteLine("9-Subir el volumen");
            Console.WriteLine("10-Bajar el volumen");
        }
    }
}
