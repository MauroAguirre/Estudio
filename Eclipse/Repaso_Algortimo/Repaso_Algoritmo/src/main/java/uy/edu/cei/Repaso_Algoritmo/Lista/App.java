package uy.edu.cei.Repaso_Algoritmo.Lista;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        ListaS ls = new ListaS();
        System.out.println(ls.largo());
        ls.mostrar();
        ls.snoc(2);
        ls.snoc(5);
        ls.mostrar();
        ls.borrar(2);
        ls.mostrar();
        ls.snoc(7);
        if(ls.pertenece(7))
        	System.out.println("pertenece");
        else
        	System.out.println("no pertenece");
        if(ls.pertenece(1))
        	System.out.println("pertenece");
        else
        	System.out.println("no pertenece");
        System.out.println(ls.largo());
    }
}
