/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package observer;

import java.util.Observable;

/**
 *
 * @author cei
 */
public class Observada extends Observable {

   private static Observada instancia = null;
   private Integer numero;

   public static Observada getInstancia(Integer numero) {
      if (Observada.instancia == null) {
         Observada.instancia = new Observada(numero);
      }
      return Observada.instancia;
   }

   public Integer getNumero() {
      return numero;
   }

   private Observada(Integer numero) {
      this.numero = numero;
   }

   public void setNumero(Integer numero) {
      this.setChanged();
      this.notifyObservers();
      this.numero = numero;
   }
}
