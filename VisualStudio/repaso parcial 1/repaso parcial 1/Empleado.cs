using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_parcial_1
{
    class Empleado
    {
        private string nombre;
        private int edad;
        private int telefono;
        private int sueldoPorHora;
        private List<ServicioComprado> serviciosComprados;

        public int RetornarSueldo6Meses() 
        {
            int sueldo = 0;
            foreach(ServicioComprado servicito in serviciosComprados)
            {
                sueldo += servicito.Sueldo(sueldoPorHora);
            }
            return sueldo;
        }
    }
}
