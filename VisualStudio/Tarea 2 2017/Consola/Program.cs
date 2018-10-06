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
            Tienda tienda = Tienda.Instancia;
            int cualCliente;
            int cualMascota;
            Servicio cualServicio;
            int queTipoServicio;
            bool nosFuimos = false;
            do
            {
                Menu();
                switch (IngresarNumero(11))
                {
                    case 1:
                        tienda.AgregarLavado(IngresarLavado());
                        break;
                    case 2:
                        tienda.AgregarCorte(IngresarCorte());
                        break;
                    case 3:
                        tienda.AgregarCliente(IngresarCliente());
                        break;
                    case 4:
                        if (tienda.CantidadClientes() != 0)
                        {
                            cualCliente = CualCliente(tienda.DarClientes());
                            tienda.AgregarMascotaAUnCliente((cualCliente), AgregarMascota(tienda.DarCliente((cualCliente))));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No hay clientes ingresados");
                            Console.WriteLine("Ingrese enter para continuar");
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        if (tienda.CantidadClientes() != 0 && tienda.CantidadServicios() != 0)
                        {
                            cualCliente = CualCliente(tienda.DarClientes());
                            cualMascota = CualMascota(tienda.DarCliente((cualCliente)));
                            queTipoServicio = queTipoDeServicio(tienda.DarCortes(), tienda.DarLavados());
                            cualServicio = QueServicioQueresTipo(tienda.DarCortes(), tienda.DarLavados(), queTipoServicio);
                            DateTime fecha = IngresarFecha("Ingrese la fecha (00/00/0000)");
                            ServicioComprado nuevoServicioComprado = new ServicioComprado(fecha,cualServicio,tienda.DarCliente((cualCliente)).DarMascota(cualMascota-1));
                            tienda.AgregarServicioComprado(nuevoServicioComprado);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No hay clientes y/o servicios ingresados");
                            Console.WriteLine("Ingrese enter para continuar");
                            Console.ReadKey();
                        }
                        break;
                    case 6:
                        MostrarClientes(tienda.DarClientes(),false);
                        Console.WriteLine("Ingrese enter para continuar");
                        Console.ReadKey();
                        break;
                    case 7:
                        MostrarLavados(tienda.DarLavados(),false);
                        Console.WriteLine("Ingrese enter para continuar");
                        Console.ReadKey();
                        break;
                    case 8:
                        MostrarCortes(tienda.DarCortes(),false);
                        Console.WriteLine("Ingrese enter para continuar");
                        Console.ReadKey();
                        break;
                    case 9:
                        MostrarServiciosComprados(tienda.DarServiciosComprados());
                        Console.WriteLine("Ingrese enter para continuar");
                        Console.ReadKey();
                        break;
                    case 10:
                        if (tienda.CantidadClientes() != 0)
                        {
                            MostrarClientes(tienda.DarClientes(), true);
                            cualCliente = CualCliente(tienda.DarClientes());
                            MostrarMascotasDeCliente(tienda.DarCliente(cualCliente));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No hay clientes ingresados");
                        }
                        Console.WriteLine("Ingrese enter para continuar");
                        Console.ReadKey();
                        break;
                    case 11:
                        nosFuimos = true;
                        break;
                }
                Console.Clear();
            } while (!nosFuimos);
        }
        static void Menu()
        {
            Console.WriteLine("Veterinaria");
            Console.WriteLine("");
            Console.WriteLine("1-Agregar lavado");
            Console.WriteLine("2-Agregar corte");
            Console.WriteLine("3-Agregar cliente");
            Console.WriteLine("4-Agregar mascotas al cliente");
            Console.WriteLine("5-Ingresar una compra");
            Console.WriteLine("6-Lista de clientes");
            Console.WriteLine("7-Lista de lavados");
            Console.WriteLine("8-Lista de cortes");
            Console.WriteLine("9-Lista de servicios comprados");
            Console.WriteLine("10-Lista de mascotas de un cliente");
            Console.WriteLine("11-fin\n");
        }
        static int IngresarNumero()
        {
            string dato;
            bool correcto = true;
            int numero;
            bool primera = true;
            do
            {
                if (primera)
                {
                    Console.WriteLine("Ingrese una opcion:");
                    primera = false;
                }
                else
                    Console.WriteLine("Error, ingrese denuevo");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out numero);
            } while (!correcto);
            return numero;
        }
        static int IngresarNumero(int maximo)
        {
            string dato;
            bool correcto = true;
            int numero;
            bool primera = true;
            do
            {
                if (primera)
                {
                    Console.WriteLine("Ingrese una opcion:");
                    primera = false;
                }
                else
                    Console.WriteLine("Error, ingrese denuevo");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out numero);
            } while (!correcto || numero > maximo || numero < 1 );
            return numero;
        }
        static int IngresarNumero(string texto)
        {
            string dato;
            bool correcto = true;
            int numero;
            bool primera = true;
            do
            {
                if (primera)
                {
                    Console.WriteLine(texto);
                    primera = false;
                }
                else
                    Console.WriteLine("Error, ingrese denuevo");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out numero);
            } while (!correcto);
            return numero;
        }
        static string IngresarTexto(string texto)
        {
            Console.WriteLine(texto);
            return Console.ReadLine();
        }
        static bool Dicotomica(string texto)
        {
            string respuesta;
            bool primera = true;
            do
            {
                if (primera)
                {
                    Console.WriteLine(texto);
                    primera = false;
                }
                else
                    Console.WriteLine("Error, ingrese denuevo");
                respuesta = Console.ReadLine();
            } while (respuesta != "si" && respuesta != "SI" && respuesta != "no" && respuesta != "NO");
            if (respuesta == "si" || respuesta == "SI")
                return true;
            return false;
        }
        static Lavado IngresarLavado()
        {
            Console.Clear();
            Lavado nuevoLavado;
            string descripcion = IngresarTexto("Ingrese la descripcion del lavado");
            int precio = IngresarNumero("Ingrese el precio del lavado");
            bool aplicacion = Dicotomica("Incluye la aplicacion de productos anti-insectos?");
            return nuevoLavado = new Lavado(descripcion,precio,aplicacion);
        }
        static Corte IngresarCorte()
        {
            Console.Clear();
            Corte nuevoCorte;
            string respuesta;
            bool tipo;
            string descripcion = IngresarTexto("Ingrese la descripcion del corte");
            int precio = IngresarNumero("Ingrese el precio del corte");
            bool uñas = Dicotomica("Se le van a cortar las uñas");
            do
            {
                respuesta = IngresarTexto("Es tipo estandar o para concurso?");
                respuesta = respuesta.ToLower();

            } while (respuesta != "estandar" && respuesta != "concurso");
            if (respuesta == "estandar")
                tipo = true;
            else
                tipo = false;
            return nuevoCorte = new Corte(descripcion, precio,tipo ,uñas);
        }
        static Cliente IngresarCliente()
        {
            Console.Clear();
            Cliente nuevoCliente;
            string nombre = IngresarTexto("Ingrese el nombre del cliente");
            string cedula = IngresarTexto("Ingrese la cedula del cliente");
            string direccion = IngresarTexto("Ingrese la direccion del cliente");
            int telefono = IngresarNumero("Ingrese el telefono del cliente");
            return nuevoCliente = new Cliente(cedula,nombre,direccion,telefono);
        }
        static void MostrarClientes(List<Cliente> clientes, bool numerado) 
        {
            Console.Clear();
            int numero = 1;
            if (!numerado)
            {
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine(cliente + "\n");
                }
            }
            else
            {
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine(numero+"\n"+cliente + "\n");
                    numero++;
                }
            }
        }
        static void MostrarLavados(List<Lavado> lavados, bool numerado )
        {
            Console.Clear();
            int contador = 1;
            if (numerado)
            {
                foreach (Lavado lavado in lavados)
                {
                    Console.WriteLine(contador + "\n" + lavado + "\n");
                    contador++;
                }
            }
            else
            {
                foreach (Lavado lavado in lavados)
                {
                    Console.WriteLine(lavado + "\n");
                }
            }
        }
        static void MostrarCortes(List<Corte> cortes, bool numerado )
        {
            Console.Clear();
            int contador = 1;
            if (numerado)
            {
                foreach (Corte corte in cortes)
                {
                    Console.WriteLine(contador+ "\n"+corte + "\n");
                    contador++;
                }
            }
            else
            {
                foreach (Corte corte in cortes)
                {
                    Console.WriteLine(corte + "\n");
                }
            }
        }
        static void MostrarMascotasDeCliente(Cliente cliente)
        {
            Console.Clear();
            foreach (Mascota mascota in cliente.DarMascotas())
            {
                Console.WriteLine(mascota);
            }
        }
        static void MostrarServiciosComprados(List<ServicioComprado> serviciosComprados)
        {
            Console.Clear();
            foreach (ServicioComprado servicioComprado in serviciosComprados)
            { 
                Console.WriteLine(servicioComprado + "\n");
            }
        }
        static int CualCliente(List<Cliente> losClientes)
        {
            Console.Clear();
            MostrarClientes(losClientes,true);
            int cual = IngresarNumero(losClientes.Count());
            return cual;
        }
        static int CualMascota(Cliente dueño) 
        {
            Console.Clear();
            MostrarMascotasDeCliente(dueño);
            int cual = IngresarNumero(dueño.CantidadMascotas());
            return cual;
        }
        static int queTipoDeServicio(List<Corte> cortes, List<Lavado> lavados)
        {
            Console.Clear();
            if (cortes.Count() == 0)
                return 1;
            else
            {
                if (lavados.Count() == 0)
                    return 2;
                else
                {
                    int cual = IngresarNumero("Que tipo de serivio quiere comprar?\n\n1-Lavado\n2-Corte");
                    while (cual != 1 && cual != 2)
                    {
                        cual = IngresarNumero("Error, ingrese denuevo");
                    }
                    return cual;
                }
            }
            
        }
        static Servicio QueServicioQueresTipo(List<Corte> cortes, List<Lavado> lavados, int cual) 
        {
            int cualServicio;
            Console.Clear();
            if (cual == 1)
            {
                MostrarLavados(lavados,true);
                cualServicio = IngresarNumero("Cual servicio desea utilizar");
                return lavados[cualServicio-1];
            }
            else 
            {
                MostrarCortes(cortes,true);
                cualServicio = IngresarNumero("Cual servicio desea utilizar");
                return cortes[cualServicio-1];
            }
        }
        static Mascota AgregarMascota(Cliente dueño)
        {
            Console.Clear();
            Mascota nuevaMascota;
            string nombre = IngresarTexto("Cual es el nombre de la mascota");
            string raza = IngresarTexto("Cual es la raza de la mascota");
            DateTime edad = IngresarFecha("Cual es la fecha de nacimiento de la mascota? (00/00/0000)");
            return nuevaMascota = new Mascota(nombre, raza, edad, dueño);
        }
        static DateTime IngresarFecha(string texto)
        {
            Console.Clear();
            string fech = IngresarTexto(texto);
            DateTime nuevaFecha = new DateTime(int.Parse(fech.Substring(6, 4)),int.Parse(fech.Substring(3, 2)),int.Parse(fech.Substring(0, 2)));
            return nuevaFecha;
        }
    }
}
