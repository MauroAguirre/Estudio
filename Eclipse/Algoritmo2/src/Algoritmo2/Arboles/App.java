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
	 * 
	 * preorden enorden( izquierda derecha) posorden (izquierda derecha raiz)
	 * 
	 * Recorrido preorden
	 * 
	 * Existen varias formas de recorrer un arbol listando los nodos del mismo, generando una lista de nodos. Dado un nodo
	 * n con hojas n1,n2.... el listado preorden del nodo se puede definir: preorde(n) = (n,preorde(n1),preorden(n1),...preorden(n))
	 * 
	 * Arbol binario equilibrado
	 * 
	 * Es un AB en el que todos sus nodos se cumple la siguiente propiedad:
	 * altura(subIzquierdo) - altura(subDerecho) | <= 1
	 * 
	 * el valor absoluto de la resta entre las alturas de sus subarboles izquierdo y subarboles derecho es menor o igual a 1
	 * 
	 * Arbol binario completo
	 * 
	 * Es un arbol en que todos los nodos tienen dos hijos y todas las hojas estan en el mismo nivel
	 * 
	 * Arbol binario de busqueda (ABB)
	 * 
	 * =>Es un arbol binario ordenado (sus elementos son ordenados)
	 * Esta organizado de tal forma que para cada nodo, todos los elementos menores se ubican en el subarbol izquierdo y los elementos
	 * mayores a el en el subarbol derecho.
	 */
	public static void main(String[] args) {
		String res;
		ArbolB arbolito = new ArbolB();
		System.out.println("nodos: "+arbolito.cantNodos(arbolito.getRaiz()));
		System.out.println("peso: "+arbolito.peso());
		System.out.println("altura: "+arbolito.altura(arbolito.getRaiz()));		
		res = (arbolito.todosPares(arbolito.getRaiz()))?"Son todos pares":"No son todos pares";
		System.out.println(res);
		System.out.println("hojas: "+arbolito.cantHojas(arbolito.getRaiz())+"\n");
		
		arbolito.agregarIzq( "2");
		System.out.println("nodos: "+arbolito.cantNodos(arbolito.getRaiz()));
		System.out.println("peso: "+arbolito.peso());
		System.out.println("altura: "+arbolito.altura(arbolito.getRaiz()));
		res = (arbolito.todosPares(arbolito.getRaiz()))?"Son todos pares":"No son todos pares";
		System.out.println(res);
		System.out.println("hojas: "+arbolito.cantHojas(arbolito.getRaiz())+"\n");
		
		arbolito.agregarIzq("4");
		arbolito.agregarIzq("40");
		System.out.println("nodos: "+arbolito.cantNodos(arbolito.getRaiz()));
		System.out.println("peso: "+arbolito.peso());
		System.out.println("altura: "+arbolito.altura(arbolito.getRaiz()));
		res = (arbolito.todosPares(arbolito.getRaiz()))?"Son todos pares":"No son todos pares";
		System.out.println(res);
		System.out.println("hojas: "+arbolito.cantHojas(arbolito.getRaiz())+"\n");
		
		arbolito.agregarIzq("6");
		arbolito.agregarDer("8");
		System.out.println("nodos: "+arbolito.cantNodos(arbolito.getRaiz()));
		System.out.println("peso: "+arbolito.peso());
		System.out.println("altura: "+arbolito.altura(arbolito.getRaiz()));
		res = (arbolito.todosPares(arbolito.getRaiz()))?"Son todos pares":"No son todos pares";
		System.out.println(res);
		System.out.println("hojas: "+arbolito.cantHojas(arbolito.getRaiz())+"\n");
		
		arbolito.agregarDer("9");
		System.out.println("nodos: "+arbolito.cantNodos(arbolito.getRaiz()));
		System.out.println("peso: "+arbolito.peso());
		System.out.println("altura: "+arbolito.altura(arbolito.getRaiz()));
		res = (arbolito.todosPares(arbolito.getRaiz()))?"Son todos pares":"No son todos pares";
		System.out.println(res);
		System.out.println("hojas: "+arbolito.cantHojas(arbolito.getRaiz())+"\n");
	}

}
