using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ServicioComprado
    {
        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private Mascota mascota;

        public Mascota Mascota
        {
            get { return mascota; }
            set { mascota = value; }
        }
        private Servicio servicio;

        public Servicio Servicio
        {
            get { return servicio; }
            set { servicio = value; }
        }

        public override string ToString()
        {
            return servicio.ToString();
        }
        public Servicio DarServicio()
        {
            return servicio;
        }
    }
}
