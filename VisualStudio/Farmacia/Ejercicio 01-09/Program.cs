using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Producto p1 = new Producto();   //Cuando ponemos new se crea un metodo constructor
            Producto p2 = new Producto();
            p1.Descripcion = "Aspirina";
            p1.PrecioCompra = 100;
            p1.PrecioVenta = 150;
            p1.Tipo = "Medicamento";
            Console.WriteLine(p1.Descripcion);
            Console.WriteLine(p1);
            Console.WriteLine(p1.Equals(p2));
            Console.ReadKey();
             */
            Proveedor unProv1 = new Proveedor(5, "Juan");
            Proveedor unProv2 = new Proveedor(2, "Raul");
            Producto unProducto1 = new Producto();
            unProducto1.Codigo = 1;
            unProducto1.Descripcion = "Aspirina";
            unProducto1.Proveedor = unProv1;
            Console.WriteLine(unProducto1);
            Console.ReadKey();

            unProducto1.AgregarCompra(100, 5, unProv1);
            Console.WriteLine(unProducto1.Proveedor.Nombre);
            Console.WriteLine(unProducto1);

            unProducto1.AgregarCompra(110, 5, unProv2);
            Console.WriteLine(unProducto1);
            Console.ReadKey();
        }
    }
}
