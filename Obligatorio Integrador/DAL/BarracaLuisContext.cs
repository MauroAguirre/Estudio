using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class BarracaLuisContext: DbContext
    {
        public virtual DbSet<Articulo> articulos { get; set; }
        public virtual DbSet<Proveedor> proveedores { get; set; }
        public virtual DbSet<ArticuloProveedor> articuloProveedores { get; set; }
        public virtual DbSet<Comunicacion> comunicaciones { get; set; }
        public virtual DbSet<FacturaCompra> facturaCompras { get; set; }
        public virtual DbSet<FacturaVenta> facturasVentas { get; set; }
        public virtual DbSet<LineaFactura> lineafacturas { get; set; }
        public virtual DbSet<Contacto> contactos { get; set; }
        public virtual DbSet<Usuario> usuarios { get; set; }
        public virtual DbSet<Registro> registro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FacturaCompra>().ToTable("facturaCompras");
            modelBuilder.Entity<FacturaVenta>().ToTable("facturaVentas");
        }
    }
}
