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
        public Articulo Agregar(Articulo articulo)
        {
            Articulo nuevo = new Articulo();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                nuevo = db.articulos.Add(articulo);
                db.registro.Add(new Registro() { articulo=nuevo,cambio=0,fecha=DateTime.Today});
                db.SaveChanges();
            }
            return nuevo;
        }
        public List<Articulo> Lista()
        {
            List<Articulo> articulos = new List<Articulo>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                var query = from a in db.articulos
                            where a.activo == true
                            select a;
                articulos = query.ToList();
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
                        a.precioVenta = articulo.precioVenta;
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
                db.articulos.Find(id).activo = false;
                db.SaveChanges();
            }
        }
    }
}
