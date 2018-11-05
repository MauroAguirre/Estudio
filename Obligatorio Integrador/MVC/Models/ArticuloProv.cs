using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ArticuloProv
    {
        public int id { get; set; }
        public int costo { get; set; }
        public DateTime fecha { get; set; }
        public string proveedor { get; set; }
        public int articulo { get; set; }
    }
}