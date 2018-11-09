using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Registro
    {
        public int id { get; set; }
        public Articulo articulo { get; set; }
        public DateTime fecha { get; set; }
        public int cambio { get; set; }
    }
}
