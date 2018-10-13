package Algoritmo2.Listas;

public class NodoLista {
	private int dato;
	private NodoLista siguiente;
	
	public NodoLista GetNodoLista (){
	     return siguiente;
	}
	public void SetNodoLista (NodoLista n){
	    this.siguiente = n;
	}
	public int GetNodoDato (){
	     return dato;
	}
	public void SetNodoDato (int n){
	    this.dato = n;
	}
	
	public NodoLista(int n) {
		this.dato = n;
		this.siguiente = null;
	}
}
