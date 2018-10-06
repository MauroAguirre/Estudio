using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Evento
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
        public DateTime Fecha 
        {
            get { return fecha; }
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
        public string MailEvento()
        {
            return organizador.Mail;
        }
        public virtual int DarAumento()
        {
            return 0;
        }
        public int CostoTotal()
        {
            int total = 0;
            foreach (ServiciosComprados servicio in servicios)
            {
                total += servicio.DarPrecio();
            }
            return total;
        }
        public List<ServiciosComprados> DarServicios()
        {
            List<ServiciosComprados> axuServicios = new List<ServiciosComprados>();
            foreach (ServiciosComprados servicio in servicios)
            {
                axuServicios.Add(servicio);
            }
            return axuServicios;
        }
        #endregion
    }
}
