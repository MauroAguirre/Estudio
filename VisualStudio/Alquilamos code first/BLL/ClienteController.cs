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
        ClienteServicio clienteServicio = new ClienteServicio();
        public void Agregar(int documento,string nombre)
        {
            Cliente cliente = new Cliente();
            cliente.Documento = documento;
            cliente.Nombre = nombre;
            clienteServicio.Agregar(cliente);
        }
        public void Agregar(Cliente cliente)
        {
            clienteServicio.Agregar(cliente);
        }
        public void Mostrar()
        {
            clienteServicio.Mostrar();
        }
        public List<Cliente> DarClientes()
        {
            return clienteServicio.DarClientes();
        }
        public void Eliminar(Cliente cliente)
        {
            clienteServicio.Eliminar(cliente);
        }
    }
}
