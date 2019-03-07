package uy.edu.cei.Algoritmos2_Obligatorio.Dom‌inio.ArbolBinario;

import uy.edu.cei.Algoritmos2_Obligatorio.Dom‌inio.ListaDoblementeEncadenada.ListaDE;
import uy.edu.cei.Algoritmos2_Obligatorio.Dom‌inio.ListaDoblementeEncadenada.NodoDE;

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
				case 'h':
					return 8+a.puntaje()+b.puntaje();
				case 'i':
					return 9+a.puntaje()+b.puntaje();
				case 'j':
					return 10+a.puntaje()+b.puntaje();
				case 'k':
					return 11+a.puntaje()+b.puntaje();
				case 'l':
					return 12+a.puntaje()+b.puntaje();
				case 'm':
					return 13+a.puntaje()+b.puntaje();
				case 'n':
					return 14+a.puntaje()+b.puntaje();
				case 'o':
					return 15+a.puntaje()+b.puntaje();
				case 'p':
					return 16+a.puntaje()+b.puntaje();
				case 'q':
					return 17+a.puntaje()+b.puntaje();
				case 'r':
					return 18+a.puntaje()+b.puntaje();
				case 's':
					return 19+a.puntaje()+b.puntaje();
				case 't':
					return 20+a.puntaje()+b.puntaje();
				case 'u':
					return 21+a.puntaje()+b.puntaje();
				case 'v':
					return 22+a.puntaje()+b.puntaje();
				case 'w':
					return 23+a.puntaje()+b.puntaje();
				case 'x':
					return 24+a.puntaje()+b.puntaje();
				case 'y':
					return 25+a.puntaje()+b.puntaje();
				case 'z':
					return 26+a.puntaje()+b.puntaje();
				default:
					return 0;
			}
		}
	}
	public int charPuntos(char dato) {
		switch(dato) {
		case 'a':
			return 1;
		case 'b':
			return 2;
		case 'c':
			return 3;
		case 'd':
			return 4;
		case 'e':
			return 5;
		case 'f':
			return 6;
		case 'g':
			return 7;
		case 'h':
			return 8;
		case 'i':
			return 9;
		case 'j':
			return 10;
		case 'k':
			return 11;
		case 'l':
			return 12;
		case 'm':
			return 13;
		case 'n':
			return 14;
		case 'o':
			return 15;
		case 'p':
			return 16;
		case 'q':
			return 17;
		case 'r':
			return 18;
		case 's':
			return 19;
		case 't':
			return 20;
		case 'u':
			return 21;
		case 'v':
			return 22;
		case 'w':
			return 23;
		case 'x':
			return 24;
		case 'y':
			return 25;
		case 'z':
			return 26;
		default:
			return 0;
	}
	}
	public int ejercicio1() {
		if(raiz==null)
			return 0;
		else {
			if(raiz.getNodoDer()==null&&raiz.getNodoIzq()==null)
				return charPuntos(raiz.getDato());
			else {
				ArbolB b = new ArbolB(raiz.getNodoDer());
				ArbolB a = new ArbolB(raiz.getNodoIzq());
				switch(raiz.getDato()) {
					case '+':
						return a.ejercicio1()+b.ejercicio1();
					case '-':
						return a.ejercicio1()-b.ejercicio1();
					case '/':
						return a.ejercicio1()/b.ejercicio1();
					case '*':
						return a.ejercicio1()*b.ejercicio1();
					default :
						return 0;
				}
			}
		}
	}
	public int altura() {
        int alt = -1;
        if (this.raiz != null) {
            if (raiz.getNodoIzq()==null&&raiz.getNodoDer()==null) {
                alt = 0;
            } 
            else {
            	ArbolB a = new ArbolB(raiz.getNodoDer());
    			ArbolB b = new ArbolB(raiz.getNodoIzq());
    			alt = 1 + Math.max(a.altura(), b.altura());
            }
        }
        return alt;
    }
	public void ejercicio2A(int num) {
		if(num!=altura()+1) {
			imprimirLinea(num,altura()-num);
			System.out.println();
			ejercicio2A(num+1);
		}
	}
	private void imprimirLinea(int num,int espacios) {
		if(num!=0) {
			if(raiz!=null) {
				ArbolB a = new ArbolB(raiz.getNodoDer());
				ArbolB b = new ArbolB(raiz.getNodoIzq());
				b.imprimirLinea(num-1,espacios);
				a.imprimirLinea(num-1,espacios);
			}
		}
		else {
			if(raiz!=null) {
				for(int i=0;i<espacios;i++) {
					System.out.print(" ");
				}
				System.out.print(raiz.getDato()+" ");
			}
		}
	}
	//preorden raiz izquierdo derecho
	//inorden izquierdo raiz derecho
	//postorden izquierdo derecho raiz
	public void ejercicio2B(ListaDE ino, ListaDE pre) {
		if(pre.tamanio()!=0) {
			
			char raizEncontrada = ino.buscarRaiz(pre.darLetras());
			if(raizEncontrada=='0')
				System.out.println("Error");
			this.raiz = new NodoB(raizEncontrada);
			ArbolB izq = new ArbolB();
			ArbolB der = new ArbolB();
			
			
			izq.ejercicio2B(ino, pre.darHasta(raizEncontrada));
			der.ejercicio2B(ino, pre.darDesde(raizEncontrada));
			raiz.setNodoDer(der.raiz);
			raiz.setNodoIzq(izq.raiz);
		}
	}
	public void mostrarPostOrden() {
		if(raiz!=null) {
			ArbolB izq = new ArbolB(raiz.getNodoIzq());
			ArbolB der = new ArbolB(raiz.getNodoDer());
			izq.mostrarPostOrden();
			der.mostrarPostOrden();
			System.out.print(raiz.getDato()+" ");
		}
	}
	
	public boolean ejercicio3(char[] camino,int lugar) {
		if(lugar<camino.length) {
			if(raiz!=null) {
				if(camino[lugar]==raiz.getDato()) {
					ArbolB a = new ArbolB(raiz.getNodoDer());
					ArbolB b = new ArbolB(raiz.getNodoIzq());
					return a.ejercicio3(camino,lugar+1) || b.ejercicio3(camino, lugar+1);
				}
				else
					return false;
			}
			else
				return false;
		}
		return true;
	}
}
