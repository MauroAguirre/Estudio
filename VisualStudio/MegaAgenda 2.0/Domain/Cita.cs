using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cita
    {
        private DateTime fecha;
        private int hora;

        public int Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

    }
}
