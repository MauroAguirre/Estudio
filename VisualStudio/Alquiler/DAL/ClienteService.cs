using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class ClienteService
    {
        public void Salvar(Cliente cliente)
        {
            using (var db = new AlquilerContext())
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }
    }
}
