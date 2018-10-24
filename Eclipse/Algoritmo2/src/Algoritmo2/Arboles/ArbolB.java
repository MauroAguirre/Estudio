package Algoritmo2.Arboles;

import java.util.ArrayList;

public class ArbolB {
	private NodoB raiz;
	public ArbolB() {
		this.raiz = null;
	}
	public NodoB getRaiz() {
		return raiz;
	}
	public void agregarIzq(String s) {
		if(raiz == null)
			raiz = new NodoB(s);
		else
			if(raiz.getNodoizq()==null) {
				NodoB nuevo = new NodoB(s);
				raiz.setNodoizq(nuevo);
			}
			else
				agregarIzqRec(raiz.getNodoizq(),s);
	}
	private void agregarIzqRec(NodoB nodo,String s) {
		if(nodo.getNodoizq()==null) {
			NodoB nuevo = new NodoB(s);
			nodo.setNodoizq(nuevo);
		}
		else
			agregarIzqRec(nodo.getNodoizq(),s);
	}
	public void agregarDer(String s) {
		if(raiz == null)
			raiz = new NodoB(s);
		else
			if(raiz.getNododer()==null) {
				NodoB nuevo = new NodoB(s);
				raiz.setNododer(nuevo);
			}
			else
				agregarDerRec(raiz.getNodoizq(),s);
	}
	private void agregarDerRec(NodoB nodo,String s) {
		if(nodo.getNododer()==null) {
			NodoB nuevo = new NodoB(s);
			nodo.setNododer(nuevo);
		}
		else
			agregarDerRec(nodo.getNodoizq(),s);
	}
	public int cantNodos(NodoB n) {
		if(n==null)
			return 0;
		else {
			if(n.getNododer()!=null&&n.getNodoizq()!=null)
				return 1+cantNodos(n.getNododer()) + cantNodos(n.getNodoizq());
			else {
				if(n.getNododer()!=null&&n.getNodoizq()==null)
					return 1+cantNodos(n.getNododer());
				else {
					if(n.getNododer()==null&&n.getNodoizq()!=null)
						return 1+cantNodos(n.getNodoizq()); 
					else
						return 1;
				}
			}
		}
	}
	public int cantHojas(NodoB n) {
		if(n==null)
			return 0;
		else {
			if(n.getNododer()!=null&&n.getNodoizq()!=null)
				return cantHojas(n.getNododer()) + cantHojas(n.getNodoizq());
			else {
				if(n.getNododer()!=null&&n.getNodoizq()==null)
					return cantHojas(n.getNododer());
				else {
					if(n.getNododer()==null&&n.getNodoizq()!=null)
						return cantHojas(n.getNodoizq()); 
					else
						return 1;
				}
			}
		}
	}
	public int peso() {
		if(raiz==null)
			return 0;
		else
			return cantNodos(raiz)-1;
	}
	public int altura() {
		List<> alturas = new ArrayList<int>();
	}
}
