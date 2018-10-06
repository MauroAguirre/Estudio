using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace appConsola
{


    class Program
    {
        static void Main(string[] args)
        {
            TiendaMascotas unaT = TiendaMascotas.Instancia;

            Cliente unCliente;
            Corte unCorte;
            Mascota unaMascota;
            ServicioComprado unSC;
            int cedula;
            int posicion;
            string nombre;
            string direccion;
       
            bool meVoy = false;

            while (!meVoy)
            {
                Console.WriteLine();
                Console.WriteLine("1- Alta Cliente");
                Console.WriteLine("2- Agregar Mascota");
                Console.WriteLine("3- Agregar Servicio");
                Console.WriteLine("4- Listado");
                Console.WriteLine("5- Mostrar mascotas con servicios");
                Console.WriteLine("6- Listado de clientes que tienen 2 o mas mascotas");
                Console.WriteLine("7- Cliente con mas mascotas");
                Console.WriteLine("8- Valor recaudado entre dos fechas");
                int num = PedirNumero("Opcion 9-salir");

                Console.Clear();

                switch (num)
                {
                    case 1:
                        cedula = PedirNumero("Ingrese el ci");
                        
                        unCliente = unaT.BuscarCliente(cedula);
                        if (unCliente == null)
                        {
                            nombre = PedirTexto("Ingrese nombre");
                            direccion = PedirTexto("Ingrese direccion");

                            unCliente = new Cliente(nombre, direccion, cedula);
                            unaT.AltaCliente(unCliente);
                            mostrarClientes(unaT);
                        }
                        else
                        {
                            Console.WriteLine("El codigo " + unCliente.Cedula + " ya existe" );
                        }
                        
                        break;

                    case 2:
                        cedula = PedirNumero("Ingrese el ci");
                        unCliente = unaT.BuscarCliente(cedula);
                        if (unCliente != null)
                        {
                            Console.WriteLine(unCliente.Nombre);
                            nombre = PedirTexto("Ingrese nombre");
                            unaMascota = new Mascota(nombre, unCliente);
                            unaT.AgregarMascota(unaMascota);
                            mostrarClientes(unaT);

                        }
                        break;

                    case 3:
                        cedula = PedirNumero("Ingrese el ci");
                        unCliente = unaT.BuscarCliente(cedula);
                        if (unCliente != null)
                        {
                            foreach (Mascota unaM in unCliente.Mascotas())
                            {
                                Console.WriteLine(unaM);
                            }
                            posicion = PedirNumero("Indique las posicion de la mascota");
                            unaMascota = unCliente.Mascotas()[posicion];

                            Console.WriteLine("servicios");
                            foreach (Corte unC in unaT.Cortes())
                            {
                                Console.WriteLine(unC);
                            }
                            posicion = PedirNumero("Indique las posicion del corte");
                            unCorte = unaT.Cortes()[posicion];

                            unSC = new ServicioComprado();
                            unSC.Fecha = DateTime.Now;
                            unSC.Mascota = unaMascota;
                            unSC.Servicio = unCorte;

                            unaT.ComprarServicio(unSC);


                            Console.WriteLine(unCliente.Nombre);
                            nombre = PedirTexto("Ingrese nombre");
                            unaMascota = new Mascota(nombre, unCliente);
                            unaT.AgregarMascota(unaMascota);
                            mostrarClientes(unaT);

                        }
                        break;
                    case 4:
                        mostrarClientes(unaT);
                        break;
                    case 5:
                        MostrarMascotas(unaT);
                        Console.ReadKey();
                        break;
                    case 6:
                        MostrarClientesCon2Mascotas(unaT);
                        Console.ReadKey();
                        break;
                    case 7:
                        ClienteConMasMascotas(unaT);
                        Console.ReadKey();
                        break;
                    case 8:
                        MostrarValorRecaudado(unaT);
                        break;
                    case 9:
                        Console.WriteLine("¡Gracias!");
                        meVoy = true;
                        break;
                    default:
                        Console.WriteLine("No implementado");
                        break;
                }
            }



            Console.ReadKey();


        }
        private static DateTime PedirFecha(string texto)
        {
            DateTime fecha;
            bool pude = false;
            Console.WriteLine(texto);
            do
            {
                pude = DateTime.TryParse(Console.ReadLine(), out fecha);

                if (!pude)
                {
                    Console.WriteLine("Ingreso Incorrecto.");
                    Console.WriteLine(texto);
                }
            }
            while (!pude);
            return fecha;
        }
        private static string PedirTexto(string texto)
        {
            string ingreso = "";
            bool pude = false;
            do
            {
                Console.WriteLine(texto);
                ingreso = Console.ReadLine();
                if (ingreso != "")
                {
                    pude = true;
                }
            }
            while (!pude);
            return ingreso;
        }
        private static int PedirNumero(string texto)
        {
            int num;
            bool pude = false;
            Console.WriteLine(texto);
            do
            {
                pude = int.TryParse(Console.ReadLine(), out num);
                if (!pude)
                {
                    Console.WriteLine("Ingreso Incorrecto.");
                    Console.WriteLine(texto);
                }
            }
            while (!pude);
            return num;
        }
        private static void mostrarClientes(TiendaMascotas unaT)
        {
            foreach (Cliente unCliente in unaT.Clientes())
            {
                Console.WriteLine(unCliente);
            }
        }
        private static void MostrarMascotas(TiendaMascotas unaT) 
        {
            foreach (Mascota mascota in unaT.DarMascotasConServicios())
            {
                Console.WriteLine(mascota);
            }
        }
        private static void MostrarClientesCon2Mascotas(TiendaMascotas unaT)
        {
            foreach (Cliente unCliente in unaT.Clientes())
            {
                Console.WriteLine(unCliente);
            }
        }
        private static void ClienteConMasMascotas(TiendaMascotas unaT)
        {
            Console.WriteLine(unaT.ClienteConMasMascotas());
        }
        private static void MostrarValorRecaudado(TiendaMascotas unaT)
        {
            DateTime fecha1 = IngresarFecha("Ingrese la primera fecha");
            DateTime fecha2 = IngresarFecha("Ingrese la segunda fecha");
            Console.WriteLine("\nEl valor recaudado es de: "+unaT.ValorRecaudadoEntreFechas(fecha1,fecha2));
        }
        public static DateTime IngresarFecha(string texto)
        {
            DateTime fecha;
            int mes = 2, dia, año = 2;
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
    }
}
