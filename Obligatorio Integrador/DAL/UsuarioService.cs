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
        public void AgregarUsuario(Usuario u) {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                db.usuarios.Add(u);
                db.SaveChanges();
            }
        }
        public List<Usuario> ListaUsuarios() {
            List<Usuario> usuarios = new List<Usuario>();
            using (BarracaLuisContext db = new BarracaLuisContext()) {
                foreach (var u in db.usuarios) {
                    usuarios.Add(new Usuario() { mail = u.mail, contra = u.contra });
                }
            }
            return usuarios;
        }
    }
}
