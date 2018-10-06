/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package practicos;

/**
 *
 * @author Mauro
 */
public class Practico1 {
    public static void Ejercicio1()
    {
        int suma=0;
        for(int i=1;i<50;i+=2)
        {
            suma+=i;
        }
        System.out.println(suma);
    }
    public static int Promedio(int a,int b)
    {
        return a+b/2;
    }
    public static int Pares(int a,int b)
    {
        int suma=0;
        if(a%2!=0)
        {
            a+=1;
        }
        for(int i=a;i<b;i+=2)
        {
            suma++;
        }
        return suma;
    }
    public static int SumaAbsolutos(int a,int b)
    {
        if(a<0)
        {
            a*=-1;
        }  
        if(b<0)
        {
            b*=-1;
        }
        return a+b;
    }
    public static void Ejercicio2(int a, int b)
    {
        System.out.println(Promedio(a,b));
        System.out.println(Pares(a,b));
        System.out.println(SumaAbsolutos(a,b));
    }
    public static void Ejercicio3(int a)
    {
        String cadena = String.valueOf(a);
        for(int i=0;i<cadena.length();i++)
        {
            System.out.print(cadena.charAt(i));
            if(i+1 != cadena.length())
                System.out.print("-");
        }
        System.out.print("\n");
    }
    public static void Ejercicio4(int a, int b)
    {
        int mayor=0;
        int menor=0;
        if(a>b)
        {
            mayor=a;
            menor=b;
        }
        else
        {
            mayor=b;
            menor=a;
        }
        System.out.print("El mayor es: "+mayor+"\n");
        int suma=0;
        for(int i=menor;i<=mayor;i++)
        {
            suma+=i;
        }
        System.out.print("La suma de los numeros es de: "+suma+"\n");
    }
    public static int[] wopa()
    {
        int[] a = {2,3,4};
        return a;
    }
}
