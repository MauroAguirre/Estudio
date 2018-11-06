using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class LineaFacturaController
    {
        LineaFacturaService lfs = new LineaFacturaService();
        public LineaFactura Agregar(int cantidad, int factura, int articulo, Boolean compra)
        {
            return lfs.Agregar(cantidad, factura, articulo, compra);
        }
    }
}
