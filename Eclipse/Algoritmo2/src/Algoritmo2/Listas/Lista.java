package Algoritmo2.Listas;

public class Lista {
	private NodoLista inicio;
	public Lista() {
		this.inicio = null;
	}
	public NodoLista DarNodoInicio() {
		return inicio;
	}
	public void InsertarInicio(int n) {
		NodoLista nuevo = new NodoLista(n);
		nuevo.SetNodoLista(inicio);
		this.inicio = nuevo;
	}
	public int MostrarNodo(int n) {
		NodoLista nodo = this.inicio;
		if(nodo==null) {
			return 0;
		}
		while(n!=0&&inicio.GetNodoLista()!=null) {
			nodo = nodo.GetNodoLista();
			n--;
		}
		return nodo.GetNodoDato();
	}
	public void MostrarTodo() {
		NodoLista nodo = this.inicio;
		if(nodo==null) {
			System.out.println("No hay datos ingresados");
		}
		else {
			System.out.print(nodo.GetNodoDato()+" - ");
			while(nodo.GetNodoLista()!=null) {
				nodo = nodo.GetNodoLista();
				System.out.print(nodo.GetNodoDato()+" - ");
			}
		}
		System.out.println();
	}
	public boolean Pertenece(int n) {
		NodoLista nodo = this.inicio;
		if(nodo == null)
			return false;
		if(nodo.GetNodoDato()==n)
			return true;
		while(nodo.GetNodoLista()!=null) {
			nodo = nodo.GetNodoLista();
			if(nodo.GetNodoDato()==n)
				return true;
		}
		return false;
	}
	public boolean PerteneceRecursiva(int n,NodoLista nodo) {
		if(nodo.GetNodoDato()==n)
			return true;
		else {
			if(nodo.GetNodoLista()==null)
				return false;
			else 
				return PerteneceRecursiva(n,nodo.GetNodoLista());
		}
	}
	public void Borrar(int n) {
		NodoLista nodo = this.inicio;
		if(nodo != null) {
			if(nodo.GetNodoDato()==n) {
				inicio = inicio.GetNodoLista();
				nodo=null;
			}
			else {
				while(nodo.GetNodoLista()!=null) {
					NodoLista aux = nodo;
					nodo = nodo.GetNodoLista();
					if(nodo.GetNodoDato()==n) {
						aux.SetNodoLista(nodo.GetNodoLista());
						nodo=null;
						break;
					}
				}
			}
		}
	}
	public void BorrarRecursiva(int n,NodoLista nodo1,NodoLista nodo2) {
		NodoLista aux = nodo1;
		NodoLista nodo = nodo2;
		if(nodo.GetNodoDato() == n) {
			if(aux==null) {
				this.inicio = nodo.GetNodoLista();
				nodo = null;
			}
			else {
				aux.SetNodoLista(nodo.GetNodoLista());
				nodo = null;
			}
		}
		else {
			if(nodo.GetNodoLista() !=null)
				BorrarRecursiva(n,nodo,nodo.GetNodoLista());
		}
	}
	public int Largo() {
		NodoLista nodo = this.inicio;
		if(nodo == null)
			return 0;
		else {
			int cantidad=1;
			while(nodo.GetNodoLista()!=null) {
				cantidad++;
				nodo=nodo.GetNodoLista();
			}
			return cantidad;
		}
	}
	public int LargoRecursivo(NodoLista nodo) {
		if(nodo==null) 
			return 0;
		else 
			return LargoRecursivo(nodo.GetNodoLista())+ 1;
		
	}
	public void Snoc(int n) {
		NodoLista nodo = this.inicio;
		if(nodo==null) {
			inicio = new NodoLista(n);
		}
		else {
			while(nodo.GetNodoLista()!=null) {
				nodo = nodo.GetNodoLista();
			}
			nodo.SetNodoLista(new NodoLista(n));
		}
	}
	public void SnocRecursivo(int n,NodoLista nodo) {
		if(nodo==null) 
			inicio = new NodoLista(n);
		else {
			if(nodo.GetNodoLista()==null) {
				NodoLista nuevo = new NodoLista(n);
				nodo.SetNodoLista(nuevo);
			}
			else {
				SnocRecursivo(n,nodo.GetNodoLista());
			}
		}
	}
	public Lista Invertir() {
		NodoLista nodo = inicio;
		Lista nueva = new Lista();
		if(inicio==null)
			return nueva;
		for(int i=0;i<this.Largo();i++) {
			nueva.InsertarInicio(nodo.GetNodoDato());
			nodo = nodo.GetNodoLista();
		}
		return nueva;
	}
	public boolean EstaOrdenada() {
		NodoLista nodo = inicio;
		if(nodo==null)
			return true;
		else {
			int grande = nodo.GetNodoDato()+1;
			while(nodo.GetNodoLista()!=null) {
				nodo = nodo.GetNodoLista();
				if(grande<=nodo.GetNodoDato())
					return false;
				grande = nodo.GetNodoDato();
			}
			return true;
		}
	}
	public void InsordD(int n) {
		boolean encontro = false;
		NodoLista nodo = this.inicio;
		if(nodo==null)
			inicio = new NodoLista(n);
		if(nodo.GetNodoDato()<n) {
			NodoLista nuevo = new NodoLista(n);
			nuevo.SetNodoLista(nodo);
			inicio = nuevo;
		}
		else {
			while(nodo.GetNodoLista()!=null) {
				if(nodo.GetNodoLista().GetNodoDato()<n) {
					NodoLista nuevo = new NodoLista(n);
					nuevo.SetNodoLista(nodo.GetNodoLista());
					nodo.SetNodoLista(nuevo);
					encontro = true;
					break;
				}
				nodo=nodo.GetNodoLista();
			}
			if(!encontro) {
				NodoLista nuevo = new NodoLista(n);
				nodo.SetNodoLista(nuevo);
			}
		}
	}
	public void InsordA(int n) {
		boolean encontro = false;
		NodoLista nodo = this.inicio;
		if(nodo==null)
			inicio = new NodoLista(n);
		if(nodo.GetNodoDato()>n) {
			NodoLista nuevo = new NodoLista(n);
			nuevo.SetNodoLista(nodo);
			inicio = nuevo;
		}
		else {
			while(nodo.GetNodoLista()!=null) {
				if(nodo.GetNodoLista().GetNodoDato()>n) {
					NodoLista nuevo = new NodoLista(n);
					nuevo.SetNodoLista(nodo.GetNodoLista());
					nodo.SetNodoLista(nuevo);
					encontro = true;
					break;
				}
				nodo=nodo.GetNodoLista();
			}
			if(!encontro) {
				NodoLista nuevo = new NodoLista(n);
				nodo.SetNodoLista(nuevo);
			}
		}
	}
	public int Cuenta(int n) {
		NodoLista nodo = inicio;
		int res=0;
		if(nodo!=null) {
			do {
				if(nodo.GetNodoDato()==n)
					res++;
				nodo=nodo.GetNodoLista();
			}while(nodo!=null);
		}
		return res;
	}
	public int Maximo() {
		NodoLista nodo = this.inicio;
		int max=inicio.GetNodoDato();
		do {
			if(nodo.GetNodoDato()>max) {
				max=nodo.GetNodoDato();
			}
			nodo=nodo.GetNodoLista();
		}while(nodo!=null);
		return max;
	}
	public int Promedio() {
		NodoLista nodo = inicio;
		int res=0;
		if(nodo!=null) {
			do {
				res+=nodo.GetNodoDato();
				nodo=nodo.GetNodoLista();
			}while(nodo!=null);
		}
		return res/this.Largo();
	}
	public int Tomar_n(int n) {
		NodoLista nodo = this.inicio;
		while(n-1!=0) {
			nodo = nodo.GetNodoLista();
			n--;
		}
		return nodo.GetNodoDato();
	}
	public NodoLista DarFinal() {
		NodoLista nodo = this.inicio;
		if(nodo==null)
			return null;
		while(nodo.GetNodoLista()!=null) {
			nodo = nodo.GetNodoLista();
		}
		return nodo;
	}
	public Lista Cambiar(int n,int m) {
		NodoLista nodo = this.inicio;
		Lista lista = new Lista();
		while(nodo!=null) {
			if(nodo.GetNodoDato()!=n) {
				lista.Snoc(nodo.GetNodoDato());
				nodo = nodo.GetNodoLista();
			}
			else {
				lista.Snoc(m);
				nodo = nodo.GetNodoLista();
			}
		}
		return lista;
	}
	public static boolean Iguales(Lista a,Lista b) {
		if(a.inicio == null && b.inicio == null)
			return true;
		else {
			if((a.inicio == null && b.inicio !=null) ||( a.inicio !=null && b.inicio == null) ) {
				return false;
			}
			else {
				if(a.inicio.GetNodoDato() != b.inicio.GetNodoDato())
					return false;
				else {
					a.inicio = a.inicio.GetNodoLista();
					b.inicio = b.inicio.GetNodoLista();
					return Iguales(a,b);
				}
			}
		}
	}
	public static Lista Intercalar(Lista a,Lista b,Lista nueva) {
		if(a.inicio!=null && b.inicio != null) {
			if(a.inicio.GetNodoDato()>b.inicio.GetNodoDato()) {
				nueva.Snoc(a.inicio.GetNodoDato());
				a.inicio = a.inicio.GetNodoLista();
				return Intercalar(a,b,nueva);
			}
			else {
				nueva.Snoc(b.inicio.GetNodoDato());
				b.inicio = b.inicio.GetNodoLista();
				return Intercalar(a,b,nueva);
			}
		}
		else {
			if(a.inicio!=null && b.inicio == null) {
				nueva.Snoc(a.inicio.GetNodoDato());
				a.inicio = a.inicio.GetNodoLista();
				return Intercalar(a,b,nueva);
			}
			else {
				if(a.inicio==null && b.inicio != null) {
					nueva.Snoc(b.inicio.GetNodoDato());
					b.inicio = b.inicio.GetNodoLista();
					return Intercalar(a,b,nueva);
				}
				else {
					return nueva;
				}
			}
		}
	}
	public static Lista Concatenar(Lista a,Lista b,Lista nueva) {
		if(a.inicio!=null) {
			nueva.Snoc(a.inicio.GetNodoDato());
			a.inicio = a.inicio.GetNodoLista();
			Concatenar(a,b,nueva);
		}else {
			if(b.inicio!=null) {
				nueva.Snoc(b.inicio.GetNodoDato());
				b.inicio = b.inicio.GetNodoLista();
				Concatenar(a,b,nueva);
			}
		}
		return nueva;
	}
	/*
	public static boolean EstaIncluidaSub(Lista a,Lista b) {
		if(a.inicio.GetNodoDato() == b.inicio.GetNodoDato()) {
			if(a.inicio.GetNodoLista()==null) {
				return true;
			}
			else {
				//if(a.inicio.GetNodoDato()!=null &&)
			}
		}
		return false;
	}
	public static boolean EstaIncluida(Lista a,Lista b) {
		if(a.inicio!=null && b.inicio!=null) {
			if(EstaIncluidaSub(a,b)) {
				
			}
		}
		else {
			if(a.inicio!=null) {
				a.inicio = a.inicio.GetNodoLista();
				return EstaIncluida(a,b);
			}
		}
		return false;
	}
	*/
}
