using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Envio
    {
        public enum estado { abierto, entransito, entregado };
        [Key]
        public int ID { get; set; }
        public DateTime FechaEnvio { get; set; }
        public DateTime FechaLlegada { get; set; }
        public List<Paquete> Paquetes { get; set; }
        public string DireccionUsuario { get; set; }
        public string Estado { get; set; }
        public string DireccionLugar { get; set; }
        public string Usuario { get; set; }
    }
}
