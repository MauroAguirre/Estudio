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
        public List<LineaFactura> AgregarLista(List<MVC.Models.LineaFac> lineas)
        {
            List<LineaFactura> lineasNuevas = new List<LineaFactura>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {

                var artPto = db.articuloProveedores.Find(lineas.ElementAt(0).articuloProveedor);

                var pro = db.proveedores.Find(artPto.articulo);




                var fac = db.facturaCompras.Find(lineas.ElementAt(0).factura);
                foreach (MVC.Models.LineaFac li in lineas)
                {
                    var articuloPro = db.articuloProveedores.Find(li.articuloProveedor);
                    lineasNuevas.Add(db.lineafacturas.Add(new LineaFactura() {articuloProveedor = articuloPro,cantidad=li.cantidad,factura=fac }));
                    var articulo = from a in db.articuloProveedores
                                   where a.id == articuloPro.id
                                   select new { articulo =a.articulo };
                    var lista = articulo.ToList();
                    foreach (var a in lista)
                    {
                        db.registro.Add(new Registro() { articulo = a.articulo,cambio=li.cantidad,fecha=DateTime.Today });
                    }
                }
                db.SaveChanges();
            }
            return lineasNuevas;
        }
    }
}
