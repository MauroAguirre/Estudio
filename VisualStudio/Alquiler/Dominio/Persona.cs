using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public abstract class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
}
