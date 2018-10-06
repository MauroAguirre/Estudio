using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Destino
    {
        #region Atributos
        private string nombre;
        private string ciudad;
        private string pais;
        private int costoDiario;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public int CostoDiario
        {
            get { return costoDiario; }
            set { costoDiario = value; }
        }
        #endregion

        public Destino(string nombre, string ciudad, string pais, int costoDiario)
        {
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.pais = pais;
            this.costoDiario = costoDiario;

        }
        public override string ToString()
        {
            return nombre + " - " + ciudad + " - " + pais + " - " + costoDiario;
        }
    }
}
