package uy.edu.cei.Algoritmos2_Obligatorio.Main;

import java.util.Scanner;

import uy.edu.cei.Algoritmos2_Obligatorio.Dom‌inio.ArbolBinario.ArbolB;
import uy.edu.cei.Algoritmos2_Obligatorio.Dom‌inio.ArbolBinario.NodoB;
import uy.edu.cei.Algoritmos2_Obligatorio.Dom‌inio.ListaDoblementeEncadenada.ListaDE;

/**
 * Hello world!
 *
 */
public class AppMain 
{
    public static void main( String[] args )
    {
    	Scanner sc = new Scanner(System.in);
    	//variables
    	//para el ejercicio1
    	ArbolB arbol = new ArbolB();
    	NodoB a = new NodoB('f');//6
    	NodoB b = new NodoB('d');//4
    	NodoB c = new NodoB('g');//7
    	NodoB d = new NodoB('b');//2
    	NodoB e = new NodoB('+',a,b);//6+4=10
    	NodoB f = new NodoB('-',c,d);//7-2=5
    	NodoB g = new NodoB('/',e,f);//10/5=2
    	arbol.setRaiz(g);
    	//para ejercicio2
    	char[] letras1 = {'G','E','A','I','B','M','C','L','D','F','K','J','H'};//pre orden
        char[] letras2 = {'I','A','B','E','G','L','D','C','F','M','K','H','J'};//inorder
        ListaDE lista1 = new ListaDE(letras1);
        ListaDE lista2 = new ListaDE(letras2);
        ArbolB nuevo = new ArbolB();
        nuevo.ejercicio2B(lista1, lista2);
    	//para el ejercicio3
    	ArbolB arbol2 = new ArbolB();
    	NodoB nod1 = new NodoB('l');
    	NodoB nod2 = new NodoB('t');
    	NodoB nod3 = new NodoB('x');
    	NodoB nod4 = new NodoB('e');
    	NodoB nod5 = new NodoB('g',nod1,nod2);
    	NodoB nod6 = new NodoB('h',nod3,nod4);
    	NodoB nod7 = new NodoB('v',nod5,nod6);
    	arbol2.setRaiz(nod7);
    	char[] camino1 = {'v','g','l'};
    	char[] camino2 = {'v','t','l'};
    	char[] camino3 = {'g','l'};
    	char[] camino4 = {'v','h'};
    	//
    	System.out.println("Ingrese el ejercicio que quiere verificar");
    	System.out.println("");
    	System.out.println("1 - Ejercicio 1");
    	System.out.println("2 - Ejercicio 2");
    	System.out.println("3 - Ejercicio 3");
    	switch(sc.next()) {
    		case "1":
    			System.out.println("El arbol binario es:");
    			arbol.ejercicio2A(0);
    			System.out.println("El puntaje del arbol es: "+arbol.ejercicio1());
    			break;
    		case "2":
    			System.out.println("El primer arreglo es de preorden: GEAIBMCLDFKJH");
    			System.out.println("El segundo arreglo es de inorden: IABEGLDCFMKHJ");
    			System.out.println("El arbol creado fue: ");
    			nuevo.ejercicio2A(0);
    			System.out.println("El arbol mostrado en postorden es:");
    			nuevo.mostrarPostOrden();
    			break;
    		case "3":
    			System.out.println("El arbol binario es:");
    			arbol2.ejercicio2A(0);
    			System.out.println("El camino v g l: ");
    			if(arbol2.ejercicio3(camino1,0))
    	        	System.out.println("Pertenece ");
    	        else
    	        	System.out.println("No pertenece");
    			System.out.println("El camino v t l: ");
    			if(arbol2.ejercicio3(camino2,0))
    	        	System.out.println("Pertenece ");
    	        else
    	        	System.out.println("No pertenece");
    			System.out.println("El camino g l: ");
    			if(arbol2.ejercicio3(camino3,0))
    	        	System.out.println("Pertenece ");
    	        else
    	        	System.out.println("No pertenece");
    			System.out.println("El camino v h: ");
    			if(arbol2.ejercicio3(camino4,0))
    	        	System.out.println("Pertenece ");
    	        else
    	        	System.out.println("No pertenece");
    			break;
    		default:
    			System.out.println("Error con los datos");
    	}
    }
}
