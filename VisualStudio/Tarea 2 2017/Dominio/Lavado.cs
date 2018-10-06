using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lavado :Servicio
    {
        #region Atributos
        private bool incluyeAplicacion;
        #endregion
        #region Constructor
        public Lavado(string nuevaDescripcion, int nuevoPrecio, bool nuevaAplicacion) :base(nuevaDescripcion, nuevoPrecio)
        {
            incluyeAplicacion = nuevaAplicacion;
        }
        public override string ToString()
        {
            string respuesta;
            if (incluyeAplicacion)
                respuesta = "si";
            else
                respuesta = "no";
            return "Descripcion: " + this.Descripcion + "\nPrecio: " + Precio + "\nIncluye productos anti-insectos? " + respuesta;
        }
        #endregion
    }
}
