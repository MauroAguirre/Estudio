using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Nacional: Excursion
    {
        private int descuento;

	    public int Descuento
	    {
		    get { return descuento;}
		    set { descuento = value;}
	    }
        public Nacional(string codigo, string descripcion, DateTime fechaComienzo, int diaTraslado, List<DestinoEstadia> destinoEstadias, int stock, int costoTraslado,int descuento) : base(codigo, descripcion, fechaComienzo, diaTraslado, destinoEstadias, stock, costoTraslado)
        {
            this.descuento = descuento;
        }
        public override int Costo()
        {
            
            int costo = 0;
            foreach (DestinoEstadia unD in DestinoEstadia)
            {
                costo += unD.DiasEstadia * unD.Destino.CostoDiario;
            }
            costo += CostoTraslado * DiaTraslado;
            costo *= Stock;

            costo -= (costo * descuento) / 100;
            return costo;
        }
    }
}
