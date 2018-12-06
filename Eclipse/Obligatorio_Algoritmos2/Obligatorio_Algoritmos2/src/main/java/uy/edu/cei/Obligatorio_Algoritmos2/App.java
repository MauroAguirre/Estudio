package uy.edu.cei.Obligatorio_Algoritmos2;

import uy.edu.cei.Obligatorio_Algoritmos2.Dominio.ArbolB;

public class App 
{
    public static void main( String[] args )
    {
        ArbolB arbol = new ArbolB();
        arbol.insertar('c');
        arbol.insertar('a');
        arbol.insertar('d');
        System.out.println(arbol.puntaje());
    }
}
