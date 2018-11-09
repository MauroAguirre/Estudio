using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;

namespace BLL
{
    public class ComunicacionController
    {
        private static ComunicacionController instancia;
        public static ComunicacionController Instancia()
        {
            if (instancia == null)
                instancia = new ComunicacionController();
            return instancia;
        }
        ComunicacionService cs = ComunicacionService.Instancia();
        public Comunicacion Agregar(Comunicacion c, int id)
        {
            return cs.Agregar(c,id);
        }
        public List<Comunicacion> Lista()
        {
            return cs.Lista();
        }
    }
}
