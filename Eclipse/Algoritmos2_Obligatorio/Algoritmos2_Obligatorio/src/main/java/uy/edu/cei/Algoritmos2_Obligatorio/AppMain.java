package uy.edu.cei.Algoritmos2_Obligatorio;

import uy.edu.cei.Algoritmos2_Obligatorio.Dom‌inio.ArbolB;
import uy.edu.cei.Algoritmos2_Obligatorio.Dom‌inio.NodoB;

/**
 * Hello world!
 *
 */
public class AppMain 
{
    public static void main( String[] args )
    {
    	ArbolB arbol = new ArbolB();
    	NodoB a = new NodoB('f');//6
    	NodoB b = new NodoB('d');//4
    	NodoB c = new NodoB('g');//7
    	NodoB d = new NodoB('b');//2
    	NodoB e = new NodoB('+',a,b);//6+4=10
    	NodoB f = new NodoB('-',c,d);//7-2=5
    	NodoB g = new NodoB('/',e,f);//10/5=2
    	arbol.setRaiz(g);
        System.out.println(arbol.ejercicio1());
        arbol.ejercicio2A(0);
        if(arbol.ejercicio3(new char[] {'/','-','g'}, 0))
        	System.out.println("Pertenece el camino");
        else
        	System.out.println("No pertenece el camino");
    }
}
