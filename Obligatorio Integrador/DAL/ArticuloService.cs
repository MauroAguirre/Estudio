using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class ArticuloService
    {
        private static ArticuloService instancia;
        public static ArticuloService Instancia()
        {
            if (instancia == null)
                instancia = new ArticuloService();
            return instancia;
        }
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
        public Articulo Buscar(int id)
        {
            Articulo a = new Articulo();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                a = db.articulos.Find(id);
            }
            return a;
        }
        public List<Articulo> Articulos40()
        {
            List<Articulo> minimos = new List<Articulo>();
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                List<Articulo> articulos = db.articulos.ToList();
                //que es mayor al minimo de stock
                Boolean[] dias = new Boolean[30];
                DateTime[] fechas = new DateTime[30];
                for (int i = 0; i < 30; i++)
                {
                    fechas[i] = DateTime.Today.AddDays(30 - i);
                }
                foreach (Articulo a in articulos)
                {
                    //lista registro de un articulo
                    var registrosArt = (from c in db.registro
                                        where c.articulo.id == a.id
                                        select c).ToList();
                    //para sacar cantidad de stock antes de los 30 dias
                    DateTime fechaAnterior = DateTime.Today.AddDays(-30);
                    var registroantes30 = (from c in db.registro
                                           where c.articulo.id == a.id
                                           where c.fecha < fechaAnterior
                                           select c.cambio).ToList();
                    int stock = 0;
                    foreach (var cam in registroantes30)
                    {
                        stock += cam;
                    }
                    //recorro los dias
                    for (int i = 0; i < 30; i++)
                    {
                        //recorro los registros de este articulo y si la fecha coincide con el dia hago el cambio en el stock
                        foreach (Registro r in registrosArt)
                        {
                            if (r.fecha.Day == fechas[i].Day)
                                stock += r.cambio;
                        }
                        //si al final de ese dia el stock este mayor al minimo lo marco true de lo contrario false
                        if (stock > a.miniStock)
                            dias[i] = true;
                        else
                            dias[i] = false;
                    }
                    //verifico si el 40% de los dias estuvo por debajo del minimo
                    int porcentaje = 0;
                    for (int i = 0; i < 30; i++)
                    {
                        if (dias[i])
                            porcentaje++;
                    }
                    //el 40% de 30 es 14, si es igual o menor a 14 estuvo por debajo
                    if (porcentaje <= 14)
                    {
                        minimos.Add(a);
                    }
                }
            }
            return minimos;
        }
    }
}
