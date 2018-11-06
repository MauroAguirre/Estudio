using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class LineaFacturaService
    {
        public LineaFactura Agregar(int cantidad, int factura,int articulo,Boolean compra)
        {
            LineaFactura nueva = new LineaFactura();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                Factura fac = db.facturaCompras.Find(factura);
                Articulo art = db.articulos.Find(articulo);
                nueva = db.lineafacturas.Add(new LineaFactura() { articulo=art,cantidad=cantidad,factura=fac});
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
