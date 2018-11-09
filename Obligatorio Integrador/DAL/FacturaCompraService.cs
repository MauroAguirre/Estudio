using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class FacturaCompraService
    {
        private static FacturaCompraService instancia;
        public static FacturaCompraService Instancia()
        {
            if (instancia == null)
                instancia = new FacturaCompraService();
            return instancia;
        }
        public FacturaCompra Agregar(DateTime fecha, string rut)
        {
            FacturaCompra nuevo = new FacturaCompra();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var proveedor = db.proveedores.Find(rut);
                nuevo = db.facturaCompras.Add(new FacturaCompra() { fecha = fecha, proveedor = proveedor });
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
                            select new { id = f.id, fecha = f.fecha, proveedor = f.proveedor, lineaFacturas = f.LineaFacturas };
                foreach (var f in query.ToList())
                {
                    lista.Add(new FacturaCompra() { id = f.id, fecha = f.fecha, proveedor = f.proveedor, LineaFacturas = f.lineaFacturas });
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
        public FacturaCompra UnaFactura(int id)
        {
            FacturaCompra nueva = new FacturaCompra();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var query = from f in db.facturaCompras
                            select new {f.fecha,f.id,f.LineaFacturas,f.proveedor };
                var query2 = from l in db.lineafacturas
                            where l.factura.id == id
                            select new { l.articulo,l.cantidad,l.factura,l.id,l.precio};
                List<LineaFactura> lista = new List<LineaFactura>();
                foreach (var b in query2.ToList())
                {
                    lista.Add(new LineaFactura() {articulo=b.articulo,cantidad=b.cantidad,id=b.id,precio=b.precio });
                }
                foreach (var a in query.ToList())
                {
                    nueva = new FacturaCompra() { fecha = a.fecha, id = a.id, LineaFacturas = lista, proveedor = a.proveedor };
                }
            }
            return nueva;
        }
    }
}
