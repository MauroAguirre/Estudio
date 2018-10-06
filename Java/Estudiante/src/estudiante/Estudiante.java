/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package estudiante;
import java.util.Scanner;
import java.util.Date;
import java.util.concurrent.ThreadLocalRandom;
/**
 *
 * @author Mauro
 */
public class Estudiante {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner sv = new Scanner(System.in);
        int op;
        int[] oro = new int[6];
        do{
            menu();
            System.out.println("Elija una opcion");
            op = sv.nextInt();
            
            switch (op){
                case 1:
                oro = generarnum();
                break;
                case 2:
                 do{   
                    for (int i=0; i<6; i++){
                       System.out.println(i+1+" - " +oro[i]);
                   }   
                    System.out.println("Elija 0 para salir al menu principal");
                    op= sv.nextInt();
                    if (op !=0){
                        oro[op -1]=ThreadLocalRandom.current().nextInt(1, 46 + 1);
                    }
                 }while (op !=0);   
                break;

            }
        }while (op !=3);
    }
    public static int[] generarnum(){
        int[] numeritos = new int[6];
        for (int i=0; i<6; i++){
            numeritos[i] = ThreadLocalRandom.current().nextInt(1, 46 + 1);
            System.out.println(numeritos[i]);
        }
        return numeritos;
    }
    
    
    public static void menu(){
        System.out.println("1-Generar numeros del 5 de oro");
        System.out.println("2-Cambiar numero");
        System.out.println("3-Salir");
    }
    
    
}
