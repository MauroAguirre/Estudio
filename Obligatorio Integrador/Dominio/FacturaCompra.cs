﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FacturaCompra : Factura
    {
        public Proveedor proveedor { get; set; }
    }
}
