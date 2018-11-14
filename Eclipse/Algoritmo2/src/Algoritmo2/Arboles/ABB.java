package Algoritmo2.Arboles;

public class ABB {
	/*
	 * Los arboles binarios de busqueda
	 * Si un arbol esta organizado de forma tal que para cada nodo ni, todas las claves en el subarbol
	 * izquierdo ni, son menos que la clave de ni, y todas las claves en el subarbol derecho de un ni son
	 * mayores que la clave de ni, entonces este arbol es un ABB
	 * 
	 * *Los valores en los nodos de un nodo ABB pueden ser numeros,caracteres o estructuras complejas
	 * *Lo importante es que haya un orden total definido sobre un conjunto de los valores
	 * *Los ABB son una subarbol muy importante de los AB ya que permiten al ordenamiento y busquedad
	 * de datos en forma simple y eficiente
	 * 
	 * La especificacion del ABB es muy similar a la de AB.
	 * La diferencia mas importante es que los constructores ABizq y ABder no deberian ser visibles,
	 * ya que su uso podria permitir crear arboles desordenados
	 * 
	 * Para construir ABBs se necesita una nueva operacion insercion
	 * 
	 * La insercion es similar a la busqueda, puede implementarse tanto iterativo como recursiva
	 * 
	 * Si el arbol vacio se crea un nuevo nodo y se inserta en la estructura si no esta vacio,
	 * se comprueba si el elemento dado es menor que la raiz del arbol inicial con que se inserta en el subarbol
	 * izquierdo y si es mayor se inserta en ek subarbol derecho. de esta forma las inserciones se hacen en las hojas
	 * 
	 * Minimo: debido al orden impuesto sobre los elementos de un ABB no vacio el menor de ellos es aquel que estar
	 * almacenado en el nodo mas a la izquierda del mismo
	 * Maximo: en forma similar podemos definir un procedimiento para localizar el maximo elemento de un ABB
	 * 
	 */
	private int dato;
	private NodoB nodoizq;
	private NodoB nododer;
	public int getDato() {
		return dato;
	}
	public void setDato(int s) {
		dato = s;
	}
	public NodoB getNodoizq() {
		return nodoizq;
	}
	public void setNodoizq(NodoB n) {
		this.nodoizq = n;
	}
	public NodoB getNododer() {
		return nododer;
	}
	public void setNododer(NodoB n) {
		this.nododer = n;
	}
	public ABB(int numerin) {
		dato = numerin;
		nodoizq = null;
		nododer = null;
	}
	public void insertacion(int num) {
		
	}
}
