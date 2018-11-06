import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Penal {

	public static void main(String[] args) {
		//se crear el scanner para ingresar cosas por consola
		Scanner sc = new Scanner(System.in);
		//se crear op para guardar la respuesta del usuario por consola
		String op;
		//esta variable marca de que turno es el jugador. 1 es el jugador 1 y 2 es el jugador 2
		int jugadorActivo;
		//esta variable es para guardar el tiro por donde vamos jugando
		int tiro;
		//esta variable marca que jugador gano. si es 0 no ha ganado nadie, si es 1 gana jugador 1 y si es 2 gana jugador 2
		int ganador;
		//este arreglo guarda los nombres de los jugadores
		String[] jugadores = new String[2];
		//este arreglo guarda los puntos de los jugadores
		int[] puntos = new int[2];
		//esta variable guarda el resultado de un partido
		String resultado;
		//esta lista guarda los resultados de las partidas de jugador contra maquina
		List<String> PVE = new ArrayList<String>();
		//esta lista guarda los resultados de las partidas de jugador contra jugador
		List<String> PVP = new ArrayList<String>();
		do {
			//inicializamos las variables, puntos en cero, ganador ninguno, primer tiro, jugador activo jugador 1
			puntos[0]= 0;
			puntos[1]= 0;
			ganador = 0;
			tiro=1;
			jugadorActivo = 1;
			Menu();
			op = sc.next();
			//entramos en el menu y segun lo que ingrese el usuario por consola vamos a un lugar
			switch(op) {
				case "1":
					//aca jugamos jugador contra maquina
					System.out.println("Eliga el nombre del jugador 1");
					//se ingresa el nombre del jugador 1 por consola y se graba en la variable
					jugadores[0] = sc.next();
					//se graba en la variable el nombre de IA para el jugador 2
					jugadores[1] = "IA";
					do {
						//se anuncia el tiro y se muestra el arco
						System.out.println("Tiro "+tiro);
						Arco();
						//segun el jugador es que se hace
						if(jugadorActivo==1) {
							//dice que jugador tira penal y se ingresa por consola
							System.out.println("Tire el penal jugador "+jugadores[0]);
							op = sc.next();
							puntos[0] += Arbitro(op);
							//termina el turno del jugador 1 y pasa al del jugador 2
							jugadorActivo=2;
							
						}
						else {
							//dice que jugador 1 tiene que atajar y se ingresa por consola
							System.out.println("Tire el penal jugador "+jugadores[1] + ", elige donde atajar");
							op = sc.next();
							puntos[1] += ArbitroIa(op);
							//termina el turno del jugador 2 y pasa al del jugador 1
							jugadorActivo=1;
							//al jugador los dos jugadores pasa el turno
							tiro++;
							//aca se verifica si gano un jugador segun el tiro (turno)
							switch(tiro) {
							case 4:
								//si un jugador metio 3 y el otro 0 gana ese jugador
								if(puntos[0] == 3 && puntos[1]==0)
									ganador=1;
								if(puntos[0] == 0 && puntos[1]==3)
									ganador=2;
								break;
							case 5:
								//si un jugador tiene una diferencia de mas de 2 goles gana ese jugador
								if(puntos[0] > puntos[1]+1)
									ganador=1;
								if(puntos[1] > puntos[0]+1)
									ganador=2;
							case 6:
								//si un jugador al final tiene mas puntos que el otro gana.
								if(puntos[0] > puntos[1])
									ganador=1;
								if(puntos[1] > puntos[0])
									ganador=2;
							}
						}
					//siguen pasando los turnos mientras ningun jugador gane o no haya llegado al turno 6
					}while(tiro !=6 && ganador == 0);
					//si nadie a ganado entramos en el gol de horo
					if(ganador==0)
						System.out.println("Entramos al gol de oro");
					//en caso que terminen en empate entramos en gol de oro
					//el gol de oro es parecido a los turnos anteriores pero hay que ganar con una diferencia de dos goles
					while(ganador==0) {
						System.out.println("Tiro "+tiro);
						Arco();
						if(jugadorActivo==1) {
							System.out.println("Tire el penal jugador "+jugadores[0]);
							op = sc.next();
							puntos[0] += Arbitro(op);
							jugadorActivo=2;
							
						}
						else {
							System.out.println("Tire el penal jugador "+jugadores[1] + ", elige donde atajar");
							op = sc.next();
							puntos[1] += ArbitroIa(op);
							jugadorActivo=1;
							tiro++;
							if(puntos[0] > puntos[1]+1)
								ganador=1;
							if(puntos[1] > puntos[0]+1)
								ganador=2;
						}
					}
					if(ganador==1)
						System.out.println("Gana el jugador "+jugadores[0]);
					else
						System.out.println("Gana el jugador "+jugadores[1]);
					resultado = jugadores[0] + " "+puntos[0]+" vs "+jugadores[1] + " "+puntos[1];
					System.out.println(resultado);
					PVE.add(resultado);
					break;
				case "2":
					//parecido al jugador contra maquina pero en este caso los dos jugadores tiran y se resuelve si se atajo automaticamente
					//Ingresamos el nombre de los jugadores
					System.out.println("Eliga el nombre del jugador 1");
					jugadores[0] = sc.next();
					System.out.println("Eliga el nombre del jugador 2");
					jugadores[1] = sc.next();
					//los 5 tiros primeros
					do {
						System.out.println("Tiro "+tiro);
						Arco();
						if(jugadorActivo==1) {
							System.out.println("Tire el penal jugador "+jugadores[0]);
							op = sc.next();
							puntos[0] += Arbitro(op);
							jugadorActivo=2;
							
						}
						else {
							System.out.println("Tire el penal jugador "+jugadores[1]);
							op = sc.next();
							puntos[1] += Arbitro(op);
							jugadorActivo=1;
							tiro++;
							switch(tiro) {
							case 4:
								if(puntos[0] == 3 && puntos[1]==0)
									ganador=1;
								if(puntos[0] == 0 && puntos[1]==3)
									ganador=2;
								break;
							case 5:
								if(puntos[0] > puntos[1]+1)
									ganador=1;
								if(puntos[1] > puntos[0]+1)
									ganador=2;
							case 6:
								if(puntos[0] > puntos[1])
									ganador=1;
								if(puntos[1] > puntos[0])
									ganador=2;
							}
						}					
					}while(tiro !=6 && ganador == 0);
					if(ganador==0)
						System.out.println("Entramos al gol de oro");
					//en caso que terminen en empate entramos en gol de oro
					while(ganador==0) {
						System.out.println("Tiro "+tiro);
						Arco();
						if(jugadorActivo==1) {
							System.out.println("Tire el penal jugador "+jugadores[0]);
							op = sc.next();
							puntos[0] += Arbitro(op);
							jugadorActivo=2;
							
						}
						else {
							System.out.println("Tire el penal jugador "+jugadores[1]);
							op = sc.next();
							puntos[1] += Arbitro(op);
							jugadorActivo=1;
							tiro++;
							if(puntos[0] > puntos[1]+1)
								ganador=1;
							if(puntos[1] > puntos[0]+1)
								ganador=2;
						}
					}
					if(ganador==1)
						System.out.println("Gana el jugador "+jugadores[0]);
					else
						System.out.println("Gana el jugador "+jugadores[1]);
					resultado = jugadores[0] + " "+puntos[0]+" vs "+jugadores[1] + " "+puntos[1];
					System.out.println(resultado);
					PVP.add(resultado);
					break;
				case "3":
					//se muestra por pantalla el historial de partidas jugador contra maquina
					System.out.println("Historial de PVE"+"\n");
					for(int i=0;i<PVE.size();i++) {
						System.out.println(PVE.get(i));
					}
					break;
				case "4":
					//se muestra por pantalla el historial de partidas jugador contra jugador
					System.out.println("Historial de PVP"+"\n");
					for(int i=0;i<PVP.size();i++) {
						System.out.println(PVP.get(i));
					}
					break;
				case "5":
					//dice chau por pantalla y termina el programa
					System.out.println("Chau");
					break;
				default:
					//si no se ingresa los datos bien se manda un mensaje de error y se pide el dato nuevamente
					System.out.println("Error, ingrese denuevo");
			}
		}while(op!="5");
		
	}
	//esta es la funcion para mostrar el menu por pantalla
	public static void Menu() {
		System.out.println("Menu");
		System.out.println("");
		System.out.println("1-Un jugador");
		System.out.println("2-Dos jugadores");
		System.out.println("3-Historial PVE");
		System.out.println("4-Historial PVP");
		System.out.println("5-Salir");
	}
	//esta es la funcion para mostrar el arco por pantalla
	public static void Arco() {
		System.out.println("                                                                                                                     ");
		System.out.println("                         ╔════════════════════════════════════════════════════════════════╗                          ");
		System.out.println("                         ║  ╦══════════════════════════════════════════════════════════╗  ║                          ");
		System.out.println("                         ║  ║                              ***                         ║  ║                          ");
		System.out.println("                         ║  ║                                *                         ║  ║                          ");
		System.out.println("                         ║  ║                              ***                         ║  ║                          ");
		System.out.println("                         ║  ║                              *                           ║  ║                          ");
		System.out.println("                         ║  ║                              ***                         ║  ║                          ");
		System.out.println("                         ║  ║                                                          ║  ║                          ");
		System.out.println("                         ║  ║                                                          ║  ║                          ");
		System.out.println("                         ║  ║                              ***                         ║  ║                          ");
		System.out.println("                         ║  ║                             *****                        ║  ║                          ");
		System.out.println("                         ║  ║                               *                          ║  ║                          ");
		System.out.println("                         ║  ║                             █████                        ║  ║                          ");
		System.out.println("─────────────────────────║  ║                             * █ *                        ║  ║──────────────────────────");
		System.out.println("                         ║  ║                            *  █  *                       ║  ║                          ");
		System.out.println("                         ║  ║                           *   █   *                      ║  ║                          ");
		System.out.println("                         ║  ║                          *    █    *                     ║  ║                          ");
		System.out.println("                         ║  ║                               █                          ║  ║                          ");
		System.out.println("                         ║  ║      *                       * *                  ***    ║  ║                          ");
		System.out.println("                         ║  ║     **                      *   *                   *    ║  ║                          ");
		System.out.println("─────────────────────────║  ║    * *                     *     *                ***    ║  ║──────────────────────────");
		System.out.println("                         ║  ║      *                    *       *                 *    ║  ║                          ");
		System.out.println("─────────────────────────║  ║      *                   *         *              ***    ║  ║──────────────────────────");
	}
	//esta funcion recibe un parametro que es el tiro del jugador y devuelve el puntaje que recibe el jugador
	public static int Arbitro(String eleccion) {
		//si ingresa 1 o 2 o 3 significa que disparo al arco y se puede verificar si metio gol
		if(eleccion.equals("3")  || eleccion.equals("2") || eleccion.equals("1")) {
			//creamos un numero random que vendria a ser donde el arquero se tiro a atajar
			int arquero = (int) ((Math.random() * 3) + 1);
			//si el lugar donde atajo el arquero y donde tiramos no es igual metemos gol y ganamos un punto
			if( arquero!= Integer.parseInt(eleccion)) {
				System.out.println("Gol");
				return 1;
			}
			//si es igual significa que atajo y no ganamos puntos esta ronda
			else {
				System.out.println("Atajada");
				return 0;
			}
		//si no ingreso bien los numeros damos como que le erro al arco y no recibe puntos
		}else {
			System.out.println("La tiraste a la mierda");
			return 0;
		}
	}
	//esta funcion recibe un parametro que es donde nos tiramos a atajar y devulve el puntaje que recibe la compu
	public static int ArbitroIa(String eleccion) {
		//si ingresa 1 o 2 o 3 significa que intentaste atajar y es puede intenar parar la pelota
		if(eleccion.equals("3")  || eleccion.equals("2") || eleccion.equals("1")) {
			//creamos un numero random que es donde tiraria la compu
			int arquero = (int) ((Math.random() * 3) + 1);
			//si la compu tira en lugar diferente de donde atajamos gana un punto
			if( arquero!= Integer.parseInt(eleccion)) {
				System.out.println("Gol");
				return 1;
			}
			//si la compu tira en el lugar donde atajamos no recibe puntos
			else {
				System.out.println("Atajada");
				return 0;
			}
		//si no ingreso bien los numeros el arquero se tropiesa y siempre mete la compu
		}else {
			System.out.println("Se tropeso el arquero");
			return 1;
		}
	}
}
