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
public class ArbolBB {
    public NodoB raiz;

    public ArbolBB() {
        this.raiz = null;
    }

    private ArbolBB subDerecho() {
        ArbolBB subDer = new ArbolBB();
        subDer.raiz = this.raiz.nodoDer;
        return subDer;
    }

    private ArbolBB subIzquierdo() {
        ArbolBB subIzq = new ArbolBB();
        subIzq.raiz = this.raiz.nodoIzq;
        return subIzq;
    }
    
    public void imprimir()
    {
        if(this.raiz != null)
        {
            System.out.print(this.raiz.dato);
            
            subIzquierdo().imprimir();
            subDerecho().imprimir();
        }
        /*else
        {
            System.out.println("El árbol es vacío");
        }*/

    }
    
    public void insertar(int elem) {
        
        if(this.raiz == null) //Si  es vacío
        {
            NodoB nuevo = new NodoB(null, null, elem);
            this.raiz=nuevo;
        }
        else
        {
            if(elem < this.raiz.dato)
            {
                //Inserto a la izquierda
                ArbolBB izq = this.subIzquierdo();
                izq.insertar(elem);
                this.raiz.nodoIzq=izq.raiz;
            }
            else if (elem > this.raiz.dato)
            {
                //Inserto a la derecha
                ArbolBB der = this.subDerecho();
                der.insertar(elem);
                this.raiz.nodoDer=der.raiz;
            }
            else
            {
                //No inserto nada porque ya existe
                System.out.println("El elemento ya se encuentra en el árbol");
                
            }
            
        }
    
          
    }
        
        



    
    
}
