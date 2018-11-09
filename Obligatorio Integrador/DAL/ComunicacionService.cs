using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class ComunicacionService
    {
        private static ComunicacionService instancia;
        public static ComunicacionService Instancia()
        {
            if (instancia == null)
                instancia = new ComunicacionService();
            return instancia;
        }
        public Comunicacion Agregar(Comunicacion c,int id)
        {
            Comunicacion nueva = new Comunicacion();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                Contacto contacto = db.contactos.Find(id);
                nueva = db.comunicaciones.Add(new Comunicacion() { comentario=c.comentario,fecha=c.fecha,tipo=c.tipo,contacto=contacto});
                db.SaveChanges();

                var query = from con in db.contactos
                            select new { con.proveedor };
                foreach (var ccc in query.ToList())
                {
                    nueva.contacto.proveedor = ccc.proveedor;
                    nueva.contacto.proveedor.contactos = null;
                } 
            }
            return nueva;
        }
        public List<Comunicacion> Lista()
        {
            List<Comunicacion> comunicaciones = new List<Comunicacion>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var query = from c in db.comunicaciones
                            select new { c.comentario, c.contacto, c.fecha, c.id, c.tipo,pro = c.contacto.proveedor};
                foreach (var c in query.ToList())
                {
                    c.pro.contactos = null;
                    c.contacto.proveedor = c.pro;
                    comunicaciones.Add(new Comunicacion() { id = c.id, comentario = c.comentario, contacto = c.contacto, fecha = c.fecha, tipo = c.tipo });
                }
            }
            return comunicaciones;
        }
    }
}
