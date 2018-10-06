using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int Id { get; set; }
        public Paquete Paquete { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public int Costo { get; set; }
    }
}
