using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbandoORM_primero_codigo_de_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3421412");
            using (var db = new AgendaContext())
            {
                Persona persona = new Persona();
                persona.Nombre = "mujica";
                db.Personas.Add(persona);
                db.SaveChanges();
                foreach (var p in db.Personas)
                {
                    Console.WriteLine(p.ID+" "+p.Nombre);
                }
            }
            Console.ReadKey();
        }
    }
}
