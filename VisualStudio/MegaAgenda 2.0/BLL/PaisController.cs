using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class PaisController
    {
        private static PaisController instancia = null;
        public static PaisController Instancia()
        {
            if (PaisController.instancia == null)
            {
                PaisController.instancia = new PaisController();
            }
            return PaisController.instancia;
        }
        public void Crear(String nombre)
        {
            Pais pais = new Pais();
            pais.Nombre = nombre;
        }
        public void Mostrar()
        {
            PaisService paisService = new PaisService();
            paisService.Mostrar();
        }
        public String Elegir_Pais(int cual)
        {
            PaisService paisService = new PaisService();
            return paisService.Elegir_pais(cual);
        }
    }
}
