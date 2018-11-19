package Algoritmo2.Arboles.Principio;

import java.util.ArrayList;
import java.util.List;

public class ArbolB {
	/*
	 * Arboles binarios
 	 * 
	 * Los arboles binarios (AB) son arboles donde cada nodo no puede tener mas de dos hojas (arbol de orden 2)
	 */
	
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
	public int altura2(NodoB n)
	{
		if(n==null)
			return -1;
		else {
			return 1+Math.max(altura2(n.getNododer()),altura2(n.getNodoizq()));
		}
	}
	public int altura(NodoB n) {
		int altura = 0;
		List<Integer> alturas = new ArrayList<Integer>();
		buscaAlturas(n,alturas,0);
		for(int i=0;i<alturas.size();i++) {
			if(alturas.get(i)>altura)
				altura=alturas.get(i);
		}
		return altura;
	}
	public void buscaAlturas(NodoB n,List<Integer> alturas,int altura) {
		if(n==null)
		{
			
		}
		else {
			if(n.getNododer()!=null&&n.getNodoizq()!=null) {
				buscaAlturas(n.getNododer(),alturas,altura+1);
				buscaAlturas(n.getNodoizq(),alturas,altura+1);
			}
			else {
				if(n.getNododer()!=null&&n.getNodoizq()==null)
					buscaAlturas(n.getNododer(),alturas,altura+1);
				else {
					if(n.getNododer()==null&&n.getNodoizq()!=null)
						buscaAlturas(n.getNodoizq(),alturas,altura+1); 
					else
						alturas.add(altura);
				}
			}
		}
	}
	public boolean todosPares2(NodoB n)
	{
		if(n==null)
			return true;
		else {
			if(Integer.parseInt(n.getDato())%2==0) {
				return todosPares2(n.getNododer()) && todosPares2(n.getNodoizq());
			}
			else 
				return false;
		}
	}
	public boolean todosPares(NodoB n) {
		if(n==null)
			return true;
		else {
			if(n.getNododer()!=null&&n.getNodoizq()!=null) {
				if(Integer.parseInt(n.getDato())%2!=0)
					return false;
				else
				{
					if(todosPares(n.getNododer()) && todosPares(n.getNodoizq()))
						return true;
					else
						return false;
				}			
			}
			else {
				if(n.getNododer()!=null&&n.getNodoizq()==null) {
					if(Integer.parseInt(n.getDato())%2!=0)
						return false;
					else
					{
						if(todosPares(n.getNododer()))
							return true;
						else
							return false;
					}	
				}				
				else {
					if(n.getNododer()==null&&n.getNodoizq()!=null)
						if(Integer.parseInt(n.getDato())%2!=0)
							return false;
						else
						{
							if(todosPares(n.getNodoizq()))
								return true;
							else
								return false;
						}	
					else
						if(Integer.parseInt(n.getDato())%2!=0)
							return false;
						else
							return true;
				}
			}
		}
	}
	public boolean iguales(NodoB a,NodoB b) {
		if(a==null || b==null)
			return true;
		else {
			if((a!=null && b==null)||(a==null && b!=null)) {
				return false;
			}
			else {
				if(a.getDato()==b.getDato()) {
					if(a.getNododer()!=null&&a.getNodoizq()!=null&&b.getNododer()!=null&&b.getNodoizq()!=null) {
						if(iguales(a.getNododer(),b.getNododer()) && iguales(a.getNodoizq(),b.getNodoizq()))
							return true;
						else
							return false;
					}
					else 
					{
						if(a.getNododer()==null&&a.getNodoizq()!=null&&b.getNododer()==null&&b.getNodoizq()!=null)
						{
							return iguales(a.getNodoizq(),b.getNodoizq());
						}
						else 
						{
							if(a.getNododer()!=null&&a.getNodoizq()==null&&b.getNododer()!=null&&b.getNodoizq()==null) 
							{
								return iguales(a.getNododer(),b.getNododer());
							}
							else
								return true;
						}
					}
				}
				else {
					return false;
				}
			}
		}
	}
	public void clon(NodoB n,ArbolB a,Boolean primera) {
		if(primera) {
			a.agregarDer(n.getDato());
			clon(n,a,false);
		}
		else {
			if(n.getNododer()!=null&&n.getNodoizq()!=null) {
				a.agregarIzq(n.getNodoizq().getDato());
				a.agregarDer(n.getNododer().getDato());
				clon(n.getNododer(),a,primera);
				clon(n.getNodoizq(),a,primera);
			}
			else {
				if(n.getNododer()!=null&&n.getNodoizq()==null) {
					a.agregarDer(n.getNododer().getDato());
					clon(n.getNododer(),a,primera);
				}
				else {
					if(n.getNododer()==null&&n.getNodoizq()!=null) {
						a.agregarIzq(n.getNodoizq().getDato());
						clon(n.getNodoizq(),a,primera);
					}
				}
			}
		}
	}
	public void espejo(NodoB n,ArbolB a,Boolean primera) {
		if(primera) {
			a.agregarDer(n.getDato());
			espejo(n,a,false);
		}
		else {
			if(n.getNododer()!=null&&n.getNodoizq()!=null) {
				a.agregarDer(n.getNodoizq().getDato());
				a.agregarIzq(n.getNododer().getDato());
				espejo(n.getNododer(),a,primera);
				espejo(n.getNodoizq(),a,primera);
			}
			else {
				if(n.getNododer()!=null&&n.getNodoizq()==null) {
					a.agregarIzq(n.getNododer().getDato());
					espejo(n.getNododer(),a,primera);
				}
				else {
					if(n.getNododer()==null&&n.getNodoizq()!=null) {
						a.agregarDer(n.getNodoizq().getDato());
						espejo(n.getNodoizq(),a,primera);
					}
				}
			}
		}
	}
	public void ver(NodoB n) {
		if(n!=null) {
			if(n.getNododer()!=null&&n.getNodoizq()!=null) {
				System.out.println(n.getDato());
				ver(n.getNododer());
				ver(n.getNodoizq());
			}
			else {
				if(n.getNododer()!=null&&n.getNodoizq()==null) {
					System.out.println(n.getDato());
					ver(n.getNododer());
				}	
				else {
					if(n.getNododer()==null&&n.getNodoizq()!=null) {
						System.out.println(n.getDato());
						ver(n.getNodoizq()); 
					}
					else
						System.out.println(n.getDato());
				}
			}
		}
	}
	public Boolean equilibrado(NodoB n) {
		List<Integer> alturas = new ArrayList<Integer>();
		buscaAlturas(n,alturas,0);
		int altura = alturas.get(0);
		for(int i=1;i<alturas.size();i++) {
			if(altura != alturas.get(i))
				return false;
		}
		return true;
	}
}
