using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class ContactoController
    {
        ContactoService cs = new ContactoService();
        public Contacto Agregar(string p, string n,int t)
        {
            if (p == null || n==null)
                return null;
            if (cs.Lista(p).Count == 4)
                return null;
            return cs.Agregar(p,n,t);
        }
        public List<Contacto> Lista(string rut)
        {
            return cs.Lista(rut);
        }
        public void Modificar(string rut, string nombre,int telefono)
        {
            cs.Modificar(rut,nombre,telefono);
        }
        public void Borrar(string rut, string nombre)
        {
            cs.Borrar(rut,nombre);
        }
    }
}
