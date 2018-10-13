package Algoritmo2.Listas;

public class NodoDoble {
	private int dato;
	private NodoDoble anterior;
	private NodoDoble siguiente;
	
	public void SetDato(int dato) {
		this.dato = dato;
	}
	public int GetDato() {
		return this.dato;
	}
	public void SetSiguiente(NodoDoble nodo) {
		this.siguiente = nodo;
	}
	public NodoDoble GetSiguiente() {
		return this.siguiente;
	}
	public void SetAnterior(NodoDoble nodo) {
		this.anterior = nodo;
	}
	public NodoDoble GetAnterior() {
		return this.anterior;
	}
	
	public NodoDoble(int n) {
		dato = n;
		anterior = null;
		siguiente = null;
	}
}
