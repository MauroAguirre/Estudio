using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class ClienteController
    {
        ClienteService cs = new ClienteService();
        public void Agregar(Cliente cliente)
        {
            cs.Agregar(cliente);
        }
        public List<Cliente> DarClientes()
        {
            return cs.DarClientes();
        }
    }
}
