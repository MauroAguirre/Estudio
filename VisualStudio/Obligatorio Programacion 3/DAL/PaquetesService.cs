using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class PaquetesService
    {
        public Paquete Crear(string mail, string des, int can, string tam)
        {
            Paquete paq;
            using (var db = new EmpresaContext())
            {
                Paquete paquete = new Paquete() { Descripcion = des, Cantidad = can, Usuario = mail, Tamano = tam,IdEnvio=-1};
                paq = db.Paquetes.Add(paquete);
                db.SaveChanges();
            }
            return paq;
        }
        public List<Paquete> DarPaquetesDeUsuarioDisponibles(string mail)
        {
            List<Paquete> paquetes = new List<Paquete>();
            using (var db = new EmpresaContext())
            {
                foreach (var paq in db.Paquetes)
                {
                    if (paq.Usuario == mail && paq.IdEnvio ==-1)
                    {
                        Paquete paquete = new Paquete() { Descripcion = paq.Descripcion, Cantidad = paq.Cantidad, Tamano = paq.Tamano, ID = paq.ID,IdEnvio = paq.IdEnvio};
                        paquetes.Add(paquete);
                    }
                }
                return paquetes;
            }
        }
        public void Modificar(string des, int can, string tam, int id)
        {
            using (var db = new EmpresaContext())
            {
                var paquete = db.Paquetes.Find(id);
                paquete.Descripcion = des;
                paquete.Cantidad = can;
                paquete.Tamano = tam;
                db.SaveChanges();
            }
        }
        public void Borrar(int id)
        {
            using (var db = new EmpresaContext())
            {
                var paq = db.Paquetes.Find(id);
                db.Paquetes.Remove(paq);
                db.SaveChanges();
            }
        }
        public Paquete EncontrarPaquete(int id)
        {
            Paquete paq;
            using (var db = new EmpresaContext())
            {
                paq = db.Paquetes.Find(id);
            }
            return paq;
        }
    }
}
