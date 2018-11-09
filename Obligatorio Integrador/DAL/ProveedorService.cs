using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class ProveedorService
    {
        private static ProveedorService instancia;
        public static ProveedorService Instancia()
        {
            if (instancia == null)
                instancia = new ProveedorService();
            return instancia;
        }
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
                var query = from p in db.proveedores
                            where p.activo == true
                            select p;
                proveedores = query.ToList();
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
                db.proveedores.Find(rut).activo = false;
                db.SaveChanges();
            }
        }
    }
}
