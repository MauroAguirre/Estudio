package uy.edu.cei.Obligatorio_Algoritmos2.Dominio;

public class NodoB {
	private char dato;
	private NodoB nodoDer;
	private NodoB nodoIzq;
	
	public void setDato(char dato) {
		this.dato = dato;
	}
	public void setNodoDer(NodoB nodo) {
		this.nodoDer = nodo;
	}
	public void setNodoIzq(NodoB nodo) {
		this.nodoIzq = nodo;
	}
	public char getDato() {
		return this.dato;
	}
	public NodoB getNodoDer() {
		return this.nodoDer;
	}
	public NodoB getNodoIzq() {
		return this.nodoIzq;
	}
	
	public NodoB(char dato) {
		this.dato = dato;
		this.nodoDer = null;
		this.nodoIzq = null;
	}
}
