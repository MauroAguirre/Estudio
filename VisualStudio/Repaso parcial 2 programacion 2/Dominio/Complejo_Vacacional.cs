using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Complejo_Vacacional
    {
        private List<Alojamiento> alojamientos;
        private List<Cliente> clientes;
        private List<Registro_de_Estadia> estadias;
        private static Complejo_Vacacional instancia;
        public static Complejo_Vacacional Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new Complejo_Vacacional();
                return instancia;
            }         
        }
        public Complejo_Vacacional()
        {
            alojamientos = new List<Alojamiento>();
            clientes = new List<Cliente>();
            estadias = new List<Registro_de_Estadia>();
            Cabaña c1 = new Cabaña(10, true, true, "1322", "Puerto Rico", 16);
            Cabaña c2 = new Cabaña(15, true, true, "7322", "Puerto Rico", 18);
            Cabaña c3 = new Cabaña(19, true, true, "3322", "Puerto Rico", 12);
            Cabaña c4 = new Cabaña(12, true, true, "2322", "Puerto Rico", 12);
            alojamientos.Add(c1);
            alojamientos.Add(c2);
            alojamientos.Add(c3);
            alojamientos.Add(c4);
            alojamientos.Sort();
        }
        public void Alta_de_Alojamiento(Alojamiento alojamiento)
        {
            alojamientos.Add(alojamiento);
        }
        public List<Alojamiento> DarAlojamientos()
        {
            List<Alojamiento> auxAlojamientos = new List<Alojamiento>();
            foreach (Alojamiento a in alojamientos)
            {
                auxAlojamientos.Add(a);
            }
            return auxAlojamientos;
        }
    }
}
