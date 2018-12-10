/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package practico_arboles;

/**
 *
 * @author Profesor
 */
public class Practico_Arboles {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        ArbolBB arbol = new ArbolBB();
        arbol.imprimir();
        arbol.insertar(3);         
        arbol.insertar(1);
        arbol.insertar(4);
        arbol.insertar(6);
        arbol.insertar(9);
        arbol.insertar(2);
        arbol.insertar(5);
        arbol.insertar(7);  
        
          arbol.imprimir();
    }
    
}
