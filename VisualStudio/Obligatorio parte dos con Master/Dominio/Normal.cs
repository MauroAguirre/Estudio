using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Normal : Evento
    {
        private int duracion;
        public override int Unico
        {
            get { return duracion; }
        }
        public Normal(string cualTurno, int duracion, DateTime fecha, string descripcion, string cliente, int asistentes, int personas, Organizador organizador, List<ServiciosComprados> servicios) : base(cualTurno,fecha,descripcion,cliente,asistentes,personas,organizador, servicios)
        {
            this.duracion = duracion;
        }
        //Devuelve el precio de la limpieza
        public override int Extra()
        {
            return 200;
        }
        public override string ToString()
        {
            return "Codigo: " + Codigo + "\nDescripcion: " + Descripcion + "\nTurno: " + turno + "\nFecha: " + Fecha + "\nCliente: " + Cliente + "\nPersonas: " + Personas + "\nAsistentes: " + Asistentes + "\nDuracion: " + duracion;
        }
    }
}
