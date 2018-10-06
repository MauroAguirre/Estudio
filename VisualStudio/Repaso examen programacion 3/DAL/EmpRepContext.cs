using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.Entity;

namespace DAL
{
    class EmpRepContext : DbContext
    {
        public virtual DbSet<Canal> Canales { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
    }
}
