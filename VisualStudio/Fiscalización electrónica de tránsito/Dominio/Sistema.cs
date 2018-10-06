using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        private List<Inspector> inspectores;
        private List<Multa> multas;
        private List<Infraccion> infracciones;
        private static Sistema instancia;
        public static Sistema Instancia
        {
            get
            {
                if (instancia == null) 
                    instancia = new Sistema();
                return instancia;
            }  
        }
        private Sistema() 
        { 
            inspectores = new List<Inspector>();
            multas = new List<Multa>();
            infracciones = new List<Infraccion>();
        }
        public void AgregarInfraccion(Infraccion nuevaInfraccion) 
        {
            infracciones.Add(nuevaInfraccion);
        }
        public void AgregarInspector(Inspector nuevoInspector)
        {
            inspectores.Add(nuevoInspector);
        }
    }
}
