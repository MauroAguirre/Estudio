package uy.edu.cei.Algoritmos2_Obligatorio;

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
        char[] letras1 = {'G','E','A','I','B','M','C','L','D','F','K','J','H'};//pre orden
        char[] letras2 = {'I','A','B','E','G','L','D','C','F','M','K','H','J'};//inorder
        ListaDE lista1 = new ListaDE(letras1);
        ListaDE lista2 = new ListaDE(letras2);
        lista1.mostrar();
        lista2.mostrar();
        ListaDE hasta = lista2.darHasta('G');
        ListaDE desde = lista2.darDesde('G');
        hasta.mostrar();
        desde.mostrar();
        
        System.out.println(lista1.buscarRaiz(hasta.darLetras()));
        
        ArbolB nuevo = new ArbolB();
        nuevo.ejercicio2B(lista1, lista2);
        nuevo.ejercicio2A(0);
        nuevo.mostrarPostOrden();
        //ListaDE opa = lista1.darMientrasSea(letra, inorden) 
        
        
        //arbol.ejercicio2B(lista1, lista2);
    }
}
