using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class ContactoService
    {
        public Contacto Agregar(Contacto contacto)
        {
            Contacto nuevo = new Contacto();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                nuevo = db.contactos.Add(nuevo);
                db.SaveChanges();
            }
            return nuevo;
        }
        public List<Contacto> Lista()
        {
            List<Contacto> contactos = new List<Contacto>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var c in db.contactos)
                {
                    contactos.Add(new Contacto() {nombre=c.nombre,telefono=c.telefono,proveedor=c.proveedor});
                }
            }
            return contactos;
        }
        public void Modificar(Contacto contacto)
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var c in db.contactos)
                {
                    if (c.proveedor == contacto.proveedor && c.nombre == c.nombre)
                    {
                        c.telefono = contacto.telefono;
                        break;
                    }
                }
                db.SaveChanges();
            }
        }
        public void Borrar(string rut, string nombre)
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var c in db.contactos)
                {
                    if (c.proveedor.rut == rut && c.nombre == nombre)
                    {
                        db.contactos.Remove(c);
                        break;
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
