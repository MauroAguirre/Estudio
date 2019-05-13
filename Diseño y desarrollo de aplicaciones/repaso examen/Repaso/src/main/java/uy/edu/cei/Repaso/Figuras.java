package uy.edu.cei.Repaso;

import java.util.Scanner;

public class Figuras {
	static Scanner entrada = new Scanner(System.in);
	public static void main(String[] args) {
		int opcion;
		do {
			float resultado = 0;
			System.out.println("1- Área triángulo\n");
			System.out.println("2- Área círculo\n");
			System.out.println("3- Área trapecio\n");
			System.out.println("0- Salir");
			opcion = entrada.nextInt();
			switch(opcion) {
				case 1:
					System.out.println("Ingrese la base");
					int base = entrada.nextInt();
					System.out.println("Ingrese la altura");
					int altura = entrada.nextInt();
					resultado = calcularAreaTriangulo(base, altura);
					System.out.println("El resultado es: "+resultado);
					break;
				case 2:
					System.out.println("Ingrese el radio");
					int radio = entrada.nextInt();
					resultado = calcularAreaCirculo(radio);
					System.out.println("El resultado es: "+resultado);
					break;
				case 3:
					int h = entrada.nextInt(); 
					int baseMayor = entrada.nextInt();
					int baseMenor = entrada.nextInt();
					resultado = calcularAreaTrapecio(h,baseMayor,baseMenor);
					System.out.println("El resultado es: "+resultado);
					break;
				default:
					System.out.println("Debe ingresar una opción dentro del rango dado");
			}
		}while(opcion == 0);
	}
	private static int calcularAreaTriangulo(int base, int altura) {
		return base * altura / 2;
	}
	private static float calcularAreaCirculo(int radio) {
		return (float) (radio * radio * 3.14);
	}
	private static float calcularAreaTrapecio(int h, int baseMayor, int baseMenor) {
		return h * (float)(( baseMayor + baseMenor) / 2);
	}
}
