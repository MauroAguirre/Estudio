using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Pagina.Models
{
    public class Envitito
    {
        public string Mail { get; set; }
        public DateTime Envio { get; set; }
        public DateTime Llegada { get; set; }
        public string Direccion { get; set; }
        public List<Paquete> Paquetes { get; set; }
    }
}