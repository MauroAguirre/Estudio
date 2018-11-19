package uy.edu.cei.Obligatorio_Algoritmos2.Dominio;

public class NodoT {
	private char dato;
	private NodoT nodoDer;
	private NodoT nodoIzq;
	public void setNodoDer(NodoT nodo) {
		this.nodoDer = nodo;
	}
	public NodoT getNodoDer() {
		return this.nodoDer;
	}
	public void setNodoIzq(NodoT nodo) {
		this.nodoIzq = nodo;
	}
	public NodoT getNodoIzq() {
		return this.nodoIzq;
	}
	public void setDato(char dato) {
		this.dato = dato;
	}
	public char getDato() {
		return this.dato;
	}
	public NodoT(char dato) {
		nodoDer = null;
		nodoIzq = null;
		this.dato = dato;
	}
}
