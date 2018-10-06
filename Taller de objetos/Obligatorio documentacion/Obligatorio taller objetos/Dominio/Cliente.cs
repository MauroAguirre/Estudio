using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente :IComparable<Cliente>
    {
        #region propiedades
        private string nombre;
        private string apellido;
        private int ci;
        private int codigo;        
        private static int ultimoCodigo;
        private int puntos;
        #endregion

        #region atributos
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Ci
        {
            get { return ci; }
            set { ci = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }
        #endregion

        public Cliente(string nombre, string apellido, int ci)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ci = ci;
            codigo = ++ ultimoCodigo;
            puntos = 0;
        }
        public override string ToString()
        {
            return codigo + " - " + nombre;
        }
        public int CompareTo(Cliente c)
        {
            if (c == null)
                return 1;
            return c.puntos - puntos;
        }
    }
}
