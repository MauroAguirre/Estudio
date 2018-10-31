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
        public Contacto Agregar(Contacto contacto)
        {
            if (contacto.nombre != null)
                return null;
            return cs.Agregar(contacto);
        }
        public List<Contacto> Lista()
        {
            return cs.Lista();
        }
        public void Modificar(Contacto contacto)
        {
            cs.Modificar(contacto);
        }
        public void Borrar(String rut, String nombre)
        {
            cs.Borrar(rut,nombre);
        }
    }
}
