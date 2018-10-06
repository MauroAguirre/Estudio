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
        public void Crear(String nombre, String mail ,DateTime fechaNacimiento, String pais, String nombre_agenda)
        {
            Contacto contacto = new Contacto();
            contacto.Nombre = nombre;
            contacto.FechaNacimiento = fechaNacimiento;
            contacto.Mail = mail;
            contacto.Pais = pais;
            Crear(contacto,nombre_agenda);
        }
        public void Crear(Contacto contacto,String mail_agenda)
        {
            ContactoService contactoService = new ContactoService();
            contactoService.Guardar(contacto, mail_agenda);
        }
        public Contacto Obtener()
        {
            return null;
        }
        public void Mostrar()
        {
            ContactoService contactoService = new ContactoService();
            contactoService.Mostrar();
        }
        public void Borrar(int cual)
        {
            ContactoService contactoService = new ContactoService();
            contactoService.Borrar(cual);
        }
        public void Modificar_mail(int cual, String mail)
        {
            ContactoService contactoService = new ContactoService();
            contactoService.Modificar_mail(cual, mail);
        }
        public void Mostrar_contacto_por_mail(String mail)
        {
            ContactoService contactoService = new ContactoService();
            contactoService.Buscar_contacto_por_mail(mail);
        }
    }
}
