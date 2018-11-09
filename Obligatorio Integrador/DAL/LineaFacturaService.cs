using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class LineaFacturaService
    {
        private static LineaFacturaService instancia;
        public static LineaFacturaService Instancia()
        {
            if (instancia == null)
                instancia = new LineaFacturaService();
            return instancia;
        }
        public LineaFactura Agregar(int cantidad,int precio, int factura,int articulo,Boolean compra)
        {
            LineaFactura nueva = new LineaFactura();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                Factura fac;
                if(compra)
                    fac = db.facturaCompras.Find(factura);
                else
                    fac = db.facturasVentas.Find(factura);
                Articulo art = db.articulos.Find(articulo);
                nueva = db.lineafacturas.Add(new LineaFactura() { articulo=art,cantidad=cantidad,factura=fac,precio = precio});
                int cambio = 0;
                if (compra)
                    cambio += cantidad;
                else
                    cambio -= cantidad;
                db.registro.Add(new Registro() {articulo=art,cambio=cambio,fecha=fac.fecha });
                db.SaveChanges();
            }
            return nueva;
        }
    }
}
