using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Velocidad :Infraccion
    {
        private int maxima;
        private int velocidad;
        public Velocidad(int maxima, int velocidad, DateTime fecha, int numCam, string matricula) :base(fecha,numCam,matricula)
        {
            this.maxima = maxima;
            this.velocidad = velocidad;
        }
    }
}
