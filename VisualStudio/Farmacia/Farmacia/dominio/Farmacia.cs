using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Farmacia
    {
        #region Atributos
        private static Farmacia instancia;
        private string direccion;
        private string nombre;
        private List<Producto> listaProductos;
        private List<Proveedor> listaProveedor;

        #endregion
        #region Constructores
        private Farmacia()
        {
            listaProductos = new List<Producto>();
            listaProveedor = new List<Proveedor>();
            /*  Podria cargar info para las pruebas */
            Producto p1 = new Producto(123, "aspirina");
            p1.Stock = 100;
            Producto p2 = new Producto(222, "curitas");
            p2.Stock = 5;
            Producto p3 = new Producto(444, "parche");
            p3.Stock = 8;
            listaProductos.Add(p1);
            listaProductos.Add(p2);
            listaProductos.Add(p3);

        }
        #endregion
        #region Metodos
        public List<Producto> DevolverListaProducto()
        {
            List<Producto> auxProd = new List<Producto>();
            foreach (Producto unProd in listaProductos)
            {
                auxProd.Add(unProd);
            }
            auxProd.Sort();
            return auxProd;
        }


        public void AltaProducto(Producto producto)
        {

            listaProductos.Add(producto);
        }

        public Producto BuscarProductoTrucho(int codigo)
        {
            foreach (Producto unProd in listaProductos)
            {
                if (unProd.Codigo == codigo) return unProd;
            }
            return null;
        }

        public Producto BuscarProducto(int codigo)
        {
            bool esta = false;
            Producto unProd = null;
            int posicion = 0;

            while (!esta && posicion < listaProductos.Count())
            {
                if (listaProductos[posicion].Codigo == codigo)
                {
                    esta = true;
                    unProd = listaProductos[posicion];
                }
                else
                {
                    posicion++;
                }
            }
            return unProd;
        }

        public List<Proveedor> DevolverListaProveedor()
        {
            List<Proveedor> auxProveedor = new List<Proveedor>();
            foreach (Proveedor unProv in listaProveedor)
            {
                auxProveedor.Add(unProv);
            }
            return auxProveedor;
        }

        public void AltaProveedor(Proveedor proveedor)
        {
            listaProveedor.Add(proveedor);
        }

        public void ComprarProducto(Producto unProd, double precio, int cantidad, Proveedor unProv)
        {
            unProd.Proveedor = unProv;
            unProd.Stock += cantidad;
            unProd.PrecioCompra = precio;
        }


        #endregion
        #region Properties
        public static Farmacia Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Farmacia();
                }
                return instancia;
            }
        }

        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        #endregion


    }
}
