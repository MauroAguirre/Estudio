using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_parcial_1
{
    class Semanal : Servicio
    {
        private enum Dia { lunes, martes, miercoles, jueves, viernes, sabado, domingo };
        private Dia dia;
        private int horas;
        private int cantidadHoras;
        //si supera 6 horas se incluye una prima comun para todos los servicios semanales
        public override int Sueldo(int porHora)
        {
            int prima = 30;
            int sueldo = porHora * cantidadHoras;
            if (cantidadHoras > 6)
                sueldo = prima;
            return sueldo;
        }
    }
}
