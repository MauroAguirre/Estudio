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
            DateTime fec = new DateTime(fecha.Year,fecha.Month,fecha.Day);
            fec = DateTime.Today;
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var proveedor = db.proveedores.Find(rut);
                nuevo = db.facturaCompras.Add(new FacturaCompra() { fecha =fec,proveedor = proveedor});
                db.SaveChanges();
            }
            return nuevo;
        }
        public List<FacturaCompra> Lista()
        {
            List<FacturaCompra> lista = new List<FacturaCompra>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var query = from f in db.facturaCompras
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
