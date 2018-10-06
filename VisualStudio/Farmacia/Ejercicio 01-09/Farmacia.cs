using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01_09
{
    class Farmacia
    {
        #region Atributos
        private string direccion;
        private string nombre;
        #endregion
        #region Propiedades
        public string Direccion 
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion
    }
}
