using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    class Eventos2017
    {
        #region Atributos
        private List<Usuario> usuarios;
        #endregion
        #region Metodos
        public Eventos2017()
        {
            usuarios = new List<Usuario>();
        }
        public void AgregarUsuario(Usuario nuevoUsuario)
        {
            usuarios.Add(nuevoUsuario);
        }
        public List<Usuario> DarUsuarios()
        {
            List<Usuario> auxUsuarios = new List<Usuario>();
            foreach (Usuario losUsuarios in usuarios)
            {
                auxUsuarios.Add(losUsuarios);
            }
            return auxUsuarios;
        }
        public void MostrarUsuarios()
        {
            foreach (Usuario losUsuarios in usuarios)
            {
                Console.WriteLine(losUsuarios);
            }
        }
        #endregion
    }
}
