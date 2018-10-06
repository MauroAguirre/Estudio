/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package repaso.para.parcial;
import java.util.Scanner;
/**
 *
 * @author cei
 */
public class RepasoParaParcial {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        int[][] matriz;
        //ingresar matriz
        System.out.println("Que tan largo quiere que sea la matriz?");
        int largo = reader.nextInt();
        System.out.println("Que tan ancho quiere que sea la matriz?");
        int ancho = reader.nextInt();
        matriz = new int[largo][ancho];
        for(int i=0;i<largo;i++)
        {
            for(int l=0;l<ancho;l++)
            {
                System.out.println("Ingrese un numero");
                matriz[i][l] = reader.nextInt();
            }
        }
        //mostrar matriz
        System.out.println("Esta es la matriz: ");
        for(int i=0;i<largo;i++)
        {
            for(int l=0;l<ancho;l++)
            {
                System.out.print(matriz[i][l]);
            }
            System.out.println();
        }
        //sumar columna
        System.out.println("Que columna quiere sumar?");
        int fila = reader.nextInt();
        int suma=0;
        for(int i=0;i<largo;i++)
        {
            suma += matriz[i][fila-1];
        }
        System.out.println("La suma de la fila es igual a: "+suma);
        //sumar fila
        System.out.println("Que fila quiere sumar?");
        int col = reader.nextInt();
        suma=0;
        for(int i=0;i<ancho;i++)
        {
            suma += matriz[col-1][i];
        }
        System.out.println("La suma de la columna es igual a: "+suma);
        //sumar diagonal principal
        int diaPrin=0;
        for(int i=0;i<largo;i++)
        {
            if(i<ancho)
            {
                diaPrin+=matriz[i][i];
            }
        }
        System.out.println("La suma de la diagonal principal es de: "+diaPrin);
        //sumar diagonal Inversa
        int diaInve=0;
        int l=ancho-1;
        for(int i=0;i<largo;i++)
        {
            if(l>-1)
            {
                diaInve+=matriz[i][l];
            }
            l--;
        }
        System.out.println("La suma de la diagonal inversa es de: "+diaInve);
        //promedio matriz
        int promedio = 0;
        for(int i=0;i<largo;i++)
        {
            for(int y=0;y<ancho;y++)
            {
                promedio += matriz[i][y];
            }
        }
        System.out.println("El promedio es de: "+(promedio/(ancho*largo)));
        //Lee 10 numeros enteros y mostrar la media de los valores postitivos y la de los negativos
        int[] numeros = {10,3,7,0,0,0,-5,-7,-3,-2};
        int negativos = 0;
        int cantNegativos = 0;
        int positivos = 0;
        int cantPositivos = 0;
        for(int i=0;i<10;i++)
        {
            if(numeros[i]<0)
            {
                negativos += numeros[i];
                cantNegativos++;
            }
            else
            {
                if(numeros[i]>0)
                {
                    positivos += i;
                    cantPositivos++;
                }
            }
        }
        System.out.println("El promedio de los negativos es: "+negativos/cantNegativos);
        System.out.println("El promedio de los positivos es: "+positivos/cantPositivos);
    }
}
