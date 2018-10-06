using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Premium : Evento
    {
        private int aumento;
        public Premium(string cualTurno, int aumento, DateTime fecha, string descripcion, string cliente, int asistentes, int personas, Organizador organizador, List<ServiciosComprados> servicios) : base(cualTurno,fecha,descripcion,cliente,asistentes,personas,organizador,servicios)
        {
            this.aumento = aumento;
        }
        //Devuelve el aumento
        public override int Extra()
        {
            return aumento;
        }
        public override string ToString()
        {
            return "Codigo: " + Codigo + "\nDescripcion: " + Descripcion + "\nTurno: " + turno + "\nFecha: " + Fecha + "\nCliente: " + Cliente + "\nPersonas: " + Personas + "\nAsistentes: " + Asistentes + "\nAumento: " + aumento + "%";
        }
    }
}
