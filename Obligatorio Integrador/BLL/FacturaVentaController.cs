using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;

namespace BLL
{
    public class FacturaVentaController
    {
        private static FacturaVentaController instancia;
        public static FacturaVentaController Instancia()
        {
            if (instancia == null)
                instancia = new FacturaVentaController();
            return instancia;
        }
        FacturaVentaService fvs = FacturaVentaService.Instancia();
        public FacturaVenta Agregar(DateTime fecha, string descripcion)
        {
            return fvs.Agregar(fecha, descripcion);
        }
        public List<FacturaVenta> Lista()
        {
            return fvs.Lista();
        }
        public int TotalFactura(int id)
        {
            return fvs.TotalFactura(id);
        }
        public FacturaVenta UnaFactura(int id)
        {
            return fvs.UnaFactura(id);
        }
    }
}
