package uy.edu.cei.Repaso_Algoritmo.Lista;

public class ListaS {
	private NodoL inicio;
	
	public ListaS() {
		this.inicio = null;
	}
	public void snoc(int x) {
		NodoL nodo = inicio;
		if(inicio == null)
			inicio = new NodoL(x);
		else {
			while(nodo.getNodoSig()!=null) {
				nodo = nodo.getNodoSig();
			}
			nodo.setNodoSig(new NodoL(x));
		}
	}
	public int largo() {
		NodoL nodo = inicio;
		int largo=0;
		while(nodo!=null) {
			nodo = nodo.getNodoSig();
			largo++;
		}
		return largo;
	}
	public void borrar(int x) {
		NodoL nodo = inicio;
		if(nodo!=null) {
			if(nodo.getDato()==x) {
				inicio = nodo.getNodoSig();
			}
			else {
				while(nodo.getNodoSig()!=null) {
					if(nodo.getNodoSig().getDato()==x) {
						nodo.setNodoSig(nodo.getNodoSig().getNodoSig());
						break;
					}
					else {
						nodo = nodo.getNodoSig();
					}
				}
			}
		}
	}
	public boolean pertenece(int x) {
		NodoL nodo = inicio;
		while(nodo!=null) {
			if(nodo.getDato()==x)
				return true;
			else
				nodo = nodo.getNodoSig();
		}
		return false;
	}
	public void mostrar() {
		NodoL nodo = inicio;
		while(nodo!=null) {
			System.out.println(nodo.getDato());
			nodo = nodo.getNodoSig();
		}
		System.out.println("Termina lista");
	}
	public void ingresarComienzo(int x) {
		NodoL nodo = new NodoL(x);
		nodo.setNodoSig(inicio);
		inicio = nodo;
	}
	public ListaS invertir() {
		ListaS nueva = new ListaS();
		NodoL nodo = inicio;
		while(nodo!=null) {
			nueva.ingresarComienzo(nodo.getDato());
			nodo = nodo.getNodoSig();
		}
		return nueva;
	}
	public boolean estaOrdenada() {
		if(this.largo()>1) {
			NodoL nodo = inicio;
			while(nodo.getNodoSig()!=null) {
				//acendente
				if(nodo.getDato()>nodo.getNodoSig().getDato())
					return false;
				else
					nodo = nodo.getNodoSig();
			}
		}
		return true;
	}
	
}
