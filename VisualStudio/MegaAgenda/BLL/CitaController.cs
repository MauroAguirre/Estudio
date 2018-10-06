using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class CitaController
    {
        private static CitaController instancia = null;
        public static CitaController Instancia()
        {
            if (CitaController.instancia == null)
            {
                CitaController.instancia = new CitaController();
            }
            return CitaController.instancia;
        }
        
    }
}
