using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class Usuario
    {
        [Key]
        public string mail { get; set; }
        public string contra { get; set; }
    }
}
