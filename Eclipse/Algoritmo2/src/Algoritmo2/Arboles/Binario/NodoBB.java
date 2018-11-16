package Algoritmo2.Arboles.Binario;

import Algoritmo2.Arboles.Principio.NodoB;

public class NodoBB {
	private int dato;
	private NodoBB nodoizq;
	private NodoBB nododer;
	public int getDato() {
		return dato;
	}
	public void setDato(int d) {
		dato = d;
	}
	public NodoBB getNodoizq() {
		return nodoizq;
	}
	public void setNodoizq(NodoBB n) {
		this.nodoizq = n;
	}
	public NodoBB getNododer() {
		return nododer;
	}
	public void setNododer(NodoBB n) {
		this.nododer = n;
	}
	public NodoBB(int dato,NodoBB nodoizq,NodoBB nododer) {
		this.dato = dato;
		this.nodoizq = nodoizq;
		this.nododer = nododer;
	}
	public NodoBB(int dato) {
		this.dato = dato;
		this.nodoizq = null;
		this.nododer = null;
	}
}
