using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class DireccionesController
    {
        DireccionesService direccionesService = new DireccionesService();
        public Direccion Crear(string nombre)
        {
            foreach (Direccion dir in direccionesService.Lista_de_Direcciones())
            {
                if (nombre == dir.Nombre)
                {
                    return null;
                }
            }
            direccionesService.Crear(nombre);
            Direccion dire = new Direccion() { Nombre = nombre };
            return dire;
        }
        public List<Direccion> Lista_de_Direcciones()
        {
            return direccionesService.Lista_de_Direcciones();
        }
        public void Borrar(string dir)
        {
            direccionesService.Borrar(dir);
        }
    }
}
