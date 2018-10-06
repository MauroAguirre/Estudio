using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Infraccion
    {
        private DateTime fecha;
        private int numeroCamara;
        private string matricula;
        private int codigo;
        private static int ultimoCodigo;
        public Infraccion(DateTime fecha, int numeroCamara, string matricula)
        {
            this.fecha = fecha;
            this.numeroCamara = numeroCamara;
            this.matricula = matricula;
            codigo = ++ultimoCodigo;
        }
    }
}
