using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_parcial_1
{
    class Cliente
    {
        private enum Tipo{familiar,personal};
        private string nombre;
        private string direccion;
        private int telefono;
        public static int ultimoId;
        private int id;
        private List<ServicioComprado> serviciosComprados;

        public List<ServicioComprado> RetornarServicioComprados() 
        {
            List<ServicioComprado> auxServiciosComprados = new List<ServicioComprado>();
            foreach (ServicioComprado servicito in serviciosComprados) 
            {
                auxServiciosComprados.Add(servicito);
            }
            return auxServiciosComprados;
        }
        public int PorcentajeServiciosRelizados() 
        {
            int serviciosRealizados= 0;
            foreach(ServicioComprado servicito in serviciosComprados)
            {
                if(servicito.SeRealizo == true)
                    serviciosRealizados++;
            }
            return (serviciosComprados.Count * 100) / serviciosRealizados;
        }
    }
}
