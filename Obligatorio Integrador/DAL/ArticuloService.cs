using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class ArticuloService
    {
        public void Agregar(Articulo articulo)
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                db.articulos.Add(articulo);
                db.SaveChanges();
            }
        }
        public List<Articulo> Lista()
        {
            List<Articulo> articulos = new List<Articulo>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var a in db.articulos)
                {
                    articulos.Add(new Articulo() { id=a.id,descripcion=a.descripcion ,iva=a.iva,miniStock=a.miniStock,precioVenta=a.precioVenta});
                }
            }
            return articulos;
        }
        public void Modificar(Articulo articulo)
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var a in db.articulos)
                {
                    if (a.id == articulo.id)
                    {
                        a.iva = articulo.iva;
                        a.descripcion = articulo.descripcion;
                        a.miniStock = articulo.miniStock;
                        a.precioVenta = a.precioVenta;
                        break;
                    }
                }
                db.SaveChanges();
            }
        }
        public void Borrar(int id)
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var a in db.articulos)
                {
                    if (a.id == id)
                    {
                        db.articulos.Remove(a);
                        break;
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
