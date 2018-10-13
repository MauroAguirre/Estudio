package Algoritmo2.Listas;

import java.util.Scanner;

public class App {
	public static void main( String[] args )
    {
		Scanner sc = new Scanner(System.in);
		System.out.println("Menu");
		System.out.println("");
		System.out.println("1-Lista");
		System.out.println("2-Lista doble");
		switch(sc.next()) {
			case "1":
				System.out.println("Vamos");
				Lista listita = new Lista();
				listita.InsertarInicio(4);
				listita.InsertarInicio(8);
				listita.InsertarInicio(14);
				listita.InsertarInicio(18);
				listita.MostrarTodo();
				/*
				System.out.println(listita.Largo());
				System.out.println(listita.LargoRecursivo(listita.DarNodoInicio()));
				listita.BorrarRecursiva(67,null,listita.DarNodoInicio());
				listita.MostrarTodo();
				System.out.println(listita.Largo());
				System.out.println(listita.LargoRecursivo(listita.DarNodoInicio()));
				listita.BorrarRecursiva(7,null,listita.DarNodoInicio());
				listita.MostrarTodo();
				System.out.println(listita.Largo());
				System.out.println(listita.LargoRecursivo(listita.DarNodoInicio()));
				listita.BorrarRecursiva(77,null,listita.DarNodoInicio());
				listita.MostrarTodo();
				System.out.println(listita.Largo());
				System.out.println(listita.LargoRecursivo(listita.DarNodoInicio()));
				listita.BorrarRecursiva(23,null,listita.DarNodoInicio());
				listita.MostrarTodo();
				System.out.println(listita.Largo());
				System.out.println(listita.LargoRecursivo(listita.DarNodoInicio()));
				listita.BorrarRecursiva(11,null,listita.DarNodoInicio());
				listita.MostrarTodo();
				System.out.println(listita.Largo());
				System.out.println(listita.LargoRecursivo(listita.DarNodoInicio()));
				listita.MostrarTodo();
				listita.SnocRecursivo(77, listita.DarNodoInicio());
				listita.MostrarTodo();
				listita.SnocRecursivo(77, listita.DarNodoInicio());
				listita.MostrarTodo();
				listita.SnocRecursivo(42, listita.DarNodoInicio());
				listita.MostrarTodo();
				Lista invertida = listita.Invertir();
				invertida.MostrarTodo();
				if(listita.EstaOrdenada())
					System.out.println("Esta ordenada");
				else
					System.out.println("No esta ordenada");
				if(invertida.EstaOrdenada())
					System.out.println("Esta ordenada");
				else
					System.out.println("No esta ordenada");
				*/
				listita.InsordD(18);
				listita.MostrarTodo();
				System.out.println(listita.Cuenta(4));
				System.out.println(listita.Cuenta(0));
				System.out.println(listita.Cuenta(18));
				System.out.println(listita.Maximo());
				Lista listita2 = new Lista();
				listita2.InsertarInicio(40);
				listita2.InsertarInicio(20);
				listita2.InsertarInicio(10);
				listita2.InsertarInicio(5);
				listita2.MostrarTodo();
				listita2.InsordA(23);
				listita2.MostrarTodo();
				System.out.println(listita2.Maximo());
				System.out.println(listita2.Promedio());
				System.out.println(listita2.Tomar_n(3));
				listita2 = listita2.Cambiar(10, 44);
				Lista l1 = new Lista();
				l1.InsertarInicio(1);
				l1.InsertarInicio(6);
				l1.InsertarInicio(6);
				Lista l2 = new Lista();
				l2.InsertarInicio(1);
				l2.InsertarInicio(8);
				l2.InsertarInicio(12);
				l2.InsertarInicio(15);
				l1.MostrarTodo();
				l2.MostrarTodo();
				/*
				if(Lista.Iguales(l1, l2))
					System.out.println("Son iguales");
				else
					System.out.println("Son diferentes");
				*/
				//Lista l3 = Lista.Intercalar(l1, l2,new Lista());
				//l3.MostrarTodo();
				Lista l4 = Lista.Concatenar(l1, l2, new Lista());
				l4.MostrarTodo();
				break;
			case "2":
				ListaDoble ld1 = new ListaDoble();
				ld1.InsOrdA(ld1, 42);
				ld1.MostrarNodos();
				System.out.println();
				ld1.InsOrdA(ld1, 44);
				System.out.println();
				ld1.MostrarNodos();
				ld1.InsOrdA(ld1, 88);
				System.out.println();
				ld1.MostrarNodos();
				ld1.InsOrdA(ld1, 12);
				System.out.println();
				ld1.MostrarNodos();
				break;
			default:
				System.out.println("Escribe bien chabon");
		}
		
    }
}
