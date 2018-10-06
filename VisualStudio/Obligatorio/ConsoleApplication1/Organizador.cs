using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    class Organizador :Usuario
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
        #region Propiedades
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
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
        public override string ToString()
        {
            return "Mail: " + mail + "   Contraseña: " + Contraseña;
        }
    }
}
