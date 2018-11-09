using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class ArticuloProveedor
    {
        [Key]
        public int id { get; set; }
        public int costo {get;set;}
        public DateTime fecha { get; set; }
        public Proveedor proveedor { get; set; }
        public Articulo articulo { get; set; }
    }
}
