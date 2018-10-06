using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Contacto
    {
        private String nombre;
        private DateTime fechaNacimiento;
        private String mail;
        private String pais;

        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }
    }
}