using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mascota
    {
        #region Atributos
        private static int ultimoCodigo;
        private int codigo;
        private string nombre;
        private string raza;
        private DateTime edad;
        private Cliente dueño;
        #endregion
        #region Constructor
        public Mascota(string nuevoNombre, string nuevaRaza, DateTime nuevaEdad, Cliente nuevoDueño)
        {
            nombre = nuevoNombre;
            raza = nuevaRaza;
            edad = nuevaEdad;
            dueño = nuevoDueño;
            codigo = ++ultimoCodigo;
        }
        public override string ToString()
        {
            return "Codigo: "+codigo+"\nNombre: " + nombre +"\nNombre del dueño:"+dueño.Nombre+ "\nRaza: " + raza + "\nEdad: " + edad.ToShortDateString();
        }
        #endregion
    }
}
