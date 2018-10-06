using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class AdministradorService
    {
        public Administrador Crear(Administrador administrador)
        {
            using (var db = new EmpresaContext())
            {
                var usr = db.Administradores.Add(administrador);
                db.SaveChanges();
            }
            return administrador;
        }
        public List<Administrador> DarAdministradores()
        {
            List<Administrador> administradores = new List<Administrador>();
            using (var db = new EmpresaContext())
            {
                foreach (var adm in db.Administradores)
                {
                    Administrador administrador = new Administrador() { Nombre = adm.Nombre, Mail = adm.Mail, Contra = adm.Contra };
                    administradores.Add(administrador);
                }
                return administradores;
            }
        }
        public void Modificar(Administrador adm)
        {
            using (var db = new EmpresaContext())
            {
                var administrador = db.Administradores.Find(adm.Mail);
                administrador.Nombre = adm.Nombre;
                administrador.Contra = adm.Contra;
                db.SaveChanges();
            }
        }
        public void Borrar(string mail)
        {
            using (var db = new EmpresaContext())
            {
                var user = db.Administradores.Find(mail);
                db.Administradores.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
