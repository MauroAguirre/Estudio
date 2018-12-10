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
public class NodoB {
    public int dato;
    public NodoB nodoIzq;
    public NodoB nodoDer;
    
    public NodoB(NodoB nodoI, NodoB nodoD, int nro)
    {
        this.dato=nro;
        this.nodoIzq=nodoI;
        this.nodoDer=nodoD;
    }
    
    
}
