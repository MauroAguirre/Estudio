package Algoritmo2;

import java.util.Scanner;

public class Practico1 {
	public static void main( String[] args )
    {
		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
        int matriz[][] = {{8,2,2},{2,8,2},{2,2,2}};
        int matriz2[][] = {{6,3},{7,5}};
        int[] numeros = {3,6,9};
        int[] numeros2 = {9,8,10};
        int[] numeros3 = {3,1};
        int[] numeros4 = {3};
        System.out.println(Ejercicio1(matriz));
        System.out.println(Ejercicio1(matriz2));
        if(Ejercicio2b(numeros,0)) {
        	System.out.println("Esta ordenado");
        }
        else {
        	System.out.println("No esta ordenado");
        }
        if(Ejercicio2b(numeros2,0)) {
        	System.out.println("Esta ordenado");
        }
        else {
        	System.out.println("No esta ordenado");
        }
        if(Ejercicio2b(numeros3,0)) {
        	System.out.println("Esta ordenado");
        }
        else {
        	System.out.println("No esta ordenado");
        }
        if(Ejercicio2b(numeros4,0)) {
        	System.out.println("Esta ordenado");
        }
        else {
        	System.out.println("No esta ordenado");
        }
        System.out.println();
        //System.out.println(Ejercicio3(numeros,0,numeros.length-1));
        
        /*
        List<Integer> lista=new ArrayList<>();
        lista.add(2);
        lista.add(3);
        //lista.indexOf(3) = 6;
        System.out.println();
        for(int i=0;i<lista.size();i++) {
        	System.out.println(lista.get(i));
        }*/
    }
	public static int Ejercicio1(int[][] matriz) {
		int suma=0;
		for(int i=0;i<matriz.length;i++) {
			suma+=matriz[i][i];
			suma+=matriz[i][matriz.length-1-i];
		}
		if(matriz.length%2!=0) {
			System.out.println(matriz[matriz.length/2][matriz.length/2]);
			suma-=matriz[matriz.length/2][matriz.length/2];
		}
		return suma;
	}
	public static boolean Ejercicio2b (int[] numeros,int lugar) {
		if(numeros.length-1==lugar) {
			return true;
		}
		else {
			if(numeros[lugar]<numeros[lugar+1]) {
				return Ejercicio2b(numeros,lugar+1);
			}
			else {
				return false;
			}
		}
	}
	public static int Ejercicio3 (int[] numeros,int comienzo,int ultima) {
		if(comienzo!=ultima) {
			int num=numeros[ultima/2];
			if(num<Ejercicio3(numeros,ultima/2,ultima)&&num<Ejercicio3(numeros,comienzo,ultima/2)) {
				return num;
			}
			else {
				if(Ejercicio3(numeros,ultima/2,ultima)<Ejercicio3(numeros,comienzo,ultima/2)) {
					return Ejercicio3(numeros,ultima/2,ultima);
				}
				else {
					return Ejercicio3(numeros,comienzo,ultima/2);
				}
			}
		}
		else {
			return numeros[comienzo];
		}
		
	}
}
