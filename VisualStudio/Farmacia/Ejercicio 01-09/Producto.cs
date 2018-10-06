using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01_09
{
    class Producto
    {
        public enum Tipos { medicamento, droga };
        #region Atributos
        private int codigo;
        private string descripcion;
        private Tipos tipo;
        private int precioCompra;
        private int precioVenta;
        private int stock;
        private Proveedor proveedor;
        #endregion
        #region Propiedades
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        public Tipos Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        public int PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }
        public int PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        #endregion
        #region Metodos
        public void AgregarCompra(int precio,int cantidad,Proveedor provCompra)
        {
            precioCompra = precio;
            stock += cantidad;
            proveedor = provCompra;
        }
        public Producto()   //se pueden sobrecargar metodos cambiandole los parametros
        {
            Proveedor = new Proveedor();
        }
        public Producto(string nombre)
        {
            
        }
        public override string ToString()
        {
 	        return "Codigo: "+codigo+" Descripcion: "+descripcion+" Tipo: "+tipo+" Compra: "+precioCompra+" Venta: "+precioCompra+" Proveedor: "+proveedor.Nombre;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion
    }
}