using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dominio;

namespace BLL
{
    public class ArticuloController
    {
        ArticuloService us = new ArticuloService();
        public Articulo Agregar(Articulo articulo)
        {
            if (articulo.descripcion == null || articulo.miniStock <1 || articulo.precioVenta <1)
                return null;
            if (articulo.descripcion == "")
                return null;
            return us.Agregar(articulo);
        }
        public List<Articulo> Lista()
        {
            return us.Lista();
        }
        public bool Modificar(Articulo articulo)
        {
            if (articulo.descripcion == null || articulo.miniStock < 1 || articulo.precioVenta < 1)
                return false;
            if (articulo.descripcion == "")
                return false;
            us.Modificar(articulo);
            return true;
        }
        public void Borrar(int id)
        {
            us.Borrar(id);
        }
    }
}
