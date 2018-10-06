using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Paquete
    {
        public enum Tipo { Grande, Mediano, Chico };
        [Key]
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Tamano { get; set; }
        public string Usuario { get; set; }
        public int IdEnvio { get; set; }
    }
}
