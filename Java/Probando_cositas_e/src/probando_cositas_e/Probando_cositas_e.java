/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package probando_cositas_e;
import java.util.Scanner;
/**
 *
 * @author mauro
 */
public class Probando_cositas_e {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //ingresar cosas por pantalla
        
        Scanner console = new Scanner(System.in);
        /*
        //vector o arreglo
        int[] numeros=new int[10];
        for(int i=0;i<10;i++)
        {
            numeros[i] = console.nextInt();
            numeros[i] = numeros[i]+5;
        }
        for(int i=0;i<10;i++)
        {
            System.out.println(numeros[i]);
        }
        */
        boolean Es_Palindromo=true;
        System.out.println("Ingresame un palabra");
        char[] letras= new char[15];
        int contador=0;
        char letra;
        letra = console.next().charAt(0);
        while(letra!='.')
        {
            letras[contador] = letra;
            contador++;
            letra=console.next().charAt(0);
        }
        for(int i=0;i<contador/2;i++)
        {
            if(letras[i]!=letras[contador-1-i])
            {
                Es_Palindromo = false;
            }
        }
        if(Es_Palindromo==true)
        {
            System.out.println("La palabra es palindromo");
        }
        else
        {
            System.out.println("La palabra no es palindromo");
        }
        int vocales=0;
        for(int i=0;i<contador;i++)
        {
            if(letras[i]=='a'||letras[i]=='e'||letras[i]=='i'||
                    letras[i]=='o'||letras[i]=='u')
            {
                vocales=vocales+1;
            }
        }
        System.out.println("Hay "+vocales+" vocales");
        /*
        System.out.println("Ingresame un palabra");
        String palabra = console.next();
        System.out.println(palabra);
        //anana
        //dasdas
        for(int i=0;i<palabra.length()/2;i++)
        {
            if(palabra.charAt(i)!=palabra.charAt(palabra.length()-1-i))
            {
                Es_Palindromo = false;
            }
        }
        if(Es_Palindromo==true)
        {
            System.out.println("La palabra es palindromo");
        }
        else
        {
            System.out.println("La palabra no es palindromo");
        }
        int vocales=0;
        for(int i=0;i<palabra.length();i++)
        {
            if(palabra.charAt(i)=='a'||palabra.charAt(i)=='e'||
                    palabra.charAt(i)=='i'||
                    palabra.charAt(i)=='o'||palabra.charAt(i)=='u')
            {
                vocales=vocales+1;
            }
        }
        System.out.println("Hay "+vocales+" vocales");
        */
    }
    
}
