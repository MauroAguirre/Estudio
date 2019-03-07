package uy.edu.cei.Algoritmos2_Obligatorio.Dom‌inio.ListaDoblementeEncadenada;

public class ListaDE {
	public NodoDE comienzo;
	
	public NodoDE getComienzo() {
		return this.comienzo;
	}
	public void setComienzo(NodoDE nodo){
		this.comienzo = nodo;
	}
	
	public ListaDE() {
		this.comienzo = null;
	}
	public ListaDE(NodoDE comienzo) {
		this.comienzo = comienzo;
	}
	public ListaDE(char[] letras) {
		comienzo = new NodoDE(letras[0]);
		NodoDE nodo = this.comienzo;
		for(int i=1;i<letras.length;i++) {
			NodoDE nuevo = new NodoDE(letras[i]);
			nuevo.setNodoAnterior(nodo);
			nodo.setNodoSiguiente(nuevo);
			nodo = nuevo;
		}
	}
	public void agregar(char letra) {
		NodoDE nodo = this.comienzo;
		if(nodo==null)
			comienzo = new NodoDE(letra);
		else {
			while(nodo.getNodoSiguiente()!=null)
			{
				nodo = nodo.getNodoSiguiente();
			}
			NodoDE nuevo = new NodoDE(letra);
			nodo.setNodoSiguiente(nuevo);
			nuevo.setNodoAnterior(nodo);
		}
	}
	public void mostrar() {
		if(comienzo!=null) {
			System.out.print(comienzo.getDato()+" ");
			ListaDE nueva = new ListaDE(comienzo.getNodoSiguiente());
			nueva.mostrar();
		}
		else
			System.out.println();
	}
	public int tamanio() {
		int num = 0;
		NodoDE nodo = this.comienzo;
		while(nodo!=null) {
			nodo = nodo.getNodoSiguiente();
			num++;
		}
		return num;
	}
	public char[] darLetras() {
		char[] letras = new char[tamanio()];
		NodoDE nodo = this.comienzo;
		for(int i=0;i<tamanio();i++) {
			letras[i] = nodo.getDato();
			nodo = nodo.getNodoSiguiente();
		}
		return letras;
	}
	// para el inorden
	public ListaDE darHasta(char letra) {
		NodoDE nodo = this.comienzo;
		ListaDE nueva = new ListaDE();
		while(nodo!=null) {
			if(nodo.getDato()!=letra) {
				nueva.agregar(nodo.getDato());
				nodo = nodo.getNodoSiguiente();
			}
			else {
				break;
			}	
		}
		return nueva;
	}
	//para el inorden
	public ListaDE darDesde(char letra) {
		NodoDE nodo = this.comienzo;
		while(nodo!=null) {
			if(nodo.getDato()!=letra)
				nodo = nodo.getNodoSiguiente();
			else
				break;

		}
		return new ListaDE(nodo.getNodoSiguiente());
	}
	
	public char buscarRaiz(char[] letras) {
		NodoDE nodo = this.comienzo; //.getNodoSiguiente();
		while(nodo!=null) {
			for(int i=0;i<letras.length;i++) {
				if(nodo.getDato()==letras[i]) {
					return nodo.getDato();
				}
			}
			nodo=nodo.getNodoSiguiente();
		}
		return '0';
	}
	/*
	// para el preorden
	//rompe todo
	public ListaDE darMientrasSea(char letra,char[] inorden) {
		comienzo = comienzo.getNodoSiguiente();
		NodoDE nodo = this.comienzo;
		while(nodo!=null) {
			boolean es=false;
			for(int i=0;i<inorden.length;i++) {
				if(inorden[i]==nodo.getDato()) {
					es=true;
					break;
				}
			}
			if(es) {
				nodo=nodo.getNodoSiguiente();
			}
			else {
				nodo=nodo.getNodoAnterior();
				nodo.setNodoSiguiente(null);
				break;
			}
		}
		return new ListaDE(comienzo);
	}
	*/
}
