using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_parcial_1
{
    abstract class Servicio
    {
        private string id;
        public abstract int Sueldo(int porHora);
    }
}
