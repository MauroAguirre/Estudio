package Algoritmo2;

public class Stack_Pilas_Main {
	public static void main( String[] args )
    {
		//Stack
		//Las pilas son listas con la restriccion que las inserciones y eliminaciones deben
		//realizarse solamente en una posicion la cima de la pila 
		//(final de la lista)
		//solo el elemento top es accesible
		
		//las operaciones fundamentales de una pila son
		//push: insertar un elemento(la pila no esta llena)
		//Pop: eliminar el ultimo elemento (la pila no esta vacia)
		//Top: retorna el ultimo elemento insertado (la pila no esta vacia)
		
		//Lifo
		//las pilas son conocidas tambien como lifo (LAST IN FIRST OUT)
		//Se puede implementar de dos formas
		//Lista enlazadas
		//Array
		Stack stack = new Stack();
		Stack stack2 = new Stack();
		stack.push("23");
		stack.push("24");
		stack.push("25");
		stack.push("33");
		stack2.push("25");
		stack2.push("33");
		
    }
}
