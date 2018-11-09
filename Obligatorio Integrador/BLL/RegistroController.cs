using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;

namespace BLL
{
    public class RegistroController
    {
        private static RegistroController instancia;
        public static RegistroController Instancia()
        {
            if (instancia == null)
                instancia = new RegistroController();
            return instancia;
        }
        RegistroService rs = RegistroService.Instancia();
        public List<Registro> Lista()
        {
            return rs.Lista();
        }
        public int Stock_Producto(int id)
        {
            return rs.Stock_Producto(id);
        }
    }
}
