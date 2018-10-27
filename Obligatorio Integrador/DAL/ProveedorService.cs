using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class ProveedorService
    {
        public Proveedor Agregar(Proveedor proveedor)
        {
            Proveedor nuevo = new Proveedor();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                nuevo = db.proveedores.Add(proveedor);
                db.SaveChanges();
            }
            return nuevo;
        }
        public List<Proveedor> Lista()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var p in db.proveedores)
                {
                    proveedores.Add(new Proveedor() {rut=p.rut,descripcion=p.descripcion,nombre=p.nombre,contactos=p.contactos });
                }
            }
            return proveedores;
        }
        public void Modificar(Proveedor proveedor)
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var p in db.proveedores)
                {
                    if (p.rut==proveedor.rut)
                    {
                        p.descripcion = proveedor.descripcion;
                        p.nombre = proveedor.nombre;
                        break;
                    }
                }
                db.SaveChanges();
            }
        }
        public void Borrar(String rut)
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var p in db.proveedores)
                {
                    if (p.rut==rut)
                    {
                        db.proveedores.Remove(p);
                        break;
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
