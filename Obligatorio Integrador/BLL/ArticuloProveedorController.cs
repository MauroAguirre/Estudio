using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Common;

namespace BLL
{
    public class ArticuloProveedorController
    {
        private static ArticuloProveedorController instancia;
        public static ArticuloProveedorController Instancia()
        {
            if (instancia == null)
                instancia = new ArticuloProveedorController();
            return instancia;
        }
        ArticuloProveedorService aps = ArticuloProveedorService.Instancia();
        public ArticuloProveedor Agregar(String rut, int id, int precio,DateTime fecha)
        {
            if (precio < 1)
                return null;
            return aps.Agregar(rut, id, precio,fecha);
        }
        public List<ArticuloProveedor> PorArticuloProveedor(int id,string rut)
        {
            return aps.PorArticuloProveedor(id,rut);
        }
        public List<ArticuloProveedor> Lista(String rut)
        {
            return aps.Lista(rut);
        }
        public List<ArticuloProveedor> Lista_ultima_fecha(String rut)
        {
            Boolean esta = false; ;
            List<ArticuloProveedor> lista = aps.Lista(rut);
            //
            List<Articulo> articuloCom = new List<Articulo>();
            List<DateTime> fechasCom = new List<DateTime>();
            foreach (ArticuloProveedor ap in lista)
            {
                esta = false;
                for (int i = 0; i < articuloCom.Count; i++)
                {
                    if (articuloCom.ElementAt(i) == ap.articulo)
                    {
                        if (fechasCom.ElementAt(i) < ap.fecha)
                            fechasCom[i] = ap.fecha;
                        esta = true;
                        break;
                    }
                }
                if (!esta)
                {
                    articuloCom.Add(ap.articulo);
                    fechasCom.Add(ap.fecha);
                }
            }
            List<ArticuloProveedor> paraRemover = new List<ArticuloProveedor>();
            foreach (ArticuloProveedor ap in lista)
            {
                for (int i = 0; i < articuloCom.Count; i++)
                {
                    if (ap.articulo == articuloCom.ElementAt(i) && ap.fecha != fechasCom.ElementAt(i))
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
