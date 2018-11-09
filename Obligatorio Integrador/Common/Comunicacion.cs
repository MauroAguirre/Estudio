using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class Comunicacion
    {
        [Key]
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string comentario { get; set; }
        public Contacto contacto { get; set; }
        public string tipo { get; set; }
    }
}
