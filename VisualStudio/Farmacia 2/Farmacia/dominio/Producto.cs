using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Producto : IComparable<Producto>
    {
        public enum EnumeradoTipo
        {
            medicamento, perfumeria, regalos
        }

        private int codigo;
        private string descripcion;
        private int stock;
        private double precioCompra;
        private Proveedor proveedor;
        private EnumeradoTipo tipo;



        #region Properties
        public EnumeradoTipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        public double PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

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
        #endregion

        #region constructores
        public Producto()
        {
            this.proveedor = new Proveedor();
        }
        public Producto(int codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.stock = 0;
            this.precioCompra = 0;
            this.tipo = EnumeradoTipo.medicamento;
            this.proveedor = new Proveedor();
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            string retorno = "";
            retorno += this.codigo + "--" + this.descripcion;
            /*
            \n
            \t
            */
            retorno += "\n Proveedor: " + this.proveedor.Nombre + "--" + this.precioCompra + "--Stock: " + stock;
            return retorno;

        }
        #endregion

        public int CompareTo(Producto other)
        {
            /*
            int retorno;

            if (stock > other.stock) retorno = 1;
            else if (stock < other.stock) retorno = -1;
            else retorno = 0;

            return retorno;
            */
            return stock - other.stock;

        }




    }
}
