using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public abstract class Factura
    {
        [Key]
        public int id { get; set; }
        public List<LineaFactura> LineaFacturas { get; set; }
        public DateTime fecha { get; set; }
    }
}
