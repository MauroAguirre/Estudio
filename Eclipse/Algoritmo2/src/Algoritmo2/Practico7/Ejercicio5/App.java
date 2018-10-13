package Algoritmo2.Practico7.Ejercicio5;

import java.util.LinkedList;
import java.util.List;

import Algoritmo2.Pilas_Colas.Queue;

public class App {
	public static void main(String[] args) {
		Queue pasajeros = new Queue();
		Queue pasajerosEspera = new Queue();
		for(int i=0;i<21;i++)
			System.out.println(adquirirPaisaje(pasajeros,pasajerosEspera,"sadsad"));
	}
	public static String adquirirPaisaje(Queue pasajeros,Queue pasajerosEspera,String pasajero) {
		if(!pasajeros.enQueue(pasajero)) {
			if(!pasajerosEspera.enQueue(pasajero))
				return "No se pueden poner mas pasajeros en espera";
			else
				return "El pasajero esta en espera";
		}
		return "Pasajero ingresado";
	}
	public static void cancelarPasaje(Queue pasajerosQueue, Queue pasajerosEspera) {
		
	}
}
