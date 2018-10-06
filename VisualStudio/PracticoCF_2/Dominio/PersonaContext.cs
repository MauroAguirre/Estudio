using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class PersonaContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public PersonaContext() : base("con") { }
    }

}
