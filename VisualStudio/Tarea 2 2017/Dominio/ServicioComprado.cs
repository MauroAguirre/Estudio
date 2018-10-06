using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ServicioComprado
    {
        #region Atributos
        DateTime fecha;
        Servicio servicio;
        Mascota mascota;
        #endregion
        #region Metodos
        public ServicioComprado(DateTime nuevafecha, Servicio nuevoServicio, Mascota nuevaMascota) 
        {
            fecha = nuevafecha;
            servicio = nuevoServicio;
            mascota = nuevaMascota;
        }
        public override string ToString()
        {
            return "Fecha: " + fecha.ToShortDateString() + "\n" + servicio +"\n"+ mascota;
        }
        #endregion
    }
}
