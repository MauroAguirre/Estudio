using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Autos")]
    public class Auto : Servicio
    {
        public int Puertas { get; set; }
        public int NumMotor { get; set; }
        public int NumChasis { get; set; }
    }
}
