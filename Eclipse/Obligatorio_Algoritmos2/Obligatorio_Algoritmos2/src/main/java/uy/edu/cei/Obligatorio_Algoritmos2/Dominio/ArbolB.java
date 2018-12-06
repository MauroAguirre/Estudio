package uy.edu.cei.Obligatorio_Algoritmos2.Dominio;

public class ArbolB {
	private NodoB raiz;
	public void setRaiz(NodoB nodo) {
		this.raiz = nodo;
	}
	public ArbolB() {
		this.raiz = null;
	}
	public ArbolB(NodoB nodo) {
		this.raiz = nodo;
	}
	public void insertar(char dato) {
		if(raiz==null)
			raiz = new NodoB(dato);
		else {
			ArbolB a;
			if(raiz.getDato()<dato) {
				if(this.raiz.getNodoDer()==null) {
					NodoB nuevo = new NodoB(dato);
					raiz.setNodoDer(nuevo);
				}
				else {
					a = new ArbolB(this.raiz.getNodoDer());
					a.insertar(dato);
				}
			}
			else {
				if(this.raiz.getNodoIzq()==null) {
					NodoB nuevo = new NodoB(dato);
					raiz.setNodoIzq(nuevo);
				}
				else {
					a = new ArbolB(this.raiz.getNodoIzq());
					a.insertar(dato);
				}
			}
		}
	}
	public int puntaje() {
		if(raiz==null) {
			return 0;
		}
		else {
			ArbolB a = new ArbolB(raiz.getNodoDer());
			ArbolB b = new ArbolB(raiz.getNodoIzq());
			switch(raiz.getDato()) {
				case 'a':
					return 1+a.puntaje()+b.puntaje();
				case 'b':
					return 2+a.puntaje()+b.puntaje();
				case 'c':
					return 3+a.puntaje()+b.puntaje();
				case 'd':
					return 4+a.puntaje()+b.puntaje();
				case 'e':
					return 5+a.puntaje()+b.puntaje();
				case 'f':
					return 6+a.puntaje()+b.puntaje();
				case 'g':
					return 7+a.puntaje()+b.puntaje();
				default:
					return 0;
			}
		}
	}
}
