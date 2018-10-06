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
import java.util.Scanner;
public class Practico3 {
    public static void Ejercicio1a()
    {
        String[][] matriz;
        Scanner reader = new Scanner(System.in);
        System.out.println("Cuantas filas queres?");
        int fil =reader.nextInt();
        System.out.println("Cuantas columnas queres?");
        int col =reader.nextInt();
        matriz = new String[fil][col];
        for(int i=0;i<fil;i++)
        {
            for(int l=0;l<col;l++)
            {
                System.out.println("Ingrese un nombre");
                matriz[i][l] = reader.next();
            }
        }
        for(int i=0;i<fil;i++)
        {
            for(int l=0;l<col;l++)
            {
                System.out.print(matriz[i][l]+" ");
            }
            System.out.println();
        }
    }
    public static void Ejercicio1b()
    {
        String[][] matriz= {{"Juan Rodriguez","Martin Ocampo"},{"Maria Perez","Ignacio Castillo"},{"Carla Gomez","Ana Romero"}};
        for(int i=0;i<matriz.length;i++)
        {
            for(int l=0;l<matriz[0].length;l++)
            {
                System.out.print(matriz[i][l]+" ");
            }
            System.out.println();
        }
    } 
    public static void Ejercicio2()
    {
        int[][] matri1 = {{3,2},{6,5},{7,5}};
        int[][] matri2 = {{8,2},{1,1},{12,3}};
        int[][] matri1_3x4 = {{3,2,5,7},{6,5,9,0},{7,5,3,3}};
        int[][] matri2_3x4 = {{3,2,5,7},{6,5,9,0},{7,5,3,3}};
        int[][] matri1_5x4 = {{3,2,8,3},{6,5,2,5},{7,5,3,2},{6,4,3,2},{2,3,4,5}};
        int[][] matri2_5x4 = {{3,2,8,3},{6,5,2,5},{7,5,3,2},{6,4,3,2},{2,3,4,5}};
        int[][] matri1_4x4 = {{3,2,8,3},{6,5,2,5},{7,5,3,2},{6,4,3,2}};
        int[][] matri2_4x4 = {{3,2,8,3},{6,5,2,5},{7,5,3,2},{6,4,3,2}};
        for(int i=0;i<matri1.length;i++)
        {
            for(int l=0;l<matri1[0].length;l++)
            {
                System.out.print(matri1[i][l]+matri2[i][l] + " ");
            }
            System.out.println();
        }
        System.out.println();
        for(int i=0;i<matri1.length;i++)
        {
            for(int l=0;l<matri1[0].length;l++)
            {
                System.out.print(matri1[i][l]-matri2[i][l] + " ");
            }
            System.out.println();
        }
        System.out.println();
        for(int i=0;i<matri1_3x4.length;i++)
        {
            for(int l=0;l<matri1_3x4[0].length;l++)
            {
                System.out.print(matri1_3x4[i][l]+matri2_3x4[i][l] + " ");
            }
            System.out.println();
        }
        System.out.println();
        for(int i=0;i<matri1_3x4.length;i++)
        {
            for(int l=0;l<matri1_3x4[0].length;l++)
            {
                System.out.print(matri1_3x4[i][l]-matri2_3x4[i][l] + " ");
            }
            System.out.println();
        }
        System.out.println();
        for(int i=0;i<matri1_5x4.length;i++)
        {
            for(int l=0;l<matri1_5x4[0].length;l++)
            {
                System.out.print(matri1_5x4[i][l]+matri2_5x4[i][l] + " ");
            }
            System.out.println();
        }
        System.out.println();
        for(int i=0;i<matri1_5x4.length;i++)
        {
            for(int l=0;l<matri1_5x4[0].length;l++)
            {
                System.out.print(matri1_5x4[i][l]-matri2_5x4[i][l] + " ");
            }
            System.out.println();
        }
        System.out.println();
        for(int i=0;i<matri1_4x4.length;i++)
        {
            for(int l=0;l<matri1_4x4[0].length;l++)
            {
                System.out.print(matri1_4x4[i][l]+matri2_4x4[i][l] + " ");
            }
            System.out.println();
        }
        System.out.println();
        for(int i=0;i<matri1_4x4.length;i++)
        {
            for(int l=0;l<matri1_4x4[0].length;l++)
            {
                System.out.print(matri1_4x4[i][l]-matri2_4x4[i][l] + " ");
            }
            System.out.println();
        }
    }
    public static void Ejercicio3()
    {
        int[][] modelos = {{400,200,50},{300,100,30}};
        double[][] terminacion = {{25,1},{30,1.2},{33,1.3}};
        for(int i=0;i<modelos.length;i++)
        {
            if(i==0)
            {
                System.out.print("Lavadoras A: ");
            }
            else
            {
                System.out.print("Lavadoras B: ");
            }
            for(int l=0;l<modelos[0].length;l++)
            {
                switch(l)
                {
                    case 0:
                        System.out.print(" N: ");
                        break;
                    case 1:
                        System.out.print(" L: ");
                        break;
                    case 2:
                        System.out.print(" S: ");
                        break;
                }
                System.out.print(modelos[i][l]+" ");
            }
            System.out.println();
        }
        System.out.println();
        for(int i=0;i<terminacion.length;i++)
        {
            switch(i)
            {
                case 0:
                    System.out.print(" N: ");
                    break;
                case 1:
                    System.out.print(" L: ");
                    break;
                case 2:
                    System.out.print(" S: ");
                    break;
            }
            for(int l=0;l<terminacion[0].length;l++)
            {
                if(l==0)
                {
                    System.out.print("Horas en el taller: ");
                }
                else
                {
                    System.out.print("Horas de administracion: ");
                }
                System.out.print(terminacion[i][l]+" ");
            }
            System.out.println();
        }
        System.out.println();
        for(int i=0;i<terminacion.length;i++)
        {
            switch(i)
            {
                case 0:
                    System.out.print("Costo del modelo N: ");
                    break;
                case 1:
                    System.out.print("Costo del modelo L: ");
                    break;
                case 2:
                    System.out.print("Costo del modelo S: ");
                    break;
            }
            System.out.print(CostoModelo(10,2,terminacion[i][0],terminacion[i][1]));
            System.out.println();
        }
        System.out.println();
        
        System.out.println("Terminacion       Modelo A    Modelo B");
        for(int i=0;i<terminacion.length;i++)
        {
            switch(i)
            {
                case 0:
                    System.out.print(" N: ");
                    break;
                case 1:
                    System.out.print(" L: ");
                    break;
                case 2:
                    System.out.print(" S: ");
                    break;
            }
            for(int l=0;l<terminacion[0].length;l++)
            {
                if(l==0)
                {
                    System.out.print(CostoModelo(10,2,terminacion[i][l],terminacion[i][1])*modelos[l][i]+"    ");
                }
                else
                {
                    System.out.print(CostoModelo(10,2,terminacion[i][l],terminacion[i][1])*modelos[l][i]);
                }
            }
            System.out.println();
        }
    }
    public static double CostoModelo(double costoTaller,double CostoAdministracion,double horaTaller, double HoraAdministracion)
    {
        return costoTaller*horaTaller+CostoAdministracion*HoraAdministracion;
    }
    public static void Ejercicio4()
    {
        int[][] matriz = {{9,6,3},{7,3,2},{1,5,2}};
        System.out.println("El mayor valor es: "+Buscar_mayor_valor_y_posicion(matriz)[0]);
        System.out.println("La posicion es: "+Buscar_mayor_valor_y_posicion(matriz)[1]+" "+Buscar_mayor_valor_y_posicion(matriz)[2]);
        System.out.println("El mayor valor es: "+Buscar_menor_valor_y_posicion(matriz)[0]);
        System.out.println("La posicion es: "+Buscar_menor_valor_y_posicion(matriz)[1]+" "+Buscar_mayor_valor_y_posicion(matriz)[2]);
        Columa_minimo(matriz);
        Fila_maximo(matriz);
    }
    public static int[] Buscar_mayor_valor_y_posicion(int[][] matriz)
    {
        int mayor = matriz[0][0];
        int[] posicion = {0,0};
        for(int i=0;i<matriz.length;i++)
        {
            for(int l=0;l<matriz[0].length;l++)
            {
                if(matriz[i][l]>mayor)
                {
                    mayor = matriz[i][l];
                    posicion[0]=i;
                    posicion[1]=l;
                }
            }
        }
        int[] resultado={mayor,posicion[0],posicion[1]};
        return resultado;
    }
    public static int[] Buscar_menor_valor_y_posicion(int[][] matriz)
    {
        int menor = matriz[0][0];
        int[] posicion = {0,0};
        for(int i=0;i<matriz.length;i++)
        {
            for(int l=0;l<matriz[0].length;l++)
            {
                if(matriz[i][l]<menor)
                {
                    menor = matriz[i][l];
                    posicion[0]=i;
                    posicion[1]=l;
                }
            }
        }
        int[] resultado={menor,posicion[0],posicion[1]};
        return resultado;
    }
    public static void Columa_minimo(int[][] matriz)
    {
        int menor = matriz[0][0];
        int posicion = 0;
        for(int i=0;i<matriz.length;i++)
        {
            for(int l=0;l<matriz[0].length;l++)
            {
                if(matriz[i][l]<menor)
                {
                    menor = matriz[i][l];
                    posicion = i;
                }
            }
        }
        for(int i=0;i<matriz[0].length;i++)
        {
            System.out.print(matriz[posicion][i]+ " - ");
        }
         System.out.println();
    }
    public static void Fila_maximo(int[][] matriz)
    {
        int maximo = matriz[0][0];
        int posicion = 0;
        for(int i=0;i<matriz.length;i++)
        {
            for(int l=0;l<matriz[0].length;l++)
            {
                if(matriz[i][l]>maximo)
                {
                    maximo = matriz[i][l];
                    posicion = l;
                }
            }
        }
        for(int i=0;i<matriz.length;i++)
        {
            System.out.print(matriz[i][posicion]+ " - ");
        }
         System.out.println();
    }
}
