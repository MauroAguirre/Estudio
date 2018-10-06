using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario:Persona
    {
        public int ID { get; set; }
        public List<Envio> Envios { get; set; }
        public List<Paquete> Paquetes { get; set; }
    }
}
