/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package observer;

import java.util.Observable;
import java.util.Observer;

/**
 *
 * @author cei
 */
public class OtraChusma implements Observer{

   @Override
   public void update(Observable o, Object arg) {
      System.out.println(((Observada)o).getNumero().toString());
   }
   
}
