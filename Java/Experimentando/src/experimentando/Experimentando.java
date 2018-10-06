/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package experimentando;
import java.util.ArrayList;
/**
 *
 * @author Mauro
 */
public class Experimentando {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        /*
        ArrayList<Integer> arreglito = new ArrayList<Integer>();
        arreglito.add(2);
        arreglito.add(9);
        arreglito.add(3);
        arreglito.add(6);
        arreglito = OrdenarArray(arreglito);
        for(int i=0;i<arreglito.size();i++)
        {
            System.out.println(arreglito.get(i));
        }*(
        /*
        int[][] arreglo = {{3,2,1},{2,3,2},{5,4,3}};
        for(int f=0;f<arreglo.length;f++)
        {
            for(int c=0;c<arreglo[0].length;c++)
            {
                System.out.print(arreglo[f][c]+" ");
            }
            System.out.println();
        }
        System.out.println(wopa(arreglo,0,0));
        System.out.println("1 - "+algo(1));
        System.out.println("2 - "+algo(2));
        System.out.println("3 - "+algo(3));
        System.out.println("4 - "+algo(4));
        MatrizRec(arreglo,0,0);*/
        ArrayList<Integer> arreglito = new ArrayList<Integer>();
        arreglito.add(2);
        arreglito.add(9);
        arreglito.add(3);
        arreglito.add(6);
        arreglito.add(33);
        arreglito.add(26);
        arreglito.add(22);
        arreglito = OrdenarLista(arreglito);
        for(int i=0;i<arreglito.size();i++)
        {
            System.out.print(arreglito.get(i)+" - ");
        }
        
    }
    public static ArrayList OrdenarLista(ArrayList<Integer> arreglito)
    {
        int lugar = 0;
        int menor = 0;
        ArrayList<Integer> ordenados = new ArrayList<Integer>();
        do
        {
            for(int i=0;i<arreglito.size();i++)
            {
                if(i==0)
                {
                    menor = arreglito.get(i);
                    lugar = i;
                }
                else
                {
                    if(arreglito.get(i)<menor)
                    {
                        menor = arreglito.get(i);
                        lugar = i;
                    }
                }
            }
            ordenados.add(menor);
            arreglito.remove(lugar);
        }while(arreglito.size()>0);
        return ordenados;
    }
    public static ArrayList OrdenarArray(ArrayList viejo)
    {
        ArrayList<Integer> nuevo = new ArrayList<Integer>();
        int max,lugar;
        do
        {
            max = -3;
            lugar = 0;
            for(int i=0;i<viejo.size();i++)
            {
                if(Integer.parseInt(String.valueOf(viejo.get(i)))>max)
                {
                    max=Integer.parseInt(String.valueOf(viejo.get(i)));
                    lugar=i;
                }
            }
            nuevo.add(max);
            viejo.remove(lugar);
        }while(viejo.size()!=0);
        return nuevo;
    }
    public static int wopa(int[][] arreglo,int a,int b)
    {
        int num=0;
        if(arreglo[a][b]==3)
        {
            num += 1;
        }
        if(a+1 < arreglo.length)
        {
            num += wopa(arreglo,a+1,b);
        }
        if(b+1 < arreglo[0].length)
        {
            num += wopa(arreglo,a,b+1);
        }
        return num;
    }
    public static int algo(int num)
    {
        int res= 1;
        if(num==0)
        {
            
        }
        else
        {
            res += 2 + algo(num-1);
        }
        return res;
    }
    public static void MatrizRec(int[][] mat,int a,int b)
    {
        System.out.print(mat[a][b]+" ");
        if(b+1<mat[0].length)
        {
            MatrizRec(mat,a,b+1);
        }
        else
        {
            if(a+1<mat.length)
            {
                System.out.print("\n");
                MatrizRec(mat,a+1,0);
            }
        }
    }
	public static void VectorRec(int[] vec,int hasta)
	{
		System.out.print(vec[hasta]);
		if(hasta+1<vec.length)
		{
			VectorRec(vec,hasta+1);
		}
	}
}
