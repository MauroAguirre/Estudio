package Algoritmo2.Arboles.Binario;

import Algoritmo2.Arboles.Principio.NodoB;

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
	private NodoBB raiz;
	public NodoBB getRaiz() {
		return raiz;
	}
	public void setRaiz(NodoBB s) {
		raiz = s;
	}
	public ABB() {
		raiz=null;
	}
	public ABB(int num) {
		raiz = new NodoBB(num);
	}
	public void insertacion(int num) {
		if(raiz==null)
			raiz = new NodoBB(num);
		else
			insertacionRecursiva(null,raiz,num,true);
	}
	private void insertacionRecursiva(NodoBB aux,NodoBB nodo,int num,boolean derecha) {
		if(nodo==null) {
			nodo = new NodoBB(num);
			if(derecha)
				aux.setNododer(nodo);
			else
				aux.setNodoizq(nodo);
		}
		else {
			if(nodo.getDato()!=num) {
				if(num>nodo.getDato()) 
					insertacionRecursiva(nodo,nodo.getNododer(),num,true);
				else
					insertacionRecursiva(nodo,nodo.getNodoizq(),num,false);
			}
		}
	}
	public void borrarMinimo() {
		if(raiz!=null) {
			if(raiz.getNodoizq()==null)
				raiz=null;
			else
				borrarMinimoRec(raiz);
		}
	}
	private void borrarMinimoRec(NodoBB nodo) {
		if(nodo.getNodoizq().getNodoizq()==null)
			nodo.setNodoizq(null);
		else
			borrarMinimoRec(nodo.getNodoizq());
	}
	public void borrarMinimoPlus() {
		if(raiz!=null) {
			if(raiz.getNodoizq()==null) {
				if(raiz.getNododer()!=null)
					raiz=raiz.getNododer();
				else
					raiz=null;
			}
			else
				borrarMinimoPlusRec(raiz);
		}
	}
	private void borrarMinimoPlusRec(NodoBB nodo) {
		if(nodo.getNodoizq().getNodoizq()==null)
			if(nodo.getNododer()!=null)
				nodo.setNodoizq(nodo.getNododer());
			else
				nodo.setNodoizq(null);
		else
			borrarMinimoPlusRec(nodo.getNodoizq());
	}
	public void borrarElemento(int num) {
		if(raiz!=null) {
			if(raiz.getDato()==num)
				raiz=null;
			else
				borrarElementoRec(raiz,num);
		}
	}
	private void borrarElementoRec(NodoBB nodo,int num) {
		if(nodo!=null) {
			if(nodo.getNododer().getDato()==num)
				nodo.setNododer(null);
			else {
				if(nodo.getNodoizq().getDato()==num)
					nodo.setNodoizq(null);
				else {
					if(nodo.getDato()<num)
						borrarElementoRec(nodo.getNododer(),num);
					else
						borrarElementoRec(nodo.getNodoizq(),num);
				}
			}
		}
	}
	public boolean pertenece(int num) {
		if(raiz==null)
			return false;
		else {
			if(raiz.getDato()==num)
				return true;
			else {
				return perteneceRec(raiz.getNododer(),num)||perteneceRec(raiz.getNodoizq(),num);
			}
		}
	}
	private boolean perteneceRec(NodoBB nodo,int num) {
		if(nodo==null)
			return false;
		else {
			if(nodo.getDato()==num)
				return true;
			else {
				return perteneceRec(nodo.getNododer(),num)||perteneceRec(nodo.getNodoizq(),num);
			}
		}
	}
	public void listarAscendente() {
		if(raiz!=null)
			listarAscendenteRec(raiz);
	}
	private void listarAscendenteRec(NodoBB nodo) {
		if(nodo.getNodoizq()!=null&&nodo.getNododer()!=null) {
			listarAscendenteRec(nodo.getNodoizq());
			listarAscendenteRec(nodo.getNododer());
		}
		else {
			if(nodo.getNodoizq()!=null&&nodo.getNododer()==null) {
				listarAscendenteRec(nodo.getNodoizq());
			}
			else {
				if(nodo.getNodoizq()==null&&nodo.getNododer()!=null) {
					listarAscendenteRec(nodo.getNododer());
				}
				else {
					System.out.println(nodo.getDato());
				}
			}
		}
	}
	public void preOrden() {
		preOrdenRec(raiz);
	}
	private void preOrdenRec(NodoBB nodo) {
		if(nodo!=null) {
			System.out.println(nodo.getDato());
			if(nodo.getNododer()!=null&&nodo.getNodoizq()!=null) 
			{
				preOrdenRec(nodo.getNodoizq());
				preOrdenRec(nodo.getNododer());
			}
			else
			{
				if(nodo.getNodoizq()!=null&&nodo.getNododer()==null)
					preOrdenRec(nodo.getNodoizq());
				else
				{
					if(nodo.getNodoizq()==null&&nodo.getNododer()!=null)
						preOrdenRec(nodo.getNododer());
				}
			}
		}
	}
}
