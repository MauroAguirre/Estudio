using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace farmacia
{
    class Program
    {
        static void Main(string[] args)
        {
            Farmacia unaFarmacia = Farmacia.Instancia;
          
            Producto unProd;
            Proveedor unProv;
            int codigo = 0;
            string descripcion = "";
            string nombre = "";
            bool meVoy = false;

            while (!meVoy)
            {
                Console.WriteLine();
                Console.WriteLine("1- Alta Producto");
                Console.WriteLine("2- Buscar Producto por Codigo");
                Console.WriteLine("3- Alta Proveedor");
                Console.WriteLine("4- Listar Productos");
                Console.WriteLine("5- Listar Proveedor");
                Console.WriteLine("6- Comprar Articulos");

                int num = PedirNumero("Opcion 9-salir");

                Console.Clear();

                switch (num)
                {
                    case 1:
                        codigo = PedirNumero("Ingrese el codigo");
                        descripcion = PedirTexto("Ingrese descripción");

                        unProd = unaFarmacia.BuscarProducto(codigo);
                        if (unProd == null)
                        {
                            unProd = new Producto(codigo, descripcion);
                            unaFarmacia.AltaProducto(unProd);
                            mostrarProductos(unaFarmacia);
                        }
                        else
                        {
                            Console.WriteLine("El codigo " + unProd.Codigo + " ya existe con el nombre : " + unProd.Descripcion);
                        }
                        break;

                    case 2:
                        codigo = PedirNumero("Ingrese el codigo a buscar");
                        unProd = new Producto(codigo, "");

                        unProd = unaFarmacia.BuscarProducto(codigo);
                        if (unProd == null)
                        {
                            Console.WriteLine("El codigo " + codigo + " no se encuentra");
                        }
                        else
                        {
                            Console.WriteLine(unProd);
                        }
                        break;

                    case 3:
                        nombre = PedirTexto("Ingrese descripción");
                        unProv = new Proveedor(nombre);
                        unaFarmacia.AltaProveedor(unProv);
                        mostrarProveedores(unaFarmacia);
                        break;

                    case 4:
                        mostrarProductos(unaFarmacia);
                        break;

                    case 5:
                        mostrarProveedores(unaFarmacia);
                        break;

                    case 6:
                        mostrarProductos(unaFarmacia);
                        codigo = PedirNumero("Ingrese el codigo");
                        unProd = unaFarmacia.BuscarProducto(codigo);
                        if (unProd != null)
                        {
                            mostrarProveedores(unaFarmacia);
                            int posicion = PedirNumero("Posición");
                            unProv = unaFarmacia.DevolverListaProveedor()[posicion-1];
                            Console.WriteLine(unProd);
                            Console.WriteLine(unProv);
                            int cantidad = PedirNumero("Cantidad a comprar");
                            int precio = PedirNumero("Ingrese el precio");
                            unaFarmacia.ComprarProducto(unProd, precio, cantidad, unProv);
                            Console.WriteLine(unProd);
                            
                        }


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



        private static void mostrarProductos(Farmacia unaF)
        {
            foreach (Producto unProd in unaF.DevolverListaProducto())
            {
                Console.WriteLine(unProd);
            }
        }

        private static void mostrarProveedores(Farmacia unaF)
        {
            int posicion = 0;
            foreach (Proveedor unProv in unaF.DevolverListaProveedor())
            {
                Console.WriteLine(++posicion + " - " + unProv);
            }
        }
    }

}



