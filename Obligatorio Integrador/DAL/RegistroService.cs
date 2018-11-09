using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class RegistroService
    {
        private static RegistroService instancia;
        public static RegistroService Instancia()
        {
            if (instancia == null)
                instancia = new RegistroService();
            return instancia;
        }
        public List<Registro> Lista()
        {
            List<Registro> registros = new List<Registro>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var query = from r in db.registro
                            select new { id=r.id,articulo=r.articulo,fecha=r.fecha,cambio=r.cambio };
                foreach (var r in query.ToList())
                {
                    registros.Add(new Registro() { id = r.id, articulo = r.articulo, fecha = r.fecha, cambio = r.cambio });
                }
            }
            return registros;
        }
        public int Stock_Producto(int id)
        {
            int total = 0;
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var articulo = db.articulos.Find(id);
                var query = from r in db.registro
                            where r.articulo.id == id
                            select r;
                foreach (var r in query.ToList())
                {
                    total += r.cambio;
                }
            }
            return total;
        }
    }
}
