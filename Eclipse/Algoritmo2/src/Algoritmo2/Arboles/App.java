package Algoritmo2.Arboles;

public class App {
	/*
	 * Un arbol es una estructura de datos dinamea en la que cada elemento pueden
	 * tener varios elementos posteriores, pero tan solo puede tener un unico elemento
	 * anterior
	 * 
	 * Un arbol permite organizar un conjunto de objetos de forma jerarquica
	 * 
	 * Necesitamos tener una relacion de orden establecida por ej
	 * -de menor a mayor
	 * -alfabetico
	 * 
	 * Estructuradamente un arbol es una coleccion de nodos
	 * 
	 * La coleccion de nodos puede ser vacia (arbol vacio)
	 * 
	 * Si el arbol no es vacio: Existe una relacion de parentesco por la cual cada
	 * nodo tiene uno y solo un padre (prodecesor), salvo la raiz que no lo tiene
	 * 
	 * siendo la raiz el primer nodo
	 * 
	 * =>NodoRaiz: no tiene padre, el primer.
	 * =>NodoHoja: np toeme ñigar, el ultimo.
	 * =>NodoInterior: tiene hijos y padre, el del medio.
	 * =>NodoPadre: nodo que contiene un puntero al nodo actual.
	 * =>NodoHijo: nodos a los que apunta el nodo actual.
	 * =>Hermano: deseendientes de un mismo padre.
	 * 
	 * Potencial: es el numero potencial de hijos que puede tener 
	 * cada elemento el arbol.
	 * 
	 * Nivel: distancia a la raiz medida en nodos.
	 * 
	 * Rama o camino: Es una secuencia de nodos, en el que dos nodos consecutivos
	 * cualquiera son padre e hijos.
	 * 
	 * Altura: es el maximo nivel mas 1.
	 * 
	 * Peso: Es el numero de nodos del arol sin contar la raiz.
	 * 
	 */
	public static void main(String[] args) {
		ArbolB arbolito = new ArbolB();
		System.out.println("nodos: "+arbolito.cantNodos(arbolito.getRaiz()));
		System.out.println("peso: "+arbolito.peso());
		System.out.println("hojas: "+arbolito.cantHojas(arbolito.getRaiz())+"\n");
		arbolito.agregarIzq( "dsad");
		System.out.println("nodos: "+arbolito.cantNodos(arbolito.getRaiz()));
		System.out.println("peso: "+arbolito.peso());
		System.out.println("hojas: "+arbolito.cantHojas(arbolito.getRaiz())+"\n");
		
		arbolito.agregarIzq( "222");
		arbolito.agregarIzq( "hgf65");
		System.out.println("nodos: "+arbolito.cantNodos(arbolito.getRaiz()));
		System.out.println("peso: "+arbolito.peso());
		System.out.println("hojas: "+arbolito.cantHojas(arbolito.getRaiz())+"\n");
		arbolito.agregarIzq( "bgbgb");
		arbolito.agregarDer("cvf");
		System.out.println("nodos: "+arbolito.cantNodos(arbolito.getRaiz()));
		System.out.println("peso: "+arbolito.peso());
		System.out.println("hojas: "+arbolito.cantHojas(arbolito.getRaiz())+"\n");
	}

}
