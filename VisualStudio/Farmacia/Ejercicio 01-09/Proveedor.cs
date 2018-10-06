using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01_09
{
    class Proveedor
    {
        #region Atributos
        private int codigo;
        private string nombre;
        private string direccion;
        #endregion
        #region Propiedades
        public int Codigo 
        {
            get { return codigo; }
            set { codigo = value; }   
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
        #region Metodos
        public Proveedor()
        {

        }
        public Proveedor(int pcodigo, string pnombre) 
        {
            nombre = pnombre;
            codigo = pcodigo;
        }
        #endregion
    }
}
