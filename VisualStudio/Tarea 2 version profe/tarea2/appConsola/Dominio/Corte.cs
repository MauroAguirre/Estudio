using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Corte : Servicio
    {
        private bool corteUñas;

        public bool CorteUñas
        {
            get { return corteUñas; }
            set { corteUñas = value; }
        }
        public override string ToString()
        {
            string respuesta;
            if (corteUñas)
                respuesta = "Se cortan las uñas";
            else
                respuesta = "No se cortan las uñas";
            return "Descripcion: " + this.Descripcion + "\nPrecio: " + this.Precio + "\n" + respuesta;
        }
    }
}
