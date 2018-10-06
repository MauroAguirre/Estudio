using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DestinoEstadia
    {
        #region atributos
        private int diasEstadia;
        private Destino destino;
        
        #endregion

        #region propiedades
        public int DiasEstadia
        {
            get { return diasEstadia; }
            set { diasEstadia = value; }
        }
        public string Lugar
        {
            get { return destino.Nombre; }
            set { destino.Nombre = value; }
        }
        public Destino Destino
        {
            get { return destino; }
            set { destino = value; }
        }
        #endregion

        public DestinoEstadia(Destino destino, int diasEstadia)
        {
            this.destino = destino;
            this.diasEstadia = diasEstadia;
        }
        
    }
}
