using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;

namespace MVC.Models
{
    public class ProveedorContactos
    {
        public Proveedor proveedor { get; set; }
        public String[] contactos { get; set; }
    }
}