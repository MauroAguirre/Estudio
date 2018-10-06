using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbandoORM
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarAgendas();
            //AgregarContacto("Matias","matias@gmail.com","uruguay","loquitos");
            MostarContactos();
            using (var db = new LaMegaAgenda())
            {
                /*
                var agenda = from c in db.Agenda
                             where c.nombre == "loquitos"
                             select c;
                var agenda = db.Agenda.Where(p => p.nombre == "loquitos").SingleOrDefault();
                var agendita = from d in db.Agenda
                               where d.nombre == "loquitos"
                               select d;
                Contacto contacto = new Contacto();
                contacto.nombre = "tatatata";
                contacto.mail = "tatata@gmail.com";
                contacto.pais = "Paraguay";
                contacto.Agenda = agendita.First();
                db.Contacto.Add(contacto);
                db.SaveChanges();
                */

            }
        }
        public static void AgregarAgenda(String nombre)
        {
            using (var db = new LaMegaAgenda())
            {
                Agenda agenda = new Agenda();
                agenda.nombre = nombre;
                agenda.fecha_creacion = DateTime.Now;
                db.Agenda.Add(agenda);
                db.SaveChanges();
            }
        }
        public static void MostrarAgendas()
        {
            using (var db = new LaMegaAgenda())
            {
                var agendas = from c in db.Agenda
                              select c;
                foreach (var agenda in agendas)
                {
                    Console.WriteLine(agenda.nombre + " " + agenda.fecha_creacion + " ");
                }
                Console.WriteLine("Ingrese un boton para continuar");
                Console.ReadKey();
            }
        }
        public static void AgregarContacto(String nombre, String mail, String pais,String agenda)
        {
            using (var db = new LaMegaAgenda())
            {
                var agendita = from d in db.Agenda where d.nombre == agenda select d;
                Contacto contacto = new Contacto();
                contacto.nombre = nombre;
                contacto.mail = mail;
                contacto.pais = pais;
                contacto.Agenda = agendita.First();
                db.Contacto.Add(contacto);
                db.SaveChanges();
            }
        }
        public static void MostarContactos()
        {
            using (var db = new LaMegaAgenda())
            {
                var contactos = from c in db.Contacto
                                select c;
                foreach (var contacto in contactos)
                {
                    Console.WriteLine(contacto.id + " " + contacto.nombre + " " + contacto.mail + " " + contacto.pais + " ");
                }
                Console.WriteLine("Ingrese algo para continuar");
                Console.ReadKey();
            }
        }
    }
}
