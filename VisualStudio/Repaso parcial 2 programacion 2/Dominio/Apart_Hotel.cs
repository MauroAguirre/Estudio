using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Apart_Hotel :Alojamiento
    {
        private int costoDiario;
        private bool garajePrivado;

        public Apart_Hotel(int costoDiario, bool garajePrivado, string codigo, string ubicacion, int canMaxHuespedes) : base(codigo, ubicacion, canMaxHuespedes)
        {
            this.costoDiario = costoDiario;
            this.garajePrivado = garajePrivado;
        }
        public override int Costo(int dias)
        {
            int costo = costoDiario * dias;
            if (garajePrivado == true)
                costo += (costo * 20/100);
            return costo;
        }
    }
}
