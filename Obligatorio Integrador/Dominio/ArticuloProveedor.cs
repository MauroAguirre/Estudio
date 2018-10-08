using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class ArticuloProveedor
    {
        private int costo {get;set;}
        private DateTime fecha { get; set; }
        private Proveedor proveedor { get; set; }
        private Articulo articulo { get; set; }
    }
}
