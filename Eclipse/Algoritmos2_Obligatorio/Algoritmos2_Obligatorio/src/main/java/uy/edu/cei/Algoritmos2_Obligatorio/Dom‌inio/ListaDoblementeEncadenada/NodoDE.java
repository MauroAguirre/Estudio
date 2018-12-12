package uy.edu.cei.Algoritmos2_Obligatorio.Dom‌inio.ListaDoblementeEncadenada;

public class NodoDE {
	private char dato;
	private NodoDE nodoAnterior;
	private NodoDE nodoSiguiente;
	
	public char getDato() {
		return this.dato;
	}
	public NodoDE getNodoAnterior() {
		return this.nodoAnterior;
	}
	public NodoDE getNodoSiguiente() {
		return this.nodoSiguiente;
	}
	public void setDato(char dato) {
		this.dato = dato;
	}
	public void setNodoSiguiente(NodoDE nodo) {
		this.nodoSiguiente = nodo;
	}
	public void setNodoAnterior(NodoDE nodo) {
		this.nodoAnterior = nodo;
	}
	public NodoDE(char dato) {
		this.dato = dato;
		this.nodoAnterior = null;
		this.nodoSiguiente = null;	
	}
}
