using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Comunicacion
    {
        [Key]
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string comentario { get; set; }
        public Contacto contacto { get; set; }
    }
}
