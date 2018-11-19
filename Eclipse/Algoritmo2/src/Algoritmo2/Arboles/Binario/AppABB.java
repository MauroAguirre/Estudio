package Algoritmo2.Arboles.Binario;

public class AppABB {
	public static void main(String[] args) 
	{
		String res;
		ABB arbol1 = new ABB();
		arbol1.insertacion(100);
		arbol1.insertacion(66);
		arbol1.insertacion(120);
		arbol1.insertacion(115);
		arbol1.insertacion(139);
		arbol1.insertacion(88);
		arbol1.insertacion(33);
		arbol1.listarAscendente();
		/*
		arbol1.preOrden();
		System.out.println();
		arbol1.borrarMinimo();
		arbol1.preOrden();
		System.out.println();
		arbol1.borrarElemento(120);
		arbol1.preOrden();
		res = (arbol1.pertenece(100))?"Pertenece 100":"No pertenece 100";
		System.out.println(res);
		res = (arbol1.pertenece(99))?"Pertenece 90":"No pertenece 90";
		System.out.println(res);
		res = (arbol1.pertenece(66))?"Pertenece 66":"No pertenece 66";
		System.out.println(res);
		arbol1.insertacion(33);
		arbol1.insertacion(32);
		arbol1.insertacion(16);
		arbol1.preOrden();
		res = (arbol1.pertenece(32))?"Pertenece 32":"No pertenece 32";
		System.out.println(res);
		System.out.println();
		arbol1.listarAscendente();
		*/
	}
}
