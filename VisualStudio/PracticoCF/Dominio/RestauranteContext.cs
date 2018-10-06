using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Dominio
{
    public class RestauranteContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder) { modelBuilder.Entity<Cliente>().Property(u => u.Ci).HasColumnName("Cedula"); }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
    }
}
