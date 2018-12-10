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
public class ArbolB {

    public NodoB raiz;

    public ArbolB() {
        this.raiz = null;
    }

    public ArbolB subDerecho() {
        ArbolB subDer = new ArbolB();
        subDer.raiz = this.raiz.nodoDer;
        return subDer;
    }

    public ArbolB subIzquierdo() {
        ArbolB subIzq = new ArbolB();
        subIzq.raiz = this.raiz.nodoIzq;
        return subIzq;
    }

    public int cantNodos() {
        int cant = 0;
        if (this.raiz != null) //No es vacìo
        {

            cant = 1 + this.subIzquierdo().cantNodos() + this.subDerecho().cantNodos();
        }
        return cant;

    }

    public int cantHojas() {
        int cant = 0;
        if (this.raiz != null) {
            if (this.esHoja()) //No tiene hijos (es una hoja)
            {
                cant = 1;
            } else {

                cant = this.subIzquierdo().cantHojas() + this.subDerecho().cantHojas();
            }

        }
        return cant;
    }

    public int peso() {
        int peso = 0;
        if (this.raiz != null) {

            peso = this.subIzquierdo().cantNodos() + this.subDerecho().cantNodos();
        }
        return peso;
    }

    public int peso2() {
        return this.cantNodos() - 1;
    }

    public boolean esHoja() {
        boolean hoja = false;
        if (this.raiz.nodoIzq == null && this.raiz.nodoDer == null) {
            hoja = true;
        }
        return hoja;
    }

    public int altura() {
        int alt = -1;
        if (this.raiz != null) {
            if (this.esHoja()) {
                alt = 0;
            } else {

                if (this.subIzquierdo().raiz == null) {
                    alt = 1 + subDerecho().altura();
                } else if (subDerecho().raiz == null) {
                    alt = 1 + subIzquierdo().altura();
                } else {

                    alt = 1 + Math.max(subIzquierdo().altura(), subDerecho().altura());
                }
            }
        }
        return alt;
    }

    public boolean esEquilibrado() {
        boolean equilibrado = false;
        int difAlturas = subIzquierdo().altura() - subDerecho().altura();
        if (Math.abs(difAlturas) <= 1) {
            equilibrado = true;
        }

        return equilibrado;
    }

    public boolean todosPares() {
        boolean pares = true;
        if (this.raiz != null) { //Si no es vacío

            if (this.raiz.dato % 2 != 0) { //Si la raìz no es par (paso base)
                pares = false;
            } else {
                pares = subIzquierdo().todosPares() && subDerecho().todosPares();
            }
        }
        return pares;
    }

    public boolean iguales(ArbolB a, ArbolB b) {
        boolean iguales = false;
        if (a.raiz == null && b.raiz == null) {
            iguales = true;
        } else if (a.raiz == null || b.raiz == null) {
            iguales = false;
        } else {

            if ((a.raiz.dato == b.raiz.dato) && iguales(a.subIzquierdo(), b.subIzquierdo()) && iguales(a.subDerecho(), b.subDerecho())) {
                iguales = true;
            }
        }
        return iguales;

    }

    public ArbolB clon() {
        ArbolB nuevo = new ArbolB();
        if (this.raiz.nodoDer != null && this.raiz.nodoIzq != null) {
            NodoB nodoNuevo = new NodoB(null, null, this.raiz.dato);//Creo un nodo solo con el dato de la raiz
            nodoNuevo.nodoIzq = this.subIzquierdo().clon().raiz;
            nodoNuevo.nodoDer = this.subDerecho().clon().raiz;

            nuevo.raiz = nodoNuevo;
        }
        return nuevo;

    }

}
