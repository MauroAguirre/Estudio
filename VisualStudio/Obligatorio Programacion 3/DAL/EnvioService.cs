using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class EnvioService
    {
        public List<Envio> DarEnviosDeUsuario(string mail)
        {
            List<Envio> envios = new List<Envio>();
            using (var db = new EmpresaContext())
            {
                foreach (var env in db.Envios)
                {
                    if (env.Usuario == mail)
                    {
                        Envio envio = new Envio() { ID = env.ID, DireccionLugar = env.DireccionLugar, DireccionUsuario = env.DireccionUsuario,Estado= env.Estado,FechaEnvio= env.FechaEnvio,
                        FechaLlegada= env.FechaLlegada,Paquetes= env.Paquetes,Usuario= env.Usuario};
                        envios.Add(envio);
                    }
                }
            }
            return envios;
        }
        public List<Envio> DarTodosEnvios()
        {
            List<Envio> envios = new List<Envio>();
            using (var db = new EmpresaContext())
            {
                foreach (var env in db.Envios)
                {
                    Envio envio = new Envio()
                    {
                        ID = env.ID,
                        DireccionLugar = env.DireccionLugar,
                        DireccionUsuario = env.DireccionUsuario,
                        Estado = env.Estado,
                        FechaEnvio = env.FechaEnvio,
                        FechaLlegada = env.FechaLlegada,
                        Paquetes = env.Paquetes,
                        Usuario = env.Usuario
                    };
                    envios.Add(envio);
                }
            }
            return envios;
        }
        public void Agregar(Envio envio,List<Paquete> paquetes)
        {
            using (var db = new EmpresaContext())
            {
                DateTime fec1 = new DateTime(envio.FechaEnvio.Year, envio.FechaEnvio.Month, envio.FechaEnvio.Day);
                DateTime fec2 = new DateTime(envio.FechaLlegada.Year, envio.FechaLlegada.Month, envio.FechaLlegada.Day);
                Envio env = new Envio()
                {
                    DireccionLugar = envio.DireccionLugar,
                    DireccionUsuario = envio.DireccionUsuario,
                    Estado = envio.Estado,
                    FechaEnvio = fec1,
                    FechaLlegada = fec2,
                    Usuario = envio.Usuario,
                };
                db.Envios.Add(env);
                db.SaveChanges();
                int ide = db.Envios.ToList().Last().ID;
                foreach (Paquete paq in paquetes)
                {
                    foreach (Paquete paquetito in db.Paquetes)
                    {
                        if (paq.ID == paquetito.ID)
                        {
                            paquetito.IdEnvio= ide;
                        }
                    }
                }
                db.SaveChanges();
            }
        }
        public void CambiarEnvio(string estado, string direccion, int id)
        {
            using (var db = new EmpresaContext())
            {
                var envio = db.Envios.Find(id);
                envio.Estado = estado;
                envio.DireccionLugar = direccion;
                db.SaveChanges();
            }
        }
    }
}
