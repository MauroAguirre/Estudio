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
        UsuarioService usuarioService = new UsuarioService();
        public Usuario Agregar(Usuario usuario)
        {
            if (usuario.Contra == "" || usuario.Nombre == "" || usuario.Mail == "")
            {
                return null;
            }
            foreach (var usu in usuarioService.DarUsuarios())
            {
                if (usu.Mail == usuario.Mail)
                {
                    return null;
                }
            }
            return usuarioService.Crear(usuario);
        }
        public List<Usuario> DarUsuarios()
        {
            return usuarioService.DarUsuarios();
        }
        public bool EsUsuario(Usuario usuario)
        {
            foreach (Usuario usu in usuarioService.DarUsuarios())
            {
                if (usu.Mail == usuario.Mail && usu.Contra == usuario.Contra)
                {
                    return true;
                }
            }
            return false;
        }
        public void Modificar(Usuario usu)
        {
            usuarioService.Modificar(usu);
        }
        public void Borrar(string mail)
        {
            usuarioService.Borrar(mail);
        }
    }
}
