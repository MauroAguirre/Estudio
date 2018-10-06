/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package repaso.para.el.parcial;

/**
 *
 * @author mauro
 */
public class RepasoParaElParcial {
    //ordenar vector
    //recorrer matriz
    public static void main(String[] args) {
        int[] vector={3,4,7,4,4,9};
        int[] vector2={11,5,7,9,8,12};
        int[][] matriz ={{2,5,7},{4,9,7},{6,2,2}};
        System.out.println(cantOcu(vector,0,6,9));
        System.out.println(cantOcu(vector,0,6,4));
        System.out.println(cantOcu(vector,0,6,1));
        System.out.println();
        System.out.println(buscarPos(vector,0,6,9));
        System.out.println(buscarPos(vector,0,6,4));
        System.out.println(buscarPos(vector,0,6,1));
        System.out.println();
        System.out.println(mayorMenorVec(vector,0,6)[0]);
        System.out.println(mayorMenorVec(vector,0,6)[1]);
        System.out.println();
        System.out.println(fibonaci(0));
        System.out.println(fibonaci(1));
        System.out.println(fibonaci(2));
        System.out.println(fibonaci(3));
        System.out.println(fibonaci(4));
        System.out.println(fibonaci(5));
        System.out.println(fibonaci(6));
        System.out.println(fibonaci(7));
        System.out.println();
        System.out.println(sumarVec(vector,0,6));
        System.out.println();
        System.out.println(MultiplicarVec(vector,0));
        System.out.println();
        System.out.println(PosMax(vector,5));
        System.out.println(PosMax(vector2,5));
        System.out.println();
        OrdenarVec(vector,vector.length-1);
        OrdenarVec(vector2,vector2.length-1);
        System.out.println("dfsadas");
        for(int i=0;i<vector.length;i++)
        {
            System.out.print(vector[i]+" ");
        }
        System.out.println();
        for(int i=0;i<vector2.length;i++)
        {
            System.out.print(vector2[i]+" ");
        }
        System.out.println();
        MatrizVer(matriz,0,0);
    }
    public static int cantOcu(int[] vec,int desde,int hasta,int valor)
    {
        int res;
        if(vec[desde]==valor)
        {
            res=1;
        }else
        {
            res=0;
        }
        if(desde+1<hasta)
        {
            return res+cantOcu(vec,desde+1,hasta,valor);
        }
        else
        {
            return res;
        }
    }
    public static int buscarPos(int[] vec,int desde,int hasta,int valor)
    {
        if(vec[desde]==valor)
        {
            return desde;
        }
        else
        {
            if(desde+1<hasta)
            {
                return buscarPos(vec,desde+1,hasta,valor);
            }
            else
            {
                return -1;
            }
        }
    }
    public static int[] mayorMenorVec(int[] vec,int desde,int hasta)
    {
        int[] res={vec[desde],vec[desde]};
        if(desde+1<hasta)
        {
            if(res[0]>mayorMenorVec(vec,desde+1,hasta)[0])
            {
                
            }
            else
            {
                res[0] = mayorMenorVec(vec,desde+1,hasta)[0];
            }
            if(res[1]<mayorMenorVec(vec,desde+1,hasta)[1])
            {
                
            }
            else
            {
                res[1] = mayorMenorVec(vec,desde+1,hasta)[1];
            }
        }
        return res;
    }
    public static int fibonaci(int max)
    {
        if(max==0)
        {
            return 0;
        }
        else
        {
            if(max==1)
            {
                return 1;
            }
            else
            {
                return fibonaci(max-1)+fibonaci(max-2);
            }
        }
    }
    public static int sumarVec(int[] vec,int desde,int hasta)
    {
        if(desde+1<hasta)
        {
            return sumarVec(vec,desde+1,hasta)+vec[desde];
        }
        else
        {
            return vec[desde];
        }
    }
    public static int MultiplicarVec(int[] vec,int num)
    {
        if(num<vec.length)
        {
            return vec[num]*MultiplicarVec(vec,num+1);
        }
        else
        {
            return 1;
        }
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
        if(n>0)
        {
            int aux=vec[n];
            int max=vec[PosMax(vec,n)];
            vec[n]=max;
            vec[PosMax(vec,n)]=aux;
            OrdenarVec(vec,n-1);
        }
    }
    public static void MatrizVer(int[][] mat,int col,int fil)
    {
        System.out.print(mat[col][fil]);
        if(fil+1<mat[0].length)
        {
            System.out.print(" - ");
            MatrizVer(mat,col,fil+1);
        }
        else
        {
            if(col+1<mat.length)
            {
                System.out.println();
                MatrizVer(mat,col+1,0);
            }
        }
    }
}
