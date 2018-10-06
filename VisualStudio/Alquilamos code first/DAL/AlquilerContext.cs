﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio;

namespace DAL
{
    public class AlquilerContext : DbContext
    {
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<LineaFactura> LineaFacturas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Casa> Casas { get; set; }
        public DbSet<Bote> Botes { get; set; }
    }
}
