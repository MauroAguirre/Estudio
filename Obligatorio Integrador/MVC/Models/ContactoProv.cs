using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MVC.Models
{
    public class ContactoProv
    {
        public string nombre { get; set; }
        public int telefono { get; set; }
        //[ForeignKey("Standar")]
        public String proveedor { get; set; }
    }
}