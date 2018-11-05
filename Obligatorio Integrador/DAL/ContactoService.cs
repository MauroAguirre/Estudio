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
        public Contacto Agregar(string p, string n, int t)
        {
            Contacto nuevo = new Contacto();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var prov = db.proveedores.Find(p);
                Contacto contacto = new Contacto() { nombre = n, telefono = t, proveedor = prov };
                nuevo = db.contactos.Add(new Contacto() { nombre = n, telefono = t, proveedor = prov });
                prov.contactos.Add(nuevo);
                db.SaveChanges();
            }
            return nuevo;
        }
        public List<Contacto> Lista(string rut)
        {
            List<Contacto> contactos = new List<Contacto>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                if (rut == null)
                    rut = db.proveedores.Find("123").rut;
                else
                    rut = db.proveedores.Find(rut).rut;

                var query = from d in db.contactos
                             where d.proveedor.rut == rut
                             select d;
                contactos = query.ToList();

            }
            return contactos;
        }
        public void Modificar(string rut, string nombre, int telefono)
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var query = from c in db.contactos
                            where c.proveedor.rut == rut
                            select c;
                List<Contacto> contactos = query.ToList();
                foreach (var c in contactos)
                {
                    if (c.nombre == nombre)
                    {
                        c.telefono = telefono;
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
                var query = from c in db.contactos
                            where c.proveedor.rut == rut
                            select c;
                List<Contacto> contactos = query.ToList();
                foreach (var c in contactos)
                {
                    if (c.nombre == nombre)
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
