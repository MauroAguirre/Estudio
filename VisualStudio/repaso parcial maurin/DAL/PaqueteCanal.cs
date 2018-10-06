using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaqueteCanal
    {
        public int id { get; set; }
        public Paquete paquete { get; set; }
        public Canal Canal { get; set; }
    }
}
