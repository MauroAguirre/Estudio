using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Proveedor
    {
        private int codigo;
        private string nombre;
        private static int ultCodigo;

        #region Properties
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        #endregion

        public Proveedor()
        {}

        public Proveedor(string nombre)
        {
            ultCodigo++;
            codigo = ultCodigo;            
            this.nombre = nombre;
        }

        #region Metodos
        public override string ToString()
        {
            return codigo + "-->" + nombre;
        }
        #endregion
    }
}
