using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Eventos2017 eventos2017 = new Eventos2017();
            bool fin = false;
            do
            {
                Menu();
                switch (IngresarNumero(6))
                {
                    case 1:
                        eventos2017.AgregarAdministrador(IngresarAdministrador(eventos2017.DarAdministradores(), eventos2017.DarOrganizadores()));
                        break;
                    case 2:
                        eventos2017.AgregarOrganizador(IngresarOrganizador(eventos2017.DarAdministradores(), eventos2017.DarOrganizadores()));
                        break;
                    case 3:
                        MostrarUsuarios(eventos2017.DarAdministradores(), eventos2017.DarOrganizadores());
                        break;
                    case 4:
                        eventos2017.AgregarEvento(IngresarEvento(eventos2017.DarOrganizadores(),eventos2017.DarServicios()));
                        break;
                    case 5:
                        MostrarEventosDeOrganizador(eventos2017.DarOrganizadores());
                        break;
                    case 6:
                        fin = true;
                        break;
                }
                Console.Clear();
            } while (!fin);
        }
        //Muestra menu
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
        //Devuelve un numero menor al maximo que se lo pasamos como parametro
        static int IngresarNumero(int maximo)
        {
            int numero;
            string dato = Console.ReadLine();
            bool correcto = int.TryParse(dato, out numero);
            if (maximo == -1)
            {
                while (!correcto)
                {
                    Console.WriteLine("Error, ingrese de nuevo");
                    dato = Console.ReadLine();
                    correcto = int.TryParse(dato, out numero);
                }
            }
            else
            {
                while (!correcto || numero < 1 || numero > maximo)
                {
                    Console.WriteLine("Error, ingrese de nuevo");
                    dato = Console.ReadLine();
                    correcto = int.TryParse(dato, out numero);
                }
            }
            Console.Clear();
            return numero;
        }
        //Devuelve un numero mayor a 0 y menor a un maximo que se lo pasamos como parametro
        static int IngresarNumero2(int maximo)
        {
            int numero;
            string dato = Console.ReadLine();
            bool correcto = int.TryParse(dato, out numero);
            while (!correcto || numero < -1 || numero > maximo)
            {
                Console.WriteLine("Error, ingrese de nuevo");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out numero);
            }
            Console.Clear();
            return numero;
        }
        //Se ingresa un mail y se verifica si esta en la lista de organizadores, si esta devuleve su posicion o en el otro caso devulve -1 
        static int BuscarOrganizador(List<Organizador> Organizadores)
        {
            int ubicacion = -1;
            int contador = 0;
            Console.WriteLine("Ingrese el mail del organizador");
            string mail = Console.ReadLine();
            foreach (Organizador organizador in Organizadores)
            {
                if (organizador.Mail == mail)
                {
                    ubicacion = contador;
                }
                contador++;
            }
            return ubicacion;
        }
        //Hace una pregunta y devuelve true respondiendo si o false respondiendo no
        static bool Dicotomica(string texto)
        {
            string respuesta;
            bool primera = true;
            do
            {
                if (primera)
                {
                    Console.WriteLine(texto);
                    primera = false;
                }
                else
                    Console.WriteLine("Error, ingrese denuevo");
                respuesta = Console.ReadLine();
            } while (respuesta != "si" && respuesta != "SI" && respuesta != "no" && respuesta != "NO");
            if (respuesta == "si" || respuesta == "SI")
                return true;
            return false;
        }
        //Devuelve un dato tipo fecha valido
        public static DateTime IngresarFecha(string texto)
        {
            DateTime fecha;
            int mes = 2, dia, año = 2;
            string dato;
            bool primera = true;
            do
            {
                do
                {
                    do
                    {
                        if (primera)
                        {
                            Console.WriteLine(texto);
                            primera = false;
                        }
                        else
                            Console.WriteLine("Error, ingrese una fecha valida");
                        dato = Console.ReadLine();
                    } while (dato.Length != 10);
                } while (!int.TryParse(dato.Substring(0, 2), out dia) || !int.TryParse(dato.Substring(3, 2), out mes) || !int.TryParse(dato.Substring(6, 4), out año));
            } while (dia < 1 || dia > 30 || mes < 1 || mes > 12 || año < 1);
            return fecha = new DateTime(año, mes, dia);
        }
        //Devuelve un administrador luego de ingresar sus datos que no tenga un email anteriormente ingresado en la lista
        static Administrador IngresarAdministrador(List<Administrador> administradoresAnteriores, List<Organizador> organizadoresAnteriores)
        {
            Administrador nuevoAdministrador;
            bool correcto = false;
            string respuesta;
            string mail;
            string contraseña;
            do
            {
                Console.WriteLine("Ingrese su mail");
                mail = Console.ReadLine();
                while (!VerificarMail(mail, administradoresAnteriores, organizadoresAnteriores))
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
            return nuevoAdministrador = new Administrador(mail,contraseña);
        }
        //Devuelve un organizador luego de ingresar sus datos que no tenga un email anteriormente ingresado en la lista
        static Organizador IngresarOrganizador(List<Administrador> administradoresAnteriores, List<Organizador> organizadoresAnteriores)
        {
            Organizador nuevoOrganizador;
            bool correcto = false;
            string respuesta;
            string mail;
            string contraseña;
            string nombre;
            int telefono;
            string direccion;
            DateTime fecha;
            do
            {
                Console.WriteLine("Ingrese su mail");
                mail = Console.ReadLine();
                while (!VerificarMail(mail, administradoresAnteriores, organizadoresAnteriores))
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
                Console.WriteLine("Ingrese el nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el telefono");
                telefono = IngresarNumero(-1);
                Console.WriteLine("Ingrese la direccion");
                direccion = Console.ReadLine();
                fecha = IngresarFecha("Ingrese la fecha");
                Console.Clear();
                Console.WriteLine("Son estos los datos correctos:\nMail: " + mail + "\nContraseña: " + contraseña+"\nNombre: +"+nombre+"\nTelefono: "+telefono+"\nDireccion: "+direccion+"\nFecha: "+fecha.ToString());
                respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "SI")
                    correcto = true;
            } while (!correcto);
            return nuevoOrganizador = new Organizador(nombre, telefono, direccion, fecha, mail, contraseña);
        }
        //Devuelve un Evento y verifica que no haya otro con la misma fecha en la lista
        static Evento IngresarEvento(List<Organizador> organizadoresAnteriores, List<Servicio> servicios)
        {
            Evento evento;
            DateTime fecha;
            bool respuesta, fechaUsada = false,primera = true,premium;
            string cualEvento, cualTurno, descripcion, cliente;
            int aumento=0, personas= 0, duracion=0, maxAsistentes, asistentes, ubicacion = BuscarOrganizador(organizadoresAnteriores);
            while (ubicacion == -1)
            {
                respuesta = Dicotomica("No se encontro el mail, quiere volver a internar?");
                if (respuesta)
                    ubicacion = BuscarOrganizador(organizadoresAnteriores);
                else
                    return null;
            }
            Console.WriteLine(organizadoresAnteriores[ubicacion]);
            do
            {
                fechaUsada = false;
                if (!primera)
                    fecha = IngresarFecha("La fecha ya esta siendo usada, ingrese otra fecha para el evento");
                else
                {
                    fecha = IngresarFecha("Ingrese la fecha del evento");
                    primera = false;
                }  
                foreach (Organizador organizador in organizadoresAnteriores)
                {
                    if (organizador.HayEventoEnEstaFecha(fecha))
                    {
                        fechaUsada = true;
                        break;
                    }
                }
            } while (fechaUsada);
            Console.WriteLine("Ingresara el turno del evento (mañana, tarde o noche)?");
            cualTurno = Console.ReadLine();
            cualTurno = cualTurno.ToLower();
            while (cualTurno != "mañana" && cualTurno != "tarde" && cualTurno != "noche")
            {
                Console.WriteLine("Error, ingrese denuevo");
                cualTurno = Console.ReadLine();
                cualTurno = cualTurno.ToLower();
            }
            Console.WriteLine("Ingrese una descripcion");
            descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del cliente");
            cliente = Console.ReadLine();
            Console.WriteLine("Ingresara un evento tipo normal o premium?");
            cualEvento = Console.ReadLine();
            cualEvento = cualEvento.ToLower();
            Console.WriteLine("Ingrese las personas");
            personas = IngresarNumero(99999);
            while (cualEvento != "normal" && cualEvento != "premium")
            {
                Console.WriteLine("Error, ingrese denuevo");
                cualEvento = Console.ReadLine();
                cualEvento = cualEvento.ToLower();
            }
            if (cualEvento == "normal")
            {
                premium = false;
                maxAsistentes = 10;
                Console.WriteLine("Ingrese la duracion");
                duracion = IngresarNumero(9999);
            }
            else
            {
                premium = true;
                maxAsistentes = 100;
                Console.WriteLine("Ingrese el aumento");
                aumento = IngresarNumero(100);
            }
            Console.WriteLine("Ingrese la cantidad de asistentes");
            asistentes = IngresarNumero(maxAsistentes);
            List<ServiciosComprados> serviciosNuevos = IngresarServiciosElegidos(servicios, premium,personas);
            if (cualEvento == "normal")
            {
                evento = new Normal(cualTurno, duracion, fecha, descripcion, cliente, asistentes, personas, organizadoresAnteriores[ubicacion],serviciosNuevos);
                Console.WriteLine(evento);
                MostrarServiciosComprados(serviciosNuevos);
                Console.WriteLine("Costo total: " + evento.CostoTotal()+evento.Extra()+ "\n\nIngrese enter para continuar");//200 es el costo fijo por limpieza
                Console.ReadKey();
                return evento;
            }
            evento = new Premium(cualTurno, aumento, fecha, descripcion, cliente, asistentes, personas, organizadoresAnteriores[ubicacion], serviciosNuevos);
            Console.WriteLine(evento);
            MostrarServiciosComprados(serviciosNuevos);
            Console.WriteLine("Costo total: " + (evento.CostoTotal()+((evento.CostoTotal()/100)*aumento)) +"\n\nIngrese enter para continuar");
            Console.ReadKey();
            return evento;
        }
        //Devuelve una lista de serviciosComprados
        static List<ServiciosComprados> IngresarServiciosElegidos(List<Servicio> servicios, bool premium, int personas)
        {
            List<ServiciosComprados> serviciosElegidos = new List<ServiciosComprados>();
            bool[] serviciosAgregar = new bool[servicios.Count];
            int[] serviciosCantidad = new int[servicios.Count];
            int[] numeros = new int[2];
            bool[] correcto = new bool[2];
            string respuesta;
            bool chau = false;
            for (int i = 0; i < serviciosAgregar.Length; i++)
            {
                serviciosAgregar[i] = false;
            }
            do
            {
                MostrarServicios(servicios);
                Console.WriteLine("Ingrese el numero del servicio y la cantidad de gente que lo utilizara (2 30) o -1 para cancelar");
                respuesta = Console.ReadLine();
                for (int i = 0; i < respuesta.Length; i++)
                {
                    if (respuesta.Substring(i, 1) == " ")
                    {
                        correcto[0] = int.TryParse(respuesta.Substring(0, i), out numeros[0]);
                        correcto[1] = int.TryParse(respuesta.Substring(i+1, respuesta.Length-i-1), out numeros[1]);
                        break;
                    }
                }
                if (respuesta == "-1")
                    chau = true;
                else
                {
                    if (correcto[0] && correcto[1])
                    {
                        Console.WriteLine(numeros[0] + "    " + numeros[1]);
                        Console.ReadKey();
                        if (numeros[0] > 0 && numeros[0] < (servicios.Count + 1) && numeros[1] > 0 && numeros[1] <= personas)
                        {
                            ServiciosComprados nuevo = new ServiciosComprados(numeros[1], servicios[numeros[0] - 1]);
                            serviciosElegidos.Add(nuevo);
                            servicios.RemoveAt(numeros[0] - 1);
                        }
                        else 
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else
                        Console.WriteLine("Error");
                }
            } while (!chau);

            return serviciosElegidos;
        }
        //Devuelve true si el email es valido y no fue ingresado anteriormente, de lo contrario devuelve false
        static bool VerificarMail(string mail,List<Administrador> administradoresAnteriores,List<Organizador> organizadoresAnteriores)
        {
            bool iguales = false;
            bool primera = false;
            int ubicacionArroba;
            int arrobas=0;
            string final = ".com";
            foreach (Administrador administrador in administradoresAnteriores)
            {
                if (mail == administrador.Mail)
                    iguales = true;
            }
            foreach (Organizador organizador in organizadoresAnteriores)
            {
                if (mail == organizador.Mail)
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
        //Devuelve true si la contraseña es valida de lo contrario devuelve false
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
        //Muestra una lista de servicios por la consola
        static void MostrarServicios(List<Servicio> servicios)
        {
            int contador = 1;
            foreach (Servicio servicio in servicios)
            {
                Console.WriteLine(contador +" - "+ servicio);
                contador++;
            }
        }
        //Muestra una lista de serviciosComprados por la consola
        static void MostrarServiciosComprados(List<ServiciosComprados> servicios)
        {
            int contador = 1;
            foreach (ServiciosComprados servicio in servicios)
            {
                Console.WriteLine(contador + " - " + servicio);
                contador++;
            }
        }
        //Muestra una lista de administradores por la consola
        static void MostrarAdministradores(List<Administrador> administradores) 
        {
            Console.WriteLine("Los administradores son:\n");
            foreach (Administrador administrador in administradores) 
            {
                Console.WriteLine(administrador);
            }
            Console.WriteLine("");
        }
        //Muestra una lista de organizadores por la consola
        static void MostrarOrganizadores(List<Organizador> organizadores)
        {
            Console.WriteLine("Los organizadaores son:\n");
            foreach (Organizador organizador in organizadores)
            {
                Console.WriteLine(organizador);
            }
            Console.WriteLine("");
        }
        //Muestra una lista de usuarios o manda un mensaje si no hay organizadores ni administradores ingresados en la consola
        static void MostrarUsuarios(List<Administrador> administradores, List<Organizador> organizadores)
        {
            if (administradores.Count == 0 && organizadores.Count == 0)
                Console.WriteLine("No hay organizadores ni administradores ingresados");
            else
            {
                if (administradores.Count != 0)
                    MostrarAdministradores(administradores);
                if (organizadores.Count != 0)
                    MostrarOrganizadores(organizadores);
            }
            Console.WriteLine("Ingrese enter para continuar");
            Console.ReadKey();
        }
        //Muestra una evento de un organizador por la consola
        static void MostrarEventosDeOrganizador(List<Organizador> organizadores)
        {
            bool respuesta = true;
            int ubicacion = BuscarOrganizador(organizadores);
            while (ubicacion == -1)
            {
                respuesta = Dicotomica("No se encontro el mail, quiere volver a internar?");
                if (respuesta)
                    ubicacion = BuscarOrganizador(organizadores);
                else
                    ubicacion = 1;
            }
            if (ubicacion != -1 && respuesta)
            {
                foreach (Evento evento in organizadores[ubicacion].DarEventos())
                {
                    Console.WriteLine(evento);
                    if(evento.GetType() == typeof(Normal))
                        Console.WriteLine("El costo total es de: "+evento.CostoTotal()+evento.Extra());//el 300 es el costo de limpieza
                    else
                        Console.WriteLine("El costo total es de: " + (evento.CostoTotal() + ((evento.CostoTotal() / 100) * evento.Extra())));//como saco el aumento? proximamente en cines
                }
                Console.WriteLine("Ingrese enter para continuar");
                Console.ReadKey();
            }
        }
    }
}
