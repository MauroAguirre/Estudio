using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pagina.Models
{
    public class paqueton
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Tamano { get; set; }
        public string Mail { get; set; }
    }
}