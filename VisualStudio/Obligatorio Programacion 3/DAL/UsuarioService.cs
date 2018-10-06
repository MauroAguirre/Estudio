using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class UsuarioService
    {
        public Usuario Crear(Usuario usuario)
        {
            using (var db = new EmpresaContext())
            {
                var usr = db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
            return usuario;
        }
        public List<Usuario> DarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (var db = new EmpresaContext())
            {
                foreach (var usu in db.Usuarios)
                {
                    Usuario usuario = new Usuario() { Nombre = usu.Nombre, Mail = usu.Mail, Contra = usu.Contra };
                    usuarios.Add(usuario);
                }
                return usuarios;
            }
        }
        public void Modificar(Usuario usu)
        {
            using (var db = new EmpresaContext())
            {
                var usuario = db.Usuarios.Find(usu.Mail);
                usuario.Nombre = usu.Nombre;
                usuario.Contra = usu.Contra;
                db.SaveChanges();
            }
        }
        public void Borrar(string mail)
        {
            using (var db = new EmpresaContext())
            {
                var user = db.Usuarios.Find(mail);
                db.Usuarios.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
