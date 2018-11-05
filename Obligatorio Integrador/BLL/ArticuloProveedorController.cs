using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dominio;

namespace BLL
{
    public class ArticuloProveedorController
    {
        ArticuloProveedorService aps = new ArticuloProveedorService();
        public ArticuloProveedor Agregar(String rut, int id, int precio,DateTime fecha)
        {
            if (precio < 1)
                return null;
            return aps.Agregar(rut, id, precio,fecha);
        }
        public List<ArticuloProveedor> Lista(String rut)
        {
            return aps.Lista(rut);
        }
        public List<ArticuloProveedor> Lista_ultima_fecha(String rut)
        {
            Boolean esta = false; ;
            List<ArticuloProveedor> lista = aps.Lista(rut);
            List<ArtProbFec> comparar = new List<ArtProbFec>();
            foreach (ArticuloProveedor ap in lista)
            {
                esta = false;
                foreach (ArtProbFec c in comparar)
                {
                    if (c.articulo == ap.articulo)
                    {
                        if (c.fecha < ap.fecha)
                            c.fecha = ap.fecha;
                        esta = true;
                        break;
                    }                    
                }
                if (!esta)
                    comparar.Add(new ArtProbFec() { articulo=ap.articulo,fecha = ap.fecha});
            }
            List<ArticuloProveedor> paraRemover = new List<ArticuloProveedor>();
            foreach (ArticuloProveedor ap in lista)
            {
                foreach (ArtProbFec c in comparar)
                {
                    if (ap.articulo == c.articulo && ap.fecha != c.fecha)
                        paraRemover.Add(ap);
                }
            }
            foreach (ArticuloProveedor a in paraRemover)
            {
                lista.Remove(a);
            }
            return lista;
        }
    }
}
