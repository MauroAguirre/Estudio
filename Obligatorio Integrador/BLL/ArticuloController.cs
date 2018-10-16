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
        public Boolean Agregar(Articulo articulo)
        {
            if (articulo.descripcion == null || articulo.descripcion == null || articulo.miniStock <0 || articulo.precioVenta <-1)
                return false;
            us.Agregar(articulo);
            return true;
        }
        public List<Articulo> Lista()
        {
            return us.Lista();
        }
        public void Modificar(Articulo articulo)
        {
            us.Modificar(articulo);
        }
        public void Borrar(int id)
        {
            us.Borrar(id);
        }
    }
}
