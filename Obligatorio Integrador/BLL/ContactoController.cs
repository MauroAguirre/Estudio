using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;

namespace BLL
{
    public class ContactoController
    {
        private static ContactoController instancia;
        public static ContactoController Instancia()
        {
            if (instancia == null)
                instancia = new ContactoController();
            return instancia;
        }
        ContactoService cs = ContactoService.Instancia();
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
        public void Modificar(int id, string nombre,int telefono)
        {
            cs.Modificar(id,nombre,telefono);
        }
        public void Borrar(int id)
        {
            cs.Borrar(id);
        }
    }
}
