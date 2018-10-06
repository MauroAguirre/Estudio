using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class ClienteServicio
    {
        public void Agregar(Cliente cliente)
        {
            using (var db = new AlquilerContext())
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }
        public void Mostrar()
        {
            using (var db = new AlquilerContext())
            {
                var query = from c in db.Clientes select c;
                foreach (var c in query)
                {
                    Console.WriteLine(c.ID + " " + c.Nombre + " " + c.Documento+"\n");
                }
            }
        }
        public List<Cliente> DarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var db = new AlquilerContext())
            {
                foreach (var clientito in db.Clientes)
                {
                    Cliente cliente = new Cliente();
                    cliente.ID = clientito.ID;
                    cliente.Nombre = clientito.Nombre;
                    cliente.Documento = clientito.Documento;
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }
        public void Eliminar(Cliente cliente)
        {
            using (var db = new AlquilerContext())
            {
                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }
        }
    }
}
