using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.Entity;

namespace DAL
{
    public class ClienteService
    {
        public void Agregar(Cliente cliente)
        {
            using (var db = new EmpRepContext())
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }
        public List<Cliente> DarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var db = new EmpRepContext())
            {
                foreach (var c in db.Clientes)
                {
                    Cliente cliente = new Cliente() { Nombre = c.Nombre, Apellido = c.Apellido, Mail = c.Mail, Telefono = c.Telefono, Id = c.Id };
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }
    }
}
