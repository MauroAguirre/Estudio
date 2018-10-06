/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package observer;

/**
 *
 * @author cei
 */
public class Main {

   /**
    * @param args the command line arguments
    */
   public static void main(String[] args) {
      Observada obs = Observada.getInstancia(0);
      VentanaControl vtnCntrl = new VentanaControl();
      vtnCntrl.setObservada(obs);
      vtnCntrl.setVisible(true);
      VentanaChusma vtnChs = new VentanaChusma();
      VentanaChusma vtnChs2 = new VentanaChusma();
      vtnChs.setVisible(true);
      vtnChs2.setVisible(true);
      OtraChusma otra = new OtraChusma();
      obs.addObserver(vtnChs);
      obs.addObserver(vtnChs2);
      obs.addObserver(otra);
   }
}
