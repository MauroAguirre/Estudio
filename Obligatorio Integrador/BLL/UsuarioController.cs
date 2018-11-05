using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dominio;

namespace BLL
{
    public class UsuarioController
    {
        UsuarioService us = new UsuarioService();
        public Boolean Agregar(Usuario usuario)
        {
            string ultimaParte = "";
            Boolean correcto = false;
            List<Usuario> usuarios = us.Lista();
            //si algun parametro viene en null error
            if (usuario.mail == null || usuario.contra == null)
            {
                return false;
            }
            //tiene que terminar en @gmail.com (10+1) o @hotmail.com (12+1) por lo tanto tiene que tener que ser mayor al siguiente tamaño
            if (usuario.mail.Length < 11)
                return false;
            //si el mail es chico solo hau que verificar que termine en @gmail.com
            if (usuario.mail.Length < 13)
            {
                for (int i = usuario.mail.Length - 10; i < usuario.mail.Length; i++)
                    ultimaParte += usuario.mail.ElementAt(i);
                if (ultimaParte != "gmail.com")
                    return false;
            }
            // si el mail es mas grande hay que verificar que termine en @gmail.com o @hotmail.com
            else
            {
                for (int i = usuario.mail.Length - 10; i < usuario.mail.Length; i++)
                    ultimaParte += usuario.mail.ElementAt(i);
                if (ultimaParte == "@gmail.com")
                    correcto = true;
                ultimaParte = "";
                for (int i = usuario.mail.Length - 12; i < usuario.mail.Length; i++)
                    ultimaParte += usuario.mail.ElementAt(i);
                if (ultimaParte == "@hotmail.com")
                    correcto = true;
                if (!correcto)
                    return false;
            }
            // buscamos si se repite el mail
            foreach (Usuario u in usuarios)
            {
                if (usuario.mail == u.mail)
                    return false;
            }
            us.Agregar(usuario);
            return true;
        }
        public List<Usuario> Lista()
        {
            return us.Lista();
        }
        public Boolean Modificar(Usuario usuario)
        {
            if (usuario.contra == null)
                return false;
            if (usuario.contra == "")
                return false;
            us.Modificar(usuario);
            return true;
        }
        public void Borrar(string mail)
        {
            us.Borrar(mail);
        }
        public Boolean Verificar_login(Usuario usuario)
        {
            if (usuario.mail == null || usuario.contra == null)
                return false;
            if (usuario.mail == "mauro@gmail.com" && usuario.contra == "123")
            {
                us.Datos_de_prueba();
                return true;
            }
            List<Usuario> usuarios = us.Lista();
            foreach (Usuario u in usuarios)
            {
                if (usuario.mail == u.mail && usuario.contra == u.contra)
                    return true;
            }
            return false;
        }
    }
}
