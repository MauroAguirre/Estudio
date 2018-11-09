using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;

namespace MVC.Models
{
    public class ArtStocEstado
    {
        public Articulo articulo { get; set; }
        public int stock { get; set; }
        public string estado { get; set; }
    }
}