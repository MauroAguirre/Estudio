using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;

namespace BLL
{
    public class FacturaCompraController
    {
        private static FacturaCompraController instancia;
        public static FacturaCompraController Instancia()
        {
            if (instancia == null)
                instancia = new FacturaCompraController();
            return instancia;
        }
        FacturaCompraService fcs = FacturaCompraService.Instancia();
        public FacturaCompra Agregar(DateTime fecha,string rut)
        {
            return fcs.Agregar(fecha,rut);
        }
        public List<FacturaCompra> Lista(string rut)
        {
            return fcs.Lista(rut);
        }
        public int TotalFactura(int id)
        {
            return fcs.TotalFactura(id);
        }
        public FacturaCompra UnaFactura(int id)
        {
            return fcs.UnaFactura(id);
        }
    }
}
