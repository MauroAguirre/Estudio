using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public abstract class Evento
    {
        public enum Turno { mañana, tarde, noche };
        #region Atributos
        private DateTime fecha;
        public Turno turno;
        private string descripcion;
        private string cliente;
        private int asistentes;
        private int personas;
        private int codigo;
        private static int ultimoCodigo;
        private List<ServiciosComprados> servicios;
        private Organizador organizador;
        public string Fecha 
        {
            get
            {
                DateTime fec = DateTime.Now;
                return fec.ToShortDateString(); }
        }
        public string Descripcion
        {
            get { return descripcion; }
        }
        public string Cliente
        {
            get { return cliente; }
        }
        public int Asistentes
        {
            get { return asistentes; }
        }
        public int Personas
        {
            get { return personas; }
        }
        public int Codigo
        {
            get { return codigo; }
        }
        public Turno El_turno 
        {
            get { return turno; }
        }
        public abstract int Unico { get; }
        public int Servicios 
        {
            get { return servicios.Count; }
        }
        public float CostoTotalDelEvento 
        {
            get { return CostoTotal(); }
        }
        #endregion
        #region Metodos
        public Evento(string cualTurno, DateTime fecha, string descripcion, string cliente, int asistentes, int personas, Organizador organizador, List<ServiciosComprados> servicios)
        {
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.cliente = cliente;
            this.asistentes = asistentes;
            this.personas = personas;
            codigo = ++ultimoCodigo;
            this.organizador = organizador;
            this.servicios = servicios;
            switch (cualTurno) 
            {
                case "mañana":
                    turno = Turno.mañana;
                    break;
                case "noche":
                    turno = Turno.noche;
                    break;
                case "tarde":
                    turno = Turno.tarde;
                    break;
            }
        }
        //Muestra email del organizador
        public string MailEvento()
        {
            return organizador.Mail;
        }
        //Devuelve un precio o aumento dependiendo de la clase
        public abstract int Extra();
        //Muestra el costo total de todos los servicios
        public float CostoTotal()
        {
            int total = 0;
            foreach (ServiciosComprados servicio in servicios)
            {
                total += servicio.DarPrecio();
            }
            if (this.GetType() == typeof(Premium)) 
            {
                return total+(float)(total * (float)Extra());
            }
            return total + Extra();
        }
        //Devuelve una lista de serviciosComprados
        public List<ServiciosComprados> DarServicios()
        {
            List<ServiciosComprados> axuServicios = new List<ServiciosComprados>();
            foreach (ServiciosComprados servicio in servicios)
            {
                axuServicios.Add(servicio);
            }
            return axuServicios;
        }
        //Devuelve la fecha
        public DateTime DarFecha() 
        {
            return fecha;
        }
        #endregion
    }
}
