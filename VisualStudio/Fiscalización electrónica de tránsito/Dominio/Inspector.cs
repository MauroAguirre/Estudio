using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Inspector
    {
        private static int ultimoCodigo;
        private int codigo;
        private string nombre;
        private string correo;
        private DateTime fechaNacimiento;
        public Inspector(string nombre,string correo,DateTime fechaNacimiento) 
        {
            this.codigo = ++ultimoCodigo;
            this.nombre = nombre;
            this.correo = correo;
            this.fechaNacimiento = fechaNacimiento;
        }
    }
}
