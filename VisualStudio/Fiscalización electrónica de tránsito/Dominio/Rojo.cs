using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Rojo : Infraccion
    {
        private int recargo;
        private bool roja;
        public Rojo(int recargo, bool roja, DateTime fecha, int numCam, string matricula) :base(fecha,numCam,matricula)
        {
            this.recargo = recargo;
            this.roja = roja;
        }
    }
}
