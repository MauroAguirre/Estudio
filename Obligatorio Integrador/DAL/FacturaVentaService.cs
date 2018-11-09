using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class FacturaVentaService
    {
        private static FacturaVentaService instancia;
        public static FacturaVentaService Instancia()
        {
            if (instancia == null)
                instancia = new FacturaVentaService();
            return instancia;
        }
        public FacturaVenta Agregar(DateTime fecha, string descripcion)
        {
            FacturaVenta nuevo = new FacturaVenta();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                nuevo = db.facturasVentas.Add(new FacturaVenta() { descripcion=descripcion,fecha=fecha});
                db.SaveChanges();
            }
            return nuevo;
        }
        public List<FacturaVenta> Lista()
        {
            List<FacturaVenta> lista = new List<FacturaVenta>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var query = from f in db.facturasVentas
                            select new { f.id,f.LineaFacturas,f.fecha,f.descripcion};
                foreach (var f in query.ToList())
                {
                    lista.Add(new FacturaVenta() { descripcion=f.descripcion,fecha=f.fecha,id=f.id,LineaFacturas=f.LineaFacturas});
                }
            }
            return lista;
        }
        public int TotalFactura(int id)
        {
            int costo = 0;
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var query = from l in db.lineafacturas
                            where l.factura.id == id
                            select new { l.precio };
                foreach (var l in query.ToList())
                {
                    costo += l.precio;
                }
            }
            return costo;
        }
        public FacturaVenta UnaFactura(int id)
        {
            FacturaVenta nueva = new FacturaVenta();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var query = from f in db.facturasVentas
                            select new { f.descripcion,f.fecha,f.id,f.LineaFacturas };
                var query2 = from l in db.lineafacturas
                             where l.factura.id == id
                             select new { l.articulo, l.cantidad, l.factura, l.id, l.precio };
                List<LineaFactura> lista = new List<LineaFactura>();
                foreach (var b in query2.ToList())
                {
                    lista.Add(new LineaFactura() { articulo = b.articulo, cantidad = b.cantidad, id = b.id, precio = b.precio });
                }
                foreach (var a in query.ToList())
                {
                    nueva = new FacturaVenta() { fecha = a.fecha, id = a.id, LineaFacturas = lista, descripcion=a.descripcion };
                }
            }
            return nueva;
        }
    }
}
