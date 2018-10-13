package Algoritmo2.Listas;

public class ListaDoble {
	private NodoDoble inicio;
	
	public NodoDoble GetInicio() {
		return this.inicio;
	}
	public void SetInicio(NodoDoble nodo) {
		inicio = nodo;
	}
	
	public ListaDoble() {
		inicio = null;
	}
	
	public void MostrarNodos() {
		NodoDoble nodo = inicio;
		while(nodo!=null) {
			System.out.println(nodo.GetDato());
			nodo=nodo.GetSiguiente();
		}
	}
	
	public void Cons(ListaDoble l,int x) {
		NodoDoble nodo = l.GetInicio();
		NodoDoble nuevo = new NodoDoble(x);
		nuevo.SetSiguiente(nodo);
		if(nodo!=null)
			nodo.SetAnterior(nuevo);
		l.SetInicio(nuevo);
	}
	public void InsOrdA(ListaDoble l,int x) {
		NodoDoble nodo = l.inicio;
		if(nodo==null) {
			l.SetInicio(new NodoDoble(x));
		}
		else {
			while(nodo!=null) {
				if(nodo.GetDato()>x) {
					if(nodo.GetAnterior()!=null) {
						 NodoDoble nuevo = new NodoDoble(x);
						 nuevo.SetAnterior(nodo.GetAnterior());
						 nuevo.SetSiguiente(nodo);
						 nodo.GetAnterior().SetSiguiente(nuevo);
						 nodo.SetAnterior(nuevo);
					}
					else {
						NodoDoble nuevo = new NodoDoble(x);
						nuevo.SetSiguiente(nodo);
						nodo.SetAnterior(nuevo);
						l.inicio=nuevo;
					}
					return;
				}
				else {
					if(nodo.GetSiguiente()!=null)
						nodo = nodo.GetSiguiente();
					else {
						NodoDoble nuevo = new NodoDoble(x);
						nuevo.SetAnterior(nodo);
						nodo.SetSiguiente(nuevo);
						return;
					}
				}
			}
		}
	}
	public void Borrar(int x) {
		NodoDoble nodo = inicio;
		while(nodo!=null) {
			if(nodo.GetDato()==x) {
				if(nodo.GetAnterior()!=null&&nodo.GetSiguiente()!=null) {
					NodoDoble n = nodo.GetAnterior();
					n.SetSiguiente(nodo.GetSiguiente());
				}
				else {
					if(nodo.GetAnterior()==null&&nodo.GetSiguiente()!=null) {
						inicio=nodo.GetSiguiente();
						inicio.SetAnterior(null);
					}
					else {
						if(nodo.GetAnterior()!=null&&nodo.GetSiguiente()==null) {
							NodoDoble n = nodo.GetAnterior();
							n.SetSiguiente(null);
						}
						else {
							inicio=null;
						}
					}
				}
				break;
			}
			else {
				nodo=nodo.GetSiguiente();
			}
		}
	}
}
