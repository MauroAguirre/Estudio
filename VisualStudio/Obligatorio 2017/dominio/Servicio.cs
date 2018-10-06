using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Servicio
    {
        #region Atributos
        private string nombre;
        private int costoPorPersona;
        #endregion
        #region Metodos
        public int CostoPorPersona 
        {
            get { return costoPorPersona; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public Servicio(string nombre, int costoPorPersona) 
        {
            this.nombre = nombre;
            this.costoPorPersona = costoPorPersona;
        }
        public override string ToString()
        {
            return "\nNombre: " + nombre + "\nCosto por persona: " + costoPorPersona;
        }
        #endregion
    }
}
