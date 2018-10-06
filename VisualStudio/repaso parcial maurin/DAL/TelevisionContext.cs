using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class TelevisionContext : DbContext
    {
        public virtual DbSet<Cliente> clientes { get; set; }
        public virtual DbSet<Venta> ventas { get; set; }
        public virtual DbSet<Canal> canales { get; set; }
        public virtual DbSet<Paquete> paquetes { get; set; }
        public virtual DbSet<PaqueteCanal> paqueteCanales { get; set; }
    }
}
