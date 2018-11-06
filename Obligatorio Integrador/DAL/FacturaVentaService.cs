using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class FacturaVentaService
    {
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
    }
}
