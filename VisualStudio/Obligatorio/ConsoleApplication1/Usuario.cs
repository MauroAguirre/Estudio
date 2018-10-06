using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    class Usuario
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
        public string Contraseña
        {
            set { contraseña = value; }
            get { return contraseña; }
        }
        #endregion
        #region Metodos
        public Usuario(string unMail, string unaContraseña)
        {
            mail = unMail;
            contraseña = unaContraseña;
        }
        public override string ToString()
        {
            return "Mail: "+mail+"   Contraseña: "+Contraseña;
        }
        #endregion
    }
}
