using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class EnvioController
    {
        EnvioService envioService = new EnvioService();
        public List<Envio> DarEnviosDeUsuario(string mail)
        {
            return envioService.DarEnviosDeUsuario(mail);
        }
        public List<Envio> DarTodosEnvios()
        {
            return envioService.DarTodosEnvios();
        }
        public List<Paquete> Agregar(DateTime envio,DateTime llegada,string direccion,string usuario,List<Paquete> paqs)
        {
            if (paqs.Count == 0 || direccion=="" || direccion == null)
            {
                return null;
            }
            Envio env = new Envio() { FechaEnvio = envio, FechaLlegada = llegada, DireccionUsuario = direccion, DireccionLugar = "Ninguno", Estado = "Abierto", Paquetes = paqs,Usuario = usuario };
            envioService.Agregar(env, paqs);
            return paqs;
        }
        public Envio CambiarEnvio(string estado,string direccion,int id)
        {
            envioService.CambiarEnvio(estado, direccion, id);
            return null;
        }
    }
}
