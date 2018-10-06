using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProbandoORM_primero_codigo_de_DB
{
    public class AgendaContext : DbContext
    {
        public virtual DbSet<Persona> Personas { get; set; }
    }
}
