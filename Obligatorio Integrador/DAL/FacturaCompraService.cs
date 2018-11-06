using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class FacturaCompraService
    {
        public FacturaCompra Agregar(DateTime fecha,string rut)
        {
            FacturaCompra nuevo = new FacturaCompra();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var proveedor = db.proveedores.Find(rut);
                nuevo = db.facturaCompras.Add(new FacturaCompra() { fecha = fecha, proveedor = proveedor});
                db.SaveChanges();
            }
            return nuevo;
        }
        public List<FacturaCompra> Lista(string rut)
        {
            List<FacturaCompra> lista = new List<FacturaCompra>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                if (rut == null)
                {
                    var query2 = from p in db.proveedores
                                 where p.activo == true
                                 select p;
                    rut = query2.ToList().First().rut;
                }
                var query = from f in db.facturaCompras
                            where f.proveedor.rut == rut
                            select new { id=f.id,fecha = f.fecha,proveedor=f.proveedor,lineaFacturas=f.LineaFacturas};
                foreach (var f in query.ToList())
                {
                    lista.Add(new FacturaCompra() { id=f.id,fecha=f.fecha,proveedor=f.proveedor,LineaFacturas=f.lineaFacturas});
                }
            }
            return lista;
        }
    }
}
