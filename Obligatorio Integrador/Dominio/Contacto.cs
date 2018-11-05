using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dominio
{
    public class Contacto
    {
        [Key]
        public string nombre { get; set; }
        public int telefono { get; set; }
        public Proveedor proveedor { get; set; }
    }
}
