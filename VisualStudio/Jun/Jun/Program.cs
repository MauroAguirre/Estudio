using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Jun
{
    class Program
    {
        static void Main(string[] args)
        {
            menuPrincipal();
        }

        public static void menuPrincipal()
        {
            bool correcto;
            string dato;
            string entrada;
            int opcion = 0;
            int chance = 1;
            do
            {
                if(chance == 1 )
                    Console.WriteLine("Bienvenido a VocalsMemoryGame, el juego de las vocales");
                Console.WriteLine("┏━━━━━━━━━━━━━━┓");
                Console.WriteLine("┃        Menu                ┃");
                Console.WriteLine("┃                            ┃");
                Console.WriteLine("┃ 1- Iniciar juego           ┃");
                Console.WriteLine("┃ 2- Ayuda                   ┃");
                Console.WriteLine("┃ 3- Creditos                ┃");
                Console.WriteLine("┃ 4- Salir                   ┃");
                Console.WriteLine("┗━━━━━━━━━━━━━━┛");
                dato = Console.ReadLine();
                correcto = int.TryParse(dato, out opcion);
                if (!correcto)
                    opcion = -2;
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        preJuego();
                        break;
                    case 2:
                        ayuda();
                        break;
                    case 3:
                        creditos();
                        break;
                    case 4:
                        break;
                    default:
                        switch (chance)
                        {
                            case 1:
                                Console.WriteLine("No ha ingresado una opcion correcta");
                                chance++;
                                break;
                            case 2:
                                Console.WriteLine("Error, ingrese denuevo");
                                chance++;
                                break;
                            case 3:
                                Console.WriteLine("Por favor ingrese una opcion correcta");
                                chance++;
                                break;
                            case 4:
                                Console.WriteLine("Señor, le pido que ingrese una de las opciones disponibles");
                                chance++;
                                break;
                            case 5:
                                Console.WriteLine(CreadorDePutiadasVersionFantasticDeluxe());
                                break;
                        }
                        break;
                }
            } while (opcion != 4);

        }


        public static void preJuego()
        {
            bool primera = true;
            bool correcto;
            int cantidadJugadores;
            string dato;
            bool confirmarLong = false;
            bool confirmarJugadores = false;
            List<string> jugadores = new List<string>();

            Console.WriteLine("Asi que quieres comenzar una partida... \n Comencemos!!!");

            do
            {
                do
                {
                    if (primera)
                    {
                        Console.WriteLine("Segundo ingrese la cantidad de jugadores (entre 1 y 5) y sus nombres:");
                        primera = false;
                    }
                    else
                        Console.WriteLine("Pero sos pelotudo!\nTe dije un numero entre 1 y 5\nNo es tan complicado bolas tristes");
                    dato = Console.ReadLine();
                    correcto = int.TryParse(dato, out cantidadJugadores);
                } while(!correcto);

                if (cantidadJugadores < 6)
                {
                    for (int i = 0; i < cantidadJugadores; i++)
                    {
                        Console.WriteLine("\nJugador " + (i + 1) + " selecciona tu nombre: ");
                        jugadores.Add(Console.ReadLine());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Los jugadores son:");
                    for (int i = 0; i < cantidadJugadores; i++)
                    {
                        Console.WriteLine("Jugador " + (i + 1) + ": " + jugadores[i]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("ｿEmpezamos?");
                    Console.ReadKey();
                    Console.WriteLine("");
                    confirmarJugadores = true;
                }
                else
                {
                    Console.WriteLine("El juego soporta de 1 a 5 jugadores \n");
                }
            } while (confirmarJugadores == false);
            jugar(jugadores);

        }

        public static void jugar(List<string> jugadores)
        {
            int demora, tiempo, posActual, opcion, jugadorActual, comenzar = 0;
            String vocalesJuntas, vocalesElegidas;
            char vocal;

            bool continuar = false;
            int[] puntaje;
            puntaje = new int[jugadores.Count];
            demora = 1500;

            //comienza el juego

            for (jugadorActual = 0; jugadorActual < jugadores.Count; jugadorActual++)
            {
                Console.Clear();
                vocalesJuntas = "";
                Console.WriteLine("Comienza el jugador " + jugadores[jugadorActual]);
                Thread.Sleep(600);
                Console.Clear();
                Console.WriteLine("Prontos!");
                Thread.Sleep(600);
                Console.Clear();
                Console.WriteLine("Listos!");
                Thread.Sleep(600);
                Console.Clear();
                Console.WriteLine("YA!!!");
                Thread.Sleep(300);
                Console.Clear();

                for (posActual = 0; posActual < 6; posActual++)
                {

                    do
                    {

                        vocal = HacerVocal();
                        vocalesJuntas = vocalesJuntas + vocal;
                        Console.WriteLine(vocalesJuntas);

                        Thread.Sleep(600);
                        Console.Clear();
                        Console.WriteLine("ｿCuales son las vocales?");

                        vocalesElegidas = Console.ReadLine();


                        if (vocalesElegidas.Length == vocalesJuntas.Length)
                        {
                            vocalesElegidas = vocalesElegidas.ToUpper();
                            if (vocalesElegidas == vocalesJuntas)
                            {
                                puntaje[jugadorActual] += 10;

                            }
                            else
                            {
                                Console.WriteLine("UF! Cometiste un error... Probemos de nuevo!");
                                puntaje[jugadorActual] -= 10;
                                vocalesJuntas = vocalesJuntas.Substring(0, vocalesJuntas.Length - 1);

                            }
                        }
                        else
                        {
                            Console.WriteLine("UF! Nisiquiera has puesto la misma cantidad... Probemos de nuevo!");
                            puntaje[jugadorActual] -= 15;
                            vocalesJuntas = vocalesJuntas.Substring(0, vocalesJuntas.Length - 1);

                        }

                        Thread.Sleep(600);
                        Console.Clear();

                    } while (vocalesElegidas != vocalesJuntas);
                    if (posActual < 5)
                    {
                        Console.WriteLine("BIEN!!!... SIGAMOS!");
                    }
                    else
                    {
                        if (jugadorActual < jugadores.Count - 1)
                        {
                            Console.WriteLine("BIEN!!! Le toca al siguiente jugador");
                            Thread.Sleep(400);
                        }
                    }
                    Thread.Sleep(400);
                    Console.Clear();

                }
            }
            //Aca comienza la parte post-juego
            Console.WriteLine(" \n Los puntajes son: ");
            int masMejor = 0;
            for (int i = 0; i < jugadores.Count; i++)
            {
                if (i == 0)
                    masMejor = i;
                else
                {
                    if (puntaje[i] > puntaje[masMejor])
                        masMejor = i;
                }
                Console.WriteLine("  " + jugadores[i] + " a conseguido " + puntaje[i] + " puntos!!!");
            }

            Console.WriteLine("\n El ganador es: "+jugadores[masMejor]);
            Console.ReadKey();

            //Final del juego
            do
            {
                Console.WriteLine("Ingrese: \n 1- para comenzar un nuevo juego \n 2- Para volver al menu");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        continuar = true;
                        preJuego();
                        break;
                    case 2:
                        Console.Clear();
                        continuar = true;
                        break;
                    default:
                        Console.WriteLine("Ha ingresado una opcion incorrecta, volvamos a intentar");
                        break;
                }
            } while (continuar == false);

        }


        public static char HacerVocal()
        {
            char vocal = '0';
            Random numRand = new Random();
            int opcion = numRand.Next(1, 6);
            switch (opcion)
            {
                case 1:
                    vocal = 'A';
                    break;
                case 2:
                    vocal = 'E';
                    break;
                case 3:
                    vocal = 'I';
                    break;
                case 4:
                    vocal = 'O';
                    break;
                case 5:
                    vocal = 'U';
                    break;
            }
            return vocal;
        }



        public static void jugarMulti(int longDeJuego)
        {

        }

        public static void ayuda()
        {

        }


        public static void creditos()
        {
            Console.Clear();
            Console.WriteLine("\n VocalsMemoryGame, EL JUEGO DE LAS VOCALES \n Creado por: \n  AREA 51: \n   Santiago Freitas \n   Jun Yamaki \n   Hugo Ferreira \n \n Ingrese cualquier tecla para volver al menu:");
            Console.ReadKey();
            Console.WriteLine("\n \n");

        }

        public static string CreadorDePutiadasVersionFantasticDeluxe()
        {
            string putiada = "";
            Random numRand = new Random();
            int opcion = numRand.Next(1, 14);
            switch (opcion)
            {
                case 1:
                    putiada = "Del 1 al 4 mongolico no es tan dificil";
                    break;
                case 2:
                    putiada = "Sos banana o te haces? 1 al 4";
                    break;
                case 3:
                    putiada = "Loco por favor del 1 al 4";
                    break;
                case 4:
                    putiada = "Que pedaso de anormal que sos, 1 al 4";
                    break;
                case 5:
                    putiada = "1 al 4 Loco";
                    break;
                case 6:
                    putiada = "Me estas jodiendo del 1 al 4";
                    break;
                case 7:
                    putiada = "Tamos todos locos del 1 al 4";
                    break;
                case 8:
                    putiada = "1 al 4 vejiga alegre";
                    break;
                case 9:
                    putiada = "1 al 4 bolas tristes";
                    break;
                case 10:
                    putiada = "Pero la gran 7 loco del 1 al 4";
                    break;
                case 11:
                    putiada = "Dios mio sos ciego del 1 al 4";
                    break;
                case 12:
                    putiada = "1 al 4..............1 al maldito 4";
                    break;
                case 13:
                    putiada = "La gran teta chabon 1 al 4";
                    break;
            }
            return putiada;
        }

    }
}
