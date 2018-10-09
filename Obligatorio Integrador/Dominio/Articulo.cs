﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Articulo
    {
        [Key]
        public int id { get; set; }
        public string descripcion { get; set; }
        public Boolean iva { get; set; }
        public int miniStock { get; set; }
    }
}
