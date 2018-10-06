using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_parcial_1
{
    class Puntual : Servicio
    {
        private DateTime FechaDeRealizacion;
        private int duracion;
        private DateTime Fecha;
        //se cargara 10% mas si fue realizado conj menos de 24hr de antelacion
        public override int Sueldo (int porHora)
        { 
            int sueldo = porHora*duracion;
            //if ((Fecha - FechaDeRealizacion) < 24)
            //    return sueldo * 1.1;
            return sueldo;
        }
    }
}
