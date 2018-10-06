using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Funcionartios")]
    public class Funcionario : Persona
    {
        public int ID { get; set; }
        public List<LineaFactura> LineaFacturas { get; set; }
    }
}
