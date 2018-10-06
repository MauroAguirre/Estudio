package uy.edu.cei.singleton.threadsafe;
import java.util.Scanner; 
/**
 * Hello world!
 *
 */
public class App {
	public static void main(String[] args) throws InterruptedException {
		Scanner e = new Scanner (System.in);
		String respuesta;
		CreaLineas c = new CreaLineas(1000l);
		c.start();
		//Singleton single1 = Singleton.GetInstancia();
		//Singleton single2 = Singleton.GetInstancia();
		SingletonCaller sing1 = new SingletonCaller(1000L,"pedro");
		SingletonCaller sing2 = new SingletonCaller(100L,"raul");
		//System.out.println(single1.Dame3());
		//System.out.println(single1);
		//System.out.println(single2);
		System.out.println();
		sing1.start();
		System.out.println();
		sing2.start();
		System.out.println();
		System.out.println("Ingresame algo");
		respuesta = e.nextLine();
		System.out.println(respuesta);
	}
	
}
