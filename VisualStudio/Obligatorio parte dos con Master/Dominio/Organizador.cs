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
        //Agrega un evento a la lista de eventos
        public void AgregarEvento(Evento nuevoEvento)
        {
            eventos.Add(nuevoEvento);
        }
        //Devuelve una lista de eventos
        public List<Evento> DarEventos()
        {
            List<Evento> auxEventos = new List<Evento>();
            foreach (Evento evento in eventos)
            {
                auxEventos.Add(evento);
            }
            return auxEventos;
        }
        //Verifica si ya fue ingresado un evento que esa fecha
        public bool HayEventoEnEstaFecha(DateTime fecha)
        {
            foreach (Evento evento in eventos)
            {
                if (evento.DarFecha() == fecha)
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
