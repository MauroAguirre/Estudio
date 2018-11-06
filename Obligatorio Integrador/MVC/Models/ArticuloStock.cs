using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace MVC.Models
{
    public class ArticuloStock
    {
        public Articulo articulo { get; set; }
        public int stock { get; set; }
        public int id { get; set; }
    }
}