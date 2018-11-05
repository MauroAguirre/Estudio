using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Proveedor
    {
        [Key]
        public string rut { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public List<Contacto> contactos { get; set; }
        public Boolean activo { get; set; }
    }
}
