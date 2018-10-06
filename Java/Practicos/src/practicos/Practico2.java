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
public class Practico2 {
    public static boolean Ejercicio1(int a)
    {
        for(int i=2;i<a;i++)
        {
            if(a%i==0)
            {
                return false;
            }
        }
        return true;
    }
    public static int Ejercicio2(int a)
    {
        int numero = a+1;
        while(!Ejercicio1(numero))
        {
            numero++;
        }
        return numero;
    }
    public static int[] Ejercicio3(int a,int b)
    {
        int numero=0;
        int resto;
        int cociente=0;
        while(numero+b<a)
        {
            numero+=3;
            cociente++;
        }
        resto = a - numero;
        int[] resultado = {cociente,resto};
        return resultado;
    }
    public static int Ejercicio4(int a,int b)
    {
        int mayor;
        int menor;
        if(a>b)
        {
            mayor =a;
            menor = b;
        }
        else
        {
            mayor=b;
            menor=a;
        }
        int resto=mayor/menor;
        while(resto>0)
        {
            mayor = menor;
            menor = resto;
            resto = mayor /menor;
        }
        return menor;
    }
    public static boolean Ejercicio6(int numero)
    {
        String numerin = String.valueOf(numero);
        for(int i=0;i<numerin.length()/2;i++)
        {
            if(numerin.charAt(i)!= numerin.charAt(numerin.length()-i-1))
            {
                return false;
            }
        }
        return true;
    }
    public static void Ejercicio7()
    {
        int numero=10001;
        while(numero<100000)
        {
            if(Ejercicio6(numero))
            {
                System.out.print(numero+" - ");
            }
            numero++;
        }
    }
    public static int Ejercicio8a(int[] vector,int desde,int hasta)
    {
        int maximo = vector[desde-1];
        int max = vector.length;
        if(max > hasta)
        {
            max = hasta;
        } 
        for(int i=desde-1;i<max;i++)
        {
            if(vector[i]>maximo)
            {
                maximo = vector[i];
            }
        }
        return maximo;
    }
    public static int Ejercicio8b(int[] vector,int desde,int hasta)
    {
        int maximo = desde-1;
        int max = vector.length;
        if(max > hasta)
        {
            max = hasta;
        } 
        for(int i=desde-1;i<max;i++)
        {
            if(vector[i]>maximo)
            {
                maximo = i;
            }
        }
        return maximo+1;
    }
    public static void Ejercicio9(int[] vec,int n)
    {
        for(int i=0;i<n;i++)
        {
            System.out.println(vec[i]);
        }
        System.out.println("\n");
        for(int i=1;i<n;i++)
        {
            int l = i;
            int x;
            while(l>0)
            {
                x=vec[l-1];
                if(vec[l]<vec[l-1])
                {
                    vec[l-1] = vec[l];
                    vec[l] = x;
                }
                l--;
            }  
        }
        for(int i=0;i<n;i++)
        {
            System.out.println(vec[i]);
        }
    }
    public static int Ejercicio10a(int[] vec,int n)
    {
        int suma=0;
        for(int i=0;i<n;i++)
        {
            suma+=vec[i];
        }
        return suma/n;
    }
    public static int[] Ejercicio10b(int[] vec,int n)
    {
        int minimo=vec[0];
        int veces = 0;
        int pos = 0;
        for(int i=0;i<n;i++)
        {
            if(minimo>vec[i])
            {
                minimo=vec[i];
                pos = i;
            }
        }
        for(int i=0;i<n;i++)
        {
            if(minimo==vec[i])
            {
                veces++;
            }
        }
        int[] res= {minimo,veces,pos};
        return res;
    }
    public static int[] Ordenar_Arreglo(int[] vec,int n)
    {
        for(int i=1;i<n;i++)
        {
            int l = i;
            int x;
            while(l>0)
            {
                x=vec[l-1];
                if(vec[l]<vec[l-1])
                {
                    vec[l-1] = vec[l];
                    vec[l] = x;
                }
                l--;
            }  
        }
        return vec;
    }
    public static void Ejercicio11(int[] a,int[] b,int maxa,int maxb)
    {
        int[] vector = new int[maxa+maxb];
        for(int i=0;i<a.length;i++)
        {
            vector[i]=a[i];
        }
        for(int i=0+a.length;i<b.length+a.length;i++)
        {
            vector[i]=b[i-a.length];
        }
        vector = Ordenar_Arreglo(vector,vector.length);
        for(int i=0;i<vector.length;i++)
        {
            System.out.print(vector[i]+" ");
        }       
    }
    public static void Ejercicio12(int[] vector)
    {
        int[] vectorOrdenado = Ordenar_Arreglo(vector,vector.length);
        System.out.println("El maximo numero es: "+vector[vector.length-1]+" y el segundo mayor es: "+vector[vector.length-2]);
    }
}
