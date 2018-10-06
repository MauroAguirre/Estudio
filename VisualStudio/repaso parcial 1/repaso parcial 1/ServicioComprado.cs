using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_parcial_1
{
    class ServicioComprado
    {
        private Servicio servicio;
        private Empleado empleado;
        private DateTime fecha;
        private bool seRealizo;
        public bool SeRealizo 
        {
            get { return seRealizo; }
        }
        public int Sueldo(int porHora) 
        {
            if (seRealizo == false)
                return servicio.Sueldo(porHora)/2;
            return servicio.Sueldo(porHora);
        }
    }
}
