/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package recursividad;
import java.util.Scanner;
/**
 *
 * @author cei
 */
public class Recursividad {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int[] v={1,2,2,-6,7,34,9,2,11};
        System.out.println("Ingresame un numerin para buscar cuantas veces esta en el arreglin");
        int num = sc.nextInt();
        System.out.println("El numero se encontro "+CantOcurrencias(v,0,9,num)+" veces");
        System.out.println("Ingresame un numerin para buscar en que posicion esta en el arreglin");
        num = sc.nextInt();
        System.out.println("El numero se encontro en la posicion: "+BuscarPosicion(v,0,9,num));
        System.out.println("El numero mayor del vector es: "+MayorYMenor(v,0,9)[0]+" y el numero menor del vector es: "+MayorYMenor(v,0,9)[1]);
        System.out.println("0: "+fibonacci(0));
        System.out.println("1: "+fibonacci(1));
        System.out.println("2: "+fibonacci(2));
        System.out.println("3: "+fibonacci(3));
        System.out.println("4: "+fibonacci(4));
        System.out.println("5: "+fibonacci(5));
        System.out.println("6: "+fibonacci(6));
        System.out.println("7: "+fibonacci(7));
        System.out.println("8: "+fibonacci(8));
        System.out.println("9: "+fibonacci(9));
        System.out.println("10: "+fibonacci(10));
        int[] vec={77,22,5,2,1,123};
        System.out.println(sumVec(vec,vec.length)+" "+sumVec2(vec,vec.length));
        System.out.println(MultVec(vec,vec.length));
        System.out.println(Minimo(vec,vec.length-1));
        System.out.println(PosMax(vec,vec.length-1));
        OrdenarVec(vec,vec.length-1);
        for(int i=0;i<vec.length;i++)
        {
            System.out.print(vec[i]+" ");
        }
    }
    public static int CantOcurrencias(int[] v,int desde, int hasta, int valor)
    {
        int res=0;
        if(v[desde]==valor)
        {
            res++;
        }
        if(desde+1<hasta)
        {
            res += CantOcurrencias(v,desde+1,hasta,valor);
        }
        return res;
    }
    public static int BuscarPosicion(int[] v,int desde, int hasta, int valor)
    {
        if(v[desde]==valor)
        {
            return desde;
        }
        if(desde+1<hasta)
        {
            return BuscarPosicion(v,desde+1,hasta,valor);
        }
        else
        {
            return -1;
        }
    }
    public static int[] MayorYMenor(int[] v,int desde, int hasta)
    {
        int[] res= {v[desde],v[desde]};
        if(desde+1<hasta)
        {
            if(res[0] <= MayorYMenor(v,desde+1,hasta)[0])
            {
                res[0] = MayorYMenor(v,desde+1,hasta)[0];
            }
            else
            {
                res[0] = v[desde];
            }
            if(res[1] >= MayorYMenor(v,desde+1,hasta)[1])
            {
                res[1] = MayorYMenor(v,desde+1,hasta)[1];
            }
            else
            {
                res[1] = v[desde];
            }
        }
        return res;
    }
    public static int fibonacci(int n)
    {
        int res=0;
        if(n>1)
        {
            res = fibonacci(n-1)+fibonacci(n-2);
        }
        if(n==1)
        {
            return res+1;
        }
        else
        {
            return res;
        }
    }
    public static int sumVec(int[] vec,int n)
    {
        if(n>0)
        {
            return sumVec(vec,n-1)+vec[n-1];
        }
        return 0;
    }
    //a este le pasas el largo del vector
    public static int sumVec2(int[] vec,int n)
    {
        int res=0;
        if(n>0)
        {
            res = sumVec2(vec,n-1)+vec[n-1];
        }
        return res;
    }
    public static int MultVec(int[] vec, int n)
    {
        int res=1;
        if(n>0)
        {
            res = MultVec(vec,n-1)*vec[n-1];
        }
        return res;
    }
    public static int Minimo(int[] vec,int n)
    {
        int min=vec[n];
        if(n>0)
        {
            if(min<Minimo(vec,n-1))
            {
                min=vec[n];
            }
            else
            {
                min=Minimo(vec,n-1);
            }
        }
        return min;
    }
    public static int PosMax(int[] vec,int n)
    {
        int maxPos=n;
        if(n>0)
        {
            if(vec[n]>vec[PosMax(vec,n-1)])
            {
                maxPos=n;
            }
            else
            {
                maxPos=PosMax(vec,n-1);
            }
        }
        return maxPos;
    }
    public static void OrdenarVec(int[] vec,int n)
    {
        if(n>1)
        {
            int aux=vec[n];
            int max=vec[PosMax(vec,n)];
            vec[n]=max;
            vec[PosMax(vec,n)]=aux;
            OrdenarVec(vec,n-1);
        }
    }
}
