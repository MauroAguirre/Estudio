using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lavado : Servicio
    {
        private bool prodAntiBug;

        public bool ProdAntiBug
        {
            get { return prodAntiBug; }
            set { prodAntiBug = value; }
        }
        public override string ToString()
        {
            string respuesta;
            if (prodAntiBug)
                respuesta = "Tiene productos anti-insectos";
            else
                respuesta = "No tiene productos anti-insectos";
            return "Descripcion: " + this.Descripcion + "\nPrecio: " + this.Precio + "\n" + respuesta;
        }

    }
}
