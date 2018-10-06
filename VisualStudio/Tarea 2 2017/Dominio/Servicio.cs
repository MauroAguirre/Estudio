using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Servicio
    {
        #region Atributos
        private string descripcion;
        private int precio;
        #endregion
        #region Propiedades
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }

        }
        public int Precio
        {
            set { precio = value; }
            get { return precio; }
        }
        #endregion
        #region Constructor
        public Servicio(string nuevaDescripcion, int nuevoPrecio)
        {
            descripcion = nuevaDescripcion;
            precio = nuevoPrecio;
        }
        #endregion
    }
}
