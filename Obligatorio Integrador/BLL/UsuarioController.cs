using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dominio;

namespace BLL
{
    public class UsuarioController
    {
        UsuarioService us = new UsuarioService();
        public Boolean AgregarUsuario(Usuario usuario)
        {
            List<Usuario> usuarios = us.ListaUsuarios();
            foreach (Usuario u in usuarios) {
                if (usuario.mail == u.mail)
                    return false;
            }
            us.AgregarUsuario(usuario);
            return true;
        }
        public List<Usuario> ListaUsuarios(){
            return us.ListaUsuarios();
        }
    }
}
