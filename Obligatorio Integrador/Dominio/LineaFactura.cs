﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class LineaFactura
    {
        [Key]
        public int id { get; set; }
        public int cantidad { get; set; }
        public Articulo articulo { get; set; }
        public Factura factura { get; set; }
    }
}
