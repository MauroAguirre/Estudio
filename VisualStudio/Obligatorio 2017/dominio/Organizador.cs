using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Organizador : Administrador
    {
        #region Atributos
        private string nombre;
        private int telefono;
        private string direccion;
        private DateTime fecha;
        private string mail;
        private string contraseña;
        private List<Evento> eventos;
        #endregion
        public Organizador(string unNombre, int unTelefono, string unaDireccion, DateTime unaFecha, string unMail, string unaContraseña) :base(unMail, unaContraseña)
        {
            nombre = unNombre;
            telefono = unTelefono;
            direccion = unaDireccion;
            fecha = unaFecha;
            mail = unMail;
            contraseña = unaContraseña;
            eventos = new List<Evento>();
        }
        public void AgregarEvento(Evento nuevoEvento)
        {
            eventos.Add(nuevoEvento);
        }
        public List<Evento> DarEventos()
        {
            List<Evento> auxEventos = new List<Evento>();
            foreach (Evento evento in eventos)
            {
                auxEventos.Add(evento);
            }
            return auxEventos;
        }
        public bool HayEventoEnEstaFecha(DateTime fecha)
        {
            foreach (Evento evento in eventos)
            {
                if (evento.Fecha == fecha)
                    return true;
            }
            return false;
        }
        public override string ToString()
        {
            return "Mail: " + mail + "\nNombre: " + nombre+"\nDireccion: "+direccion+"\nFecha: "+fecha;
        }
    }
}
