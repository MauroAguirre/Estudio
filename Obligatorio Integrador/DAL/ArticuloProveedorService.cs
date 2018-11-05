using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class ArticuloProveedorService
    {
        public ArticuloProveedor Agregar(String rut,int id,int costo,DateTime fecha)
        {
            ArticuloProveedor nuevo = new ArticuloProveedor();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var prov = db.proveedores.Find(rut);
                var art = db.articulos.Find(id);
                nuevo = db.articuloProveedores.Add(new ArticuloProveedor() { costo= costo, fecha=fecha,articulo=art,proveedor=prov});
                db.SaveChanges();
            }
            return nuevo;
        }
        public List<ArticuloProveedor> Lista(String rut)
        {
            List<ArticuloProveedor> articulosProv = new List<ArticuloProveedor>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                if (rut == null)
                {
                    var query2 = from p in db.proveedores
                                where p.activo == true
                                select p;
                    rut = query2.ToList().First().rut;
                }
                    
                var prov = db.proveedores.Find(rut);
                var query = from a in db.articuloProveedores
                            where a.proveedor.rut == rut
                            select new{ costo = a.costo, fecha = a.fecha, articulo =a.articulo, proveedor = a.proveedor,id = a.id};
                foreach (var a in query.ToList())
                {
                    articulosProv.Add(new ArticuloProveedor() { costo = a.costo, fecha = a.fecha, articulo = a.articulo, proveedor = a.proveedor ,id = a.id});
                }
            }
            return articulosProv;
        }
    }
}
