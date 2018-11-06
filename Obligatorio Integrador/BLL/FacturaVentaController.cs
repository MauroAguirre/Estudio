using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class FacturaVentaController
    {
        FacturaVentaService fvs = new FacturaVentaService();  
        public FacturaVenta Agregar(DateTime fecha, string descripcion)
        {
            return fvs.Agregar(fecha, descripcion);
        }
    }
}
