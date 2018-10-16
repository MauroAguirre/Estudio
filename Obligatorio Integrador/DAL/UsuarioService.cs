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
        public void Agregar(Usuario usuario) {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                db.usuarios.Add(usuario);
                db.SaveChanges();
            }
        }
        public List<Usuario> Lista() {
            List<Usuario> usuarios = new List<Usuario>();
            using (BarracaLuisContext db = new BarracaLuisContext()) {
                foreach (var u in db.usuarios) {
                    usuarios.Add(new Usuario() { mail = u.mail, contra = u.contra });
                }
            }
            return usuarios;
        }
        public void Modificar(Usuario usuario)
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var u in db.usuarios)
                {
                    if (u.mail == usuario.mail)
                    {
                        u.contra = usuario.contra;
                        break;
                    }
                }
                db.SaveChanges();
            }
        }
        public void Borrar(String mail) {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {      
                foreach (var u in db.usuarios)
                {
                    if (u.mail == mail) {
                        db.usuarios.Remove(u);
                        break;
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
