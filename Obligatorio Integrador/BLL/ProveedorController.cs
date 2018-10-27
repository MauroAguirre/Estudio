using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class ProveedorController
    {
        ProveedorService ps = new ProveedorService();
        public Proveedor Agregar(Proveedor proveedor)
        {
            if (proveedor.rut==null || proveedor.descripcion==null || proveedor.nombre==null)
                return null;
            return ps.Agregar(proveedor);
        }
        public List<Proveedor> Lista()
        {
            return ps.Lista();
        }
        public void Modificar(Proveedor proveedor)
        {
            ps.Modificar(proveedor);
        }
        public void Borrar(String rut)
        {
            ps.Borrar(rut);
        }
    }
}
