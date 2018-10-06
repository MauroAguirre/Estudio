using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Eventos2017 eventos2017 = new Eventos2017();
            bool fin = false;
            Console.Beep(659, 70);
            Console.Beep(659, 70);
            Console.Beep(698, 70);
            Console.Beep(783, 70);
            Console.Beep(783, 70);
            Console.Beep(698, 70);
            Console.Beep(659, 70);
            Console.Beep(587, 70);
            do
            {
                Menu();
                switch (IngresarNumero(6))
                {
                    case 1:
                        eventos2017.AgregarUsuario(IngresarUsuario(eventos2017.DarUsuarios()));
                        break;
                    case 2:
                        break;
                    case 3:
                        eventos2017.MostrarUsuarios();
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        fin = true;
                        break;
                }
                Console.Clear();
            } while (!fin);
        }
        static void Menu()
        {
            Console.WriteLine("         Eventos\n");
            Console.WriteLine("1-Registro de administrador");
            Console.WriteLine("2-Registro de organizador");
            Console.WriteLine("3-Lista de usuarios");
            Console.WriteLine("4-Registro de eventos");
            Console.WriteLine("5-Lista de eventos de un organizador");
            Console.WriteLine("6-Fin");
        }
        static int IngresarNumero(int maximo)
        {
            int numero;
            string dato = Console.ReadLine();
            bool correcto = int.TryParse(dato, out numero);
            while (!correcto || numero<1 || numero>maximo)
            {
                Console.WriteLine("Error, ingrese de nuevo");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out numero);
            }
            Console.Clear();
            return numero;
        }
        static Usuario IngresarUsuario(List<Usuario> usuariosAnteriores)
        {
            Usuario nuevoUsuario;
            bool correcto = false;
            string respuesta;
            string mail;
            string contraseña;
            do
            {
                Console.WriteLine("Ingrese su mail");
                mail = Console.ReadLine();
                while (!VerificarMail(mail,usuariosAnteriores))
                {
                    Console.WriteLine("Error, ingrese de nuevo");
                    mail = Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("Ingrese su contraseña");
                contraseña = Console.ReadLine();
                while (!VerificarContraseña(contraseña))
                {
                    Console.WriteLine("Error, ingrese de nuevo");
                    contraseña = Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("Son estos los datos correctos:\nMail: " + mail + "\nContraseña: " + contraseña);
                respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "SI")
                    correcto = true;
            } while (!correcto);
            return nuevoUsuario = new Usuario(mail,contraseña);
        }
        static bool VerificarMail(string mail,List<Usuario> usuariosAnteriores)
        {
            bool iguales = false;
            bool primera = false;
            int ubicacionArroba;
            int arrobas=0;
            string final = ".com";
            foreach (Usuario losUsuarios in usuariosAnteriores)
            {
                if (mail == losUsuarios.Mail)
                    iguales = true;
            }
            for (int i = 0; i < mail.Length; i++)
            {
                if (mail.Substring(i, 1) == "@")
                    arrobas++;
                if (!primera && mail.Substring(i, 1) == "@")
                {
                    primera = true;
                    ubicacionArroba = i;
                }
            }
            if (arrobas != 1 || final != mail.Substring(mail.Length-4) || iguales)
            {
                return false;
            }
            return true;
        }
        static bool VerificarContraseña(string contraseña)
        {
            bool tiene = false; ;
            for (int i = 0; i < contraseña.Length; i++)
            {
                if (contraseña.Substring(i, 1) == "!" || contraseña.Substring(i, 1) == "," || contraseña.Substring(i, 1) == "." || contraseña.Substring(i, 1) == ";")
                    tiene = true;
            }
            if (contraseña.Length > 8 || contraseña == contraseña.ToLower() || !tiene)
                return false;
            return true;
        }
        static Organizador IngresarOrganizador()
        {
            Organizador nuevoOrganizador;
            string nuevoNombre ="ds";
            int nuevoTelefono =233;
            string nuevaDireccion ="dsa";
            DateTime nuevaFecha = new DateTime();
            string nuevoMail ="dsa";
            string nuevaContraseña ="dsa";
            return nuevoOrganizador = new Organizador(nuevoNombre,nuevoTelefono,nuevaDireccion,nuevaFecha,nuevoMail,nuevaContraseña);
        }
    }
}
