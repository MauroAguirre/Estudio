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
        private ClienteService clienteService = new ClienteService();
        public void Agregar(int id, string nombre)
        {
            Cliente cliente = new Cliente();
            cliente.ID = id;
            cliente.Nombre = nombre;
            clienteService.Salvar(cliente);
        }
    }
}
