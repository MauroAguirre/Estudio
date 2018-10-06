/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ayudando_junes;
import java.util.Scanner;
import java.util.Date;
import java.util.concurrent.ThreadLocalRandom;
/**
 *
 * @author Mauro
 */
public class Ayudando_junes {
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        int[] cincoOro = new int[5];
        int[] elegidos = {0,0,0,0,0};
        String eleccion;
        do
        {
            Menu(elegidos);
            eleccion = sc.nextLine();
            switch(eleccion)
            {
                case "a":
                case "A":
                    for(int i=0;i<5;i++)
                    {
                        System.out.println("Ingrese un numero");
                        elegidos[i] = sc.nextInt();
                    }
                    break;
                case "b":
                case "B":
                    cincoOro = Generar_cinco_de_oro();
                    for(int i=0;i<5;i++)
                    {
                        System.out.print(cincoOro[i]+" ");
                    }
                    break;
                case "c":
                case "C":
                    System.out.println("Bye");
                    break;
            }
        }while(eleccion!="c" || eleccion!="C"); 
    }
    public static void Menu(int[] numeros)
    {
        System.out.println("Menu");
        System.out.println("A-Ingrese sus numeros");
        System.out.println("B-Jugar");
        System.out.println("C-Salir");
        if(numeros[0]==0)
        {
            System.out.println("No hay numeros ingresados");
        }
        else
        {
            System.out.print("Los numeros ingresados son:");
            for(int i=0;i<5;i++)
            {
                System.out.print(" "+numeros[i]);
            }
            System.out.println();
        }
    }
    public static int[] Generar_cinco_de_oro()
    {
        int[] numeritos = {0,0,0,0,0};
        int contador = 0;
        int generado;
        boolean esta; 
        do
        {
            esta = false;
            generado = ThreadLocalRandom.current().nextInt(1, 46 + 1);
            for(int i=0;i<contador;i++)
            {
                if(numeritos[i]==generado)
                {
                    esta = true;
                } 
            }
            if(!esta)
            {
                numeritos[contador]=generado;
                contador++;
            }
        }while(contador<5);
        return numeritos;
    }
}
