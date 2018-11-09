using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;

namespace BLL
{
    public class ProveedorController
    {
        private static ProveedorController instancia;
        public static ProveedorController Instancia()
        {
            if (instancia == null)
                instancia = new ProveedorController();
            return instancia;
        }
        ProveedorService ps = ProveedorService.Instancia();
        public Proveedor Agregar(Proveedor proveedor)
        {
            List<Proveedor> proveedores = Lista();
            foreach (Proveedor p in proveedores)
            {
                if (p.rut == proveedor.rut)
                    return null;
            }
            if (proveedor.rut==null || proveedor.descripcion==null || proveedor.nombre==null)
                return null;
            if (proveedor.rut == "" || proveedor.descripcion == "" || proveedor.nombre == "")
                return null;
            return ps.Agregar(proveedor);
        }
        public List<Proveedor> Lista()
        {
            return ps.Lista();
        }
        public Boolean Modificar(Proveedor proveedor)
        {
            if (proveedor.descripcion == null || proveedor.nombre == null)
                return false;
            if (proveedor.descripcion == "" || proveedor.nombre == "")
                return false;
            ps.Modificar(proveedor);
            return true;
        }
        public void Borrar(String rut)
        {
            ps.Borrar(rut);
        }
    }
}
