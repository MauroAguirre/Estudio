/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package practicos;

/**
 *
 * @author cei
 */
public class Practico4 {

    public static int Ejercicio1(int n) {
        int resultado = 0;
        if (n == 0) {
            resultado = 1;
        } else {
            resultado = n * Ejercicio1(n - 1);
        }
        return resultado;
    }

    public static int Ejercicio2(int n) {
        int res = 0;
        if (n == 0) {
            res = 0;
        } else {
            if (n == 1) {
                res = 1;
            } else {
                res = Ejercicio2(n - 1) + Ejercicio2(n - 2);
            }
        }
        return res;
    }

    public static void Ejercicio3a(int n) {
        if (n == 0) {

        } else {
            System.out.print(n + " ");
            Ejercicio3a(n - 1);
        }
    }

    public static void Ejercicio3b(int n) {
        if (n == 0) {

        } else {
            Ejercicio3b(n - 1);
            System.out.print(n + " ");
        }
    }

    public static int Ejercicio4_minimo(int[] n, int pos) {
        int res = n[0];
        if (pos > 0) {
            if (n[pos] <= Ejercicio4_minimo(n, pos - 1)) {
                res = n[pos];
            } else {
                res = Ejercicio4_minimo(n, pos - 1);
            }
        }
        return res;
    }

    public static int Ejercicio4_posmax(int[] n, int pos) {
        int res = 0;
        if (pos > 0) {
            if (n[pos] >= n[Ejercicio4_posmax(n, pos - 1)]) {
                res = pos;
            } else {
                res = Ejercicio4_posmax(n, pos - 1);
            }
        }
        return res;
    }

    public static void Ejercicio4_ordenar(int[] vec, int max) {

        if (max == 1) {

        } else {
            int aux = vec[Ejercicio4_posmax(vec, max)];
            vec[Ejercicio4_posmax(vec, max)] = vec[max];
            vec[max] = aux;
            Ejercicio4_ordenar(vec, max - 1);
        }
    }

    public static int Ejercicio5(int a, int b) {
        int res = 1;
        if (b == 0) {
            return res;
        } else {
            if (b > 0) {
                res = a * Ejercicio5(a, b - 1);
            } else {
                res = a * Ejercicio5(a, b + 1);
            }
        }
        return res;
    }

    public static boolean Ejercicio6(int a, int b) {
        if (mcd(a, b) == 1) {
            return true;
        }
        return false;
    }

    public static int mcd(int x, int y) {
        int res = x;
        if (y == 0) {
            return res;
        } else {
            res = mcd(y, x % y);
        }
        return res;
    }

    public static int Ejercicio7(int n) {
        //1 1
        //2 2
        //3 3
        //4 .... -- -.. ..- .-. 5 
        //5 ..... --. .-- .-.. ..-. -.- -... ...- 8 
        int res = 1;
        if (n == 0) {
            //  res = 1;
        } else {
            if (n == 1) {
                res = +1;
            } else {
                res = Ejercicio7(n - 1) + Ejercicio7(n - 2);
            }
        }
        return res;
    }

    public static int Ejercicio8(int n, int k) {
        //k*2 *2 n veces -1

        int x1, x2;
        if (n < 1) {
            return k;
        } else {
            x1 = Ejercicio8(n - 1, k);
            x2 = Ejercicio8(n - 1, k);
            return (x1 + x2);
        }
    }
    public static boolean Ejercicio9(int izq,int der,int x,int v[])
    {
        if(izq>der)
        {
            return false;
        }
        else
        {
            int medio = (izq+der)/2;
            if(v[medio]==x)
            {
                return true;
            }
            else
            {
                return(Ejercicio9(izq,medio-1,x,v)||Ejercicio9(medio+1,der,x,v));
            }
        }
    }
    
    public static int Ejercicio10(int v[],int izq,int der)
    {
        if(izq>der)
            return 0;
        else
        {
            int medio=(izq+der)/2;
            return (v[medio]+Ejercicio10(v,izq,medio-1)+Ejercicio10(v,medio+1,der));
        }
    }
    
    public static void BorrarIsla(int[][] mapa, int m, int n) {
        mapa[m][n] = 0;
        if (mapa.length != m + 1) {
            if (mapa[m + 1][n] == 1) {
                BorrarIsla(mapa, m + 1, n);
            }
        }
        if (mapa[0].length != n + 1) {
            if (mapa[m][n + 1] == 1) {
                BorrarIsla(mapa, m, n + 1);
            }
        }
        if (mapa.length != m + 1 && mapa[0].length != n + 1) {
            if (mapa[m + 1][n + 1] == 1) {
                BorrarIsla(mapa, m + 1, n + 1);
            }
        }
        if (m > 0) {
            if (mapa[m - 1][n] == 1) {
                BorrarIsla(mapa, m - 1, n);
            }
        }
        if (n > 0) {
            if (mapa[m][n - 1] == 1) {
                BorrarIsla(mapa, m, n - 1);
            }
        }
        if (m > 0 && n > 0) {
            if (mapa[m - 1][n - 1] == 1) {
                BorrarIsla(mapa, m - 1, n - 1);
            }
        }
    }

    public static void Ejercicio11(int[][] mat, int a, int b, int can) {

        if (mat[a][b] == 1) {
            System.out.println("X");
            can++;
            BorrarIsla(mat, a, b);
        }
        if (b + 1 < mat[0].length) {
            Ejercicio11(mat, a, b + 1, can);
        } else {
            if (a + 1 < mat.length) {
                Ejercicio11(mat, a + 1, 0, can);
            }
            else
            {
                System.out.println(can);
            }
        }
    }
    
    public static int[] Ejercicio12(int[] vector,int desde,int hasta)
    {
        int[] num= new int[2]; 
        //mas chico
        num[0]=vector[0];
        //mas grande
        num[1]=vector[0];
        if (desde<hasta) {
            if (vector[desde] <= Ejercicio12(vector, desde+1,hasta)[0]) {
                num[0] = vector[desde];
            } else {
                num[0] = Ejercicio12(vector, desde+1,hasta)[0];
            }
            
            if (vector[desde] >= Ejercicio12(vector, desde+1,hasta)[1]) {
                num[1] = vector[desde];
            } else {
                num[1] = Ejercicio12(vector, desde+1,hasta)[1];
            }
            
        }
        return num;
    }
}
