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
            Sistema sistema = Sistema.Instancia;
            bool nosVamos = false;
            do
            {
                Console.Clear();
                Menu();
                switch (IngresarNumero(6)) 
                {
                    case 1:
                        sistema.AgregarInfraccion(IngresarInfraccion());
                        break;
                    case 2:
                        sistema.AgregarInspector(IngresarInspector());
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            } while (!nosVamos);
        }
        public static void Menu() 
        {
            Console.WriteLine("     Menu");
            Console.WriteLine("");
            Console.WriteLine(" 1-Alta de infracción");
            Console.WriteLine(" 2-Alta de inspector");
            Console.WriteLine(" 3-Alta de multa");
            Console.WriteLine(" 4-Devolver monto recaudado entre dos fechas");
            Console.WriteLine(" 5-Devolver infracciones cometidas de una matricula ");
            Console.WriteLine(" 6-Top inspectores mas trabajadores");
        }
        public static int IngresarNumero(int maximo) 
        {
            string dato = "";
            int numerin;
            bool correcto;
            bool primera = true;
            do
            {
                if (!primera)
                {
                    Console.WriteLine("Error, ingrese denuevo");
                    Console.WriteLine(dato);
                }  
                else
                    primera = false;
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out numerin);
            } while (!correcto || numerin < 1 || numerin > maximo);
            return numerin;
        }
        public static string IngresarTexto(string texto)
        {
            Console.WriteLine(texto);
            return Console.ReadLine();
        }
        public static DateTime IngresarFecha(string texto)
        {
            DateTime fecha;
            int mes = 2, dia, año=2;
            string dato;
            bool primera = true;
            do
            {
                do
                {
                    do
                    {
                        if (primera)
                        {
                            Console.WriteLine(texto);
                            primera = false;
                        }
                        else
                            Console.WriteLine("Error, ingrese una fecha valida");
                        dato = Console.ReadLine();
                    } while (dato.Length != 10);
                } while (!int.TryParse(dato.Substring(0, 2), out dia) || !int.TryParse(dato.Substring(3, 2), out mes) || !int.TryParse(dato.Substring(6, 4), out año)); 
            } while (dia < 1 || dia > 30 || mes < 1 || mes > 12 || año < 1);
            return fecha = new DateTime(año, mes, dia);
        }
        public static Infraccion IngresarInfraccion()
        {
            Infraccion infraccion;
            bool primera = true;
            string respuesta, matricula;
            DateTime fecha;
            int numCamara;
            do
            {
                if (primera)
                {
                    Console.WriteLine("Se ingresara una fraccion de tipo roja o de velocidad?");
                    primera = false;
                }
                else
                    Console.WriteLine("Error, ingrese denuevo");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();
            } while (respuesta != "ROJA" && respuesta != "VELOCIDAD");
            fecha = IngresarFecha("Ingrese la fecha de la infraccion");
            Console.WriteLine("Ingrese el numero de la camara");
            numCamara = IngresarNumero(99999);
            matricula = IngresarTexto("Ingrese el numero de la matricula");
            primera = false;
            if (respuesta == "ROJA")
            {
                bool roja;
                Console.WriteLine("Ingrese el recargo");
                int recargo = IngresarNumero(99999);
                do
                {
                    if (primera)
                    {
                        Console.WriteLine("Fue una infraccion roja?");
                        primera = false;
                    }
                    else
                        Console.WriteLine("Error, ingrese denuevo");
                    respuesta = Console.ReadLine();
                    respuesta = respuesta.ToUpper();
                } while (respuesta != "SI" && respuesta != "NO");
                if (respuesta == "SI")
                    roja = true;
                else
                    roja = false;
                infraccion = new Rojo(recargo,roja,fecha,numCamara,matricula);
            }
            else
            {
                Console.WriteLine("Ingrese la velocidad");
                int velocidad = IngresarNumero(99999);
                Console.WriteLine("Ingrese la velocidad maxima");
                int max = IngresarNumero(99999);
                infraccion = new Velocidad(max, velocidad, fecha, numCamara, matricula);
            }
            return infraccion;
        }
        public static Inspector IngresarInspector() 
        {
            Console.Clear();
            Inspector nuevoInspector;
            string nombre = IngresarTexto("Ingrese el nombre del inspector");
            string mail = IngresarTexto("Ingresar el mail del inspector");
            DateTime fecha = IngresarFecha("Ingrese la fecha de nacimiento del inspector (00/00/0000)");
            return nuevoInspector = new Inspector(nombre,mail,fecha);
        }
    }
}
