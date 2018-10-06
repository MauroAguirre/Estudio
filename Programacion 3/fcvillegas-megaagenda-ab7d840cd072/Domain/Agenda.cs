using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaAgenda.common
{
    public class Agenda
    {
        public String Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
