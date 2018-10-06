using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Internacional : Excursion
    {
        private static int seguro;

        public static int Seguro
        {
            get { return seguro; }
            set { seguro = value; }
        }
        public Internacional(string codigo, string descripcion, DateTime fechaComienzo, int diaTraslado, List<DestinoEstadia> destinoEstadias, int stock,int costoTraslado) : base(codigo,descripcion,fechaComienzo,diaTraslado,destinoEstadias,stock,costoTraslado)
        {
            seguro = 1000;
        }
        public override int Costo()
        {
           
            int costo = 0;
            int diaEstadia = 0;
            foreach (DestinoEstadia unD in DestinoEstadia)
            {
                costo += unD.DiasEstadia * unD.Destino.CostoDiario;
                diaEstadia += unD.DiasEstadia;
            }
            costo += CostoTraslado * DiaTraslado;
            costo *= Stock;

            costo += (seguro * (DiaTraslado + diaEstadia));
            return costo;
            
        }
    }
}
