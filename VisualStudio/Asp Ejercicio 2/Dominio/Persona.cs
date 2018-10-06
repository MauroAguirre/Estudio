using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        private int cedula;
        private string nombre;
        private string mail;
        public Persona(int cedula, string nombre, string mail) 
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.mail = mail;
        }
        public override string ToString()
        {
            return "Cedula: "+cedula+" Nombre: " + nombre + " Mail: " + mail;
        }
    }
}
