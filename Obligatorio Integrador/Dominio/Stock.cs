using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Stock
    {
        [Key]
        public int id { get; set; }
        public Articulo articulo { get; set; }
        public int cambio { get; set; }
        public string fecha { get; set; }
    }
}
