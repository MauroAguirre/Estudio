using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Persona
    {
        public string Nombre { get; set; }
        [Key]
        public string Mail { get; set; }
        public string Contra { get; set; }
    }
}
