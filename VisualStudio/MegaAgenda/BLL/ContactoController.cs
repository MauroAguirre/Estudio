using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class ContactoController
    {
        private static ContactoController instancia = null;
        public static ContactoController Instancia()
        {
            if (ContactoController.instancia == null)
            {
                ContactoController.instancia = new ContactoController();
            }
            return ContactoController.instancia;
        }
        public void Crear(String nombre, DateTime fechaNacimiento, String mail,string agenda_nombre)
        {
            Contacto contacto = new Contacto();
            contacto.Nombre = nombre;
            contacto.FechaNacimiento = fechaNacimiento;
            contacto.Mail = mail;
            Crear(contacto,agenda_nombre);
        }
        public void Crear(Contacto contacto, string agenda_nombre)
        {
            ContactoService contactoService = new ContactoService();
            contactoService.Guardar(contacto,agenda_nombre);
        }
        public Contacto Obtener()
        {
            return null;
        }
        public void Mostrar(string agenda_nombre)
        {
            ContactoService contactoService = new ContactoService();
            contactoService.Mostrar(agenda_nombre);
        }
    }
}
