using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Proveedor
    {
        private string rut { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private List<Contacto> contactos { get; set; }
    }
}
