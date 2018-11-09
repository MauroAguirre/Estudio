using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;

namespace BLL
{
    public class LineaFacturaController
    {
        private static LineaFacturaController instancia;
        public static LineaFacturaController Instancia()
        {
            if (instancia == null)
                instancia = new LineaFacturaController();
            return instancia;
        }
        LineaFacturaService lfs = LineaFacturaService.Instancia();
        public LineaFactura Agregar(int cantidad,int precio, int factura, int articulo, Boolean compra)
        {
            return lfs.Agregar(cantidad,precio, factura, articulo, compra);
        }
    }
}
