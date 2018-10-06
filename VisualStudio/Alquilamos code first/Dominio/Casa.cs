using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Casas")]
    public class Casa : Servicio
    {
        public int ID { get; set; }
        public int CantDormitorios { get; set; }
        public int Banios { get; set; }
        public bool Cochera { get; set; }
        public string Direccion { get; set; }

    }
}
