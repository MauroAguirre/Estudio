package Algoritmo2.Arboles.Principio;

public class NodoB {
	private String dato;
	private NodoB nodoizq;
	private NodoB nododer;
	public String getDato() {
		return dato;
	}
	public void setDato(String s) {
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
	public NodoB(String dato,NodoB nodoizq,NodoB nododer) {
		this.dato = dato;
		this.nodoizq = nodoizq;
		this.nododer = nododer;
	}
	public NodoB(String dato) {
		this.dato = dato;
		this.nodoizq = null;
		this.nododer = null;
	}
}
