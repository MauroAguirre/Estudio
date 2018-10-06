using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class PaquetesController
    {
        PaquetesService paquetesService = new PaquetesService();
        EnvioService envioService = new EnvioService();
        public Paquete Agregar(string mail,string des,int can,string tam)
        {

            if (des == "" || can < 1)
            {
                return null;
            }
            return paquetesService.Crear(mail,des,can,tam);
        }
        public List<Paquete> DarPaquetesDeUsuarioDisponibles(string mail)
        {
            return paquetesService.DarPaquetesDeUsuarioDisponibles(mail);
        }
        public bool Modificar(string des, int can, string tam,string id)
        {
            if (des == "" || des == null|| can < 1)
            {
                return false;
            }
            paquetesService.Modificar(des,can,tam,int.Parse(id));
            return true;
        }
        public void Borrar(string id)
        {
            paquetesService.Borrar(int.Parse(id));
        }
        public Paquete DarUnPaquete(int id)
        {
            return paquetesService.EncontrarPaquete(id);
        }
        public List<Paquete> AgregarPaq(List<Paquete> paquetes,int id,string mail)
        {
            Paquete paq = paquetesService.EncontrarPaquete(id);
            foreach (Paquete paquetito in paquetes)
            {
                if (paquetito.ID == id)
                {
                    return null;
                }
            }
            paquetes.Add(paq);
            return paquetes;
        }
        public List<Paquete> BorrarPaq(List<Paquete> paquetes, int id)
        {
            int lugar=-1;
            int pos = 0;
            foreach (Paquete paq in paquetes)
            {
                if (paq.ID == id)
                {
                    lugar = pos;
                }
                pos++;
            }
            paquetes.RemoveAt(lugar);
            return paquetes;
        }
    }
}
