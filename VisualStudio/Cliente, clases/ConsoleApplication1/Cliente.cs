using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cliente :Persona
    {
        private int cedula;
        private string nombre;
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        
    }
}
