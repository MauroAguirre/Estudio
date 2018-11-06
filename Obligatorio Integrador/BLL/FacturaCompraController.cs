using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class FacturaCompraController
    {
        FacturaCompraService fcs = new FacturaCompraService();
        public FacturaCompra Agregar(DateTime fecha,string rut)
        {
            return fcs.Agregar(fecha,rut);
        }
        public List<FacturaCompra> Lista(string rut)
        {
            return fcs.Lista(rut);
        }
    }
}
