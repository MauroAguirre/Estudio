using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class RegistroController
    {
        RegistroService rs = new RegistroService();
        public List<Registro> Lista()
        {
            return rs.Lista();
        }
    }
}
