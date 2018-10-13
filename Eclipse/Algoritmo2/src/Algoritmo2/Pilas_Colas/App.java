package Algoritmo2.Pilas_Colas;

public class App {
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
		
		Queue queue2 = new Queue();
		Queue queue = new Queue();
		queue.enQueue("23");
		queue.enQueue("44");
		queue.enQueue("77");
		queue.enQueue("44");
		queue.enQueue("33");
		queue.enQueue("22");
		queue.enQueue("7217");
		queue.enQueue("424");
		queue.enQueue("717");
		queue.enQueue("99");
		queue.enQueue("99999");
		queue.Mostrar();
		System.out.println(queue.back());
		System.out.println(queue2.back());
		queue.deQueue();
		queue.Mostrar();
		
		
    }
}
