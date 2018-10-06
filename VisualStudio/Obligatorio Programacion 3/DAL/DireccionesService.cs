using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.Entity;

namespace DAL
{
    public class DireccionesService
    {
        public void Crear(string nombre)
        {
            using (var db = new EmpresaContext())
            {
                Direccion direccion = new Direccion() { Nombre = nombre };
                db.Direcciones.Add(direccion);
                db.SaveChanges();
            }
        }
        public List<Direccion> Lista_de_Direcciones()
        {
            using (var db = new EmpresaContext())
            {
                List<Direccion> direcciones = new List<Direccion>();
                foreach (var dir in db.Direcciones)
                {
                    Direccion dire = new Direccion() { Nombre = dir.Nombre };
                    direcciones.Add(dire);
                }
                return direcciones;
            }
        }
        public void Borrar(string dir)
        {
            using (var db = new EmpresaContext())
            {
                var user = db.Direcciones.Find(dir);
                db.Direcciones.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
