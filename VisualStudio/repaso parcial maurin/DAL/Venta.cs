using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Venta
    {
        public int id { get; set; }
        public Paquete paquete { get; set; }
        public DateTime fecha { get; set; }
        public Cliente cliente { get; set; }
        public int costo { get; set; }
    }
}
