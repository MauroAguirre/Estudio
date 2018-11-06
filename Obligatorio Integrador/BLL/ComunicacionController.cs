using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class ComunicacionController
    {
        ComunicacionService cs = new ComunicacionService();
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
