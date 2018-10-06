/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package natii;
import java.util.Scanner;
/**
 *
 * @author Mauro
 */
public class Natii {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        int temp;
        String mes;
        int diamenor = 99;
        int diamayor = -99;
        int mayortemp = -99999;
        int menortemp = 99999;
        String mayormes ="";
        String menormes ="";
        for(int num=1;num<=3;num=num+1)
        {
            if(num==1){
                mes="abril";
            }
            else
            {
                if(num==2)
                {
                    mes="Junio";
                }
                else
                {
                    mes="Setiembre";
                }
            }
            System.out.print("Ingresame la temperatura del mes: ");
            System.out.println(mes);
            for(int dia=1;dia<=30;dia=dia+1)
            {
                System.out.print("Injgresae la temperatura del dia: ");
                System.out.println(dia);
                temp = reader.nextInt();
                if(temp>mayortemp)
                {
                    diamayor = dia;
                    mayortemp = temp;
                    mayormes = mes;
                }
                if(temp<menortemp)
                {
                    diamenor = dia;
                    menortemp = temp;
                    menormes = mes;
                }
            }
        }
        System.out.println("La temperatura del mayor mes es: "+mayormes);
        System.out.print(diamayor+" ");
        System.out.print(mayormes +" ");
        System.out.println(mayortemp);
        
        System.out.println("La temperatura del menor mes es: ");
        System.out.print(diamenor+ " ");
        System.out.print(menormes+" ");
        System.out.print(menortemp);
    }
    
}
