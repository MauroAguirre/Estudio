using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Casas")]
    public class Casa : Servicio
    {
        public int Habitaciones { get; set; }
        public int Baños { get; set; }
        public Boolean Cochera { get; set; }
        public string Direccion { get; set; }
    }
}
