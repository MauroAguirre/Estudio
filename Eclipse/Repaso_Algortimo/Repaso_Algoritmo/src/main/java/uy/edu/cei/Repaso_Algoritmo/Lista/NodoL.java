package uy.edu.cei.Repaso_Algoritmo.Lista;

public class NodoL {
	private int dato;
	private NodoL nodoSig;
	
	public void setDato(int dato) {
		this.dato = dato;
	}
	public int getDato() {
		return this.dato;
	}
	public void setNodoSig(NodoL nodo) {
		this.nodoSig = nodo;
	}
	public NodoL getNodoSig() {
		return this.nodoSig;
	}
	public NodoL(int dato) {
		this.dato = dato;
	}
}
