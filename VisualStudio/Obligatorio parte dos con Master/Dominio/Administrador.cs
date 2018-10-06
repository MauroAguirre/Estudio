using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Administrador
    {
        #region Atributos
        private string mail;
        private string contraseña;
        #endregion
        #region Propiedades
        public string Mail
        {
            set { mail = value; }
            get { return mail; }
        }
        #endregion
        #region Metodos
        public string DarContraseña() 
        {
            return contraseña;
        }
        public Administrador(string unMail, string unaContraseña)
        {
            mail = unMail;
            contraseña = unaContraseña;
        }
        public override string ToString()
        {
            return "Mail: " + mail;
        }
        #endregion
    }
}
