using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.Entity;

namespace DAL
{
    class EmpresaContext : DbContext
    {
        public virtual DbSet<Administrador> Administradores { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Envio> Envios { get; set; }
        public virtual DbSet<Paquete> Paquetes { get; set; }
        public virtual DbSet<Direccion> Direcciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Administrador>().ToTable("Administrador");
        }
    }
}
