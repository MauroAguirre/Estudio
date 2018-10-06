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
import java.util.Scanner;
public class Practicos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        int eleccion,num1,num2,num3;
        String respuesta;
        MenuPrincipal();
        eleccion = reader.nextInt();
        switch(eleccion)
        {
            case 1:
                MenuPractico1();
                eleccion = reader.nextInt();
                switch(eleccion)
                {
                    case 1:
                        Practico1.Ejercicio1();
                        break;
                    case 2:
                        System.out.println("Ingrese un numero");
                        num1 = reader.nextInt();
                        System.out.println("Ingrese otro numero");
                        num2 = reader.nextInt();
                        Practico1.Ejercicio2(num1, num2);
                        break;
                    case 3:
                        System.out.println("Ingrese un numero para separar");
                        num1 = reader.nextInt();
                        Practico1.Ejercicio3(num1);
                        break;
                    case 4:
                        System.out.println("Ingrese un numero");
                        num1 = reader.nextInt();
                        System.out.println("Ingrese otro numero");
                        num2 = reader.nextInt();
                        Practico1.Ejercicio4(num1, num2);
                        break;
                    case 5:
                        System.out.println("Ingrese un lado del triangulo");
                        num1 = reader.nextInt();
                        System.out.println("Ingrese otro lado del triangulo");
                        num2 = reader.nextInt();
                        System.out.println("Ingrese el ultimo lado del triangulo");
                        num3 = reader.nextInt();
                        Triangulo triangulo = new Triangulo(num1,num2,num3);
                        if(triangulo.EsEquilatero())
                        {
                            System.out.println("El triangulo es equilatero");
                        }
                        else
                        {
                            if(triangulo.EsEscaleno())
                            {
                                System.out.println("El triangulo es escaleno");
                            }
                            else
                            {
                                if(triangulo.EsIsosceles())
                                    System.out.println("El triangulo es isoceles");
                                else
                                {
                                    System.out.println("Si esta es tu respuesta en algo la cagaste");
                                }
                            }
                        }
                        if(triangulo.TieneAnguloRecto())
                        {
                            System.out.println("El triangulo tiene angulo recto");
                        }
                        else
                        {
                            System.out.println("El triangulo no tiene angulo recto");
                        }
                    case 6:
                        System.out.println("Ingrese el nombre del socio");
                        respuesta = reader.next();
                        Socio socio1 = new Socio(respuesta);
                        System.out.println("Ingrese el nombre de otro socio");
                        Socio socio2 = new Socio(reader.next());
                        System.out.println("Modifique el nombre del primer socio");
                        socio1.Modificar_nombre(reader.next());
                        System.out.println(socio1.Mostrar());
                        System.out.println(socio2.Mostrar());
                        break;
                    case 7:
                        Funcionario fun1;
                        Funcionario fun2;
                        System.out.println("Ingrese el nombre de un funcionario");
                        respuesta = reader.next();
                        System.out.println("Ingrese el sueldo de un funcionario");
                        num1 = reader.nextInt();
                        fun1 = new Funcionario(respuesta,num1);
                        System.out.println("Ingrese el nombre de otro un funcionario");
                        respuesta = reader.next();
                        System.out.println("Ingrese el sueldo de el otro funcionario");
                        num1 = reader.nextInt();
                        fun2 = new Funcionario(respuesta,num1);
                        System.out.println(fun1.Mostrar());
                        System.out.println(fun2.Mostrar());
                        if(fun1.Sueldo()>fun2.Sueldo())
                        {
                            System.out.println("El funcionario 1 gana mas sueldo");
                        }
                        else
                        {
                            if(fun1.Sueldo()<fun2.Sueldo())
                            {
                                System.out.println("El funcionario 2 gana mas sueldo");
                            }
                            else
                            {
                                System.out.println("Los dos funcionarios ganan el mismo sueldo");
                            }
                        }
                }
                break;
            case 2:
                MenuPractico2();
                eleccion = reader.nextInt();
                switch(eleccion)
                {
                    case 1:
                        System.out.println("Ingrese un numero natural");
                        if(Practico2.Ejercicio1(reader.nextInt()))
                        {
                            System.out.println("El numero es primo");
                        }
                        else
                        {
                            System.out.println("El numero no es primo");
                        }
                        break;
                    case 2:
                        System.out.println("Ingrese un numero natural");
                        num1 = Practico2.Ejercicio2(reader.nextInt());
                        System.out.println(String.valueOf(num1));
                        break;
                    case 3:
                        System.out.println("Ingrese un numero a restar");
                        num1 = reader.nextInt();
                        System.out.println("Ingrese por que numero lo va a restar");
                        num2 = reader.nextInt();
                        int[] resultado = Practico2.Ejercicio3(num1, num2);
                        System.out.println("El cociente es: "+resultado[0]+" y el resto es: "+resultado[1]);
                        break;
                    case 4:
                    case 5:
                        System.out.println("Ingrese un numero");
                        num1 = reader.nextInt();
                        System.out.println("Ingrese otro numero");
                        num2 = reader.nextInt();
                        System.out.println("El maximo comun divisor es: "+ Practico2.Ejercicio4(num1, num2));
                        break;
                    case 6:
                        System.out.println("Ingrese un numero para ver si es capicua");
                        num1 = reader.nextInt();
                        if(Practico2.Ejercicio6(num1))
                        {
                            System.out.println("El numero es capicua");
                        }
                        else
                        {
                            System.out.println("El numero no es capicua");
                        }
                    case 7:
                        Practico2.Ejercicio7();
                        break;
                    case 8:
                        int[] arreglo = {3,6,1};
                        System.out.println(Practico2.Ejercicio8a(arreglo, 2, 6));
                        System.out.println(Practico2.Ejercicio8b(arreglo, 2, 6));
                        break;
                    case 9:
                        int[][] matriz = {{2,3,7},{3,6,4},{4,8,6}};
                        int[] arreglo2 = {3,6,1,5,3};
                        Practico2.Ejercicio9(arreglo2,5);
                        break;
                    case 10:
                        int[] arreglo3 = {3,6,1,5,3};
                        System.out.println("El promedio es: "+Practico2.Ejercicio10a(arreglo3,5));
                        System.out.println("El minimo es: "+Practico2.Ejercicio10b(arreglo3, 5)[0]);
                        System.out.println("El aparecio "+Practico2.Ejercicio10b(arreglo3, 5)[1]+" veces");
                        System.out.println("Esta en la posicion: "+Practico2.Ejercicio10b(arreglo3, 5)[2]);
                        break;
                    case 11:
                        int[] arreglo4 = {6,4,8};
                        int[] arreglo5 = {9,5};
                        Practico2.Ejercicio11(arreglo4, arreglo5, 3, 2);
                        break;
                    case 12:
                        int[] arreglo6 = {6,4,8,1,66,5,33,22,55,11,23};
                        Practico2.Ejercicio12(arreglo6);
                        break;
                }
                break;
            case 3:
                MenuPractico3();
                eleccion = reader.nextInt();
                switch(eleccion)
                {
                    case 1:
                        Practico3.Ejercicio1b();  
                        break;
                    case 2:
                        Practico3.Ejercicio2();
                        break;
                    case 3:
                        Practico3.Ejercicio3();
                        break;
                    case 4:
                        Practico3.Ejercicio4();
                        break;
                }
                break;
            case 4:
                MenuPractico4();
                eleccion = reader.nextInt();
                switch(eleccion)
                {
                    case 1:
                        System.out.println(Practico4.Ejercicio1(5));
                        break;
                    case 2:
                        System.out.println(Practico4.Ejercicio2(12));
                        break;
                    case 3:
                        Practico4.Ejercicio3a(100);
                        System.out.println();
                        Practico4.Ejercicio3b(100);
                        break;
                    case 4:
                        int[] n = {111,99,13,555,8,33,2};
                        System.out.println(Practico4.Ejercicio4_minimo(n,6));
                        System.out.println(Practico4.Ejercicio4_posmax(n,6));
                        Practico4.Ejercicio4_ordenar(n, 6);
                        for(int i=0;i<7;i++)
                        {
                            System.out.print(n[i]+" ");
                        }
                        break;
                    case 5:
                        System.out.println(Practico4.Ejercicio5(2,5));
                        System.out.println(Practico4.Ejercicio5(2,-5));
                        break;
                    case 6:
                        System.out.println(Practico4.mcd(12,15));
                        if(Practico4.Ejercicio6(12,15))
                        {
                            System.out.println("Son primos");
                        }
                        else
                        {
                            System.out.println("No son primos");
                        }
                        break;
                    case 7:
                        System.out.println("1-"+Practico4.Ejercicio7(1));
                        System.out.println("2-"+Practico4.Ejercicio7(2));
                        System.out.println("3-"+Practico4.Ejercicio7(3));
                        System.out.println("4-"+Practico4.Ejercicio7(4));
                        System.out.println("5-"+Practico4.Ejercicio7(5));
                        System.out.println("6-"+Practico4.Ejercicio7(6));
                        System.out.println("7-"+Practico4.Ejercicio7(7));
                        System.out.println("8-"+Practico4.Ejercicio7(8));
                        System.out.println("9-"+Practico4.Ejercicio7(9));
                        break;
                    case 8:
                        System.out.println("1-1: "+Practico4.Ejercicio8(1,1));
                        System.out.println("1-2: "+Practico4.Ejercicio8(1,2));
                        System.out.println("1-3: "+Practico4.Ejercicio8(1,3));
                        System.out.println("1-4: "+Practico4.Ejercicio8(1,4));
                        System.out.println("1-5: "+Practico4.Ejercicio8(1,5));
                        System.out.println("2-1: "+Practico4.Ejercicio8(2,1));
                        System.out.println("2-2: "+Practico4.Ejercicio8(2,2));
                        System.out.println("2-3: "+Practico4.Ejercicio8(2,3));
                        System.out.println("2-4: "+Practico4.Ejercicio8(2,4));
                        System.out.println("2-5: "+Practico4.Ejercicio8(2,5));
                        System.out.println("3-1: "+Practico4.Ejercicio8(3,1));
                        System.out.println("3-2: "+Practico4.Ejercicio8(3,2));
                        System.out.println("3-3: "+Practico4.Ejercicio8(3,3));
                        System.out.println("4-3: "+Practico4.Ejercicio8(4,3));
                        break;
                    case 9:
                        int[] arrrr = {1,3,5,7,9,11,13,15};
                        if(Practico4.Ejercicio9(0, 7,13,arrrr))
                        {
                            System.out.println("true");
                        }
                        else
                        {
                            System.out.println("false");
                        }
                        break;
                    case 11:
                        int[][] mapa={{1,1,1,1},{1,0,0,0},{0,0,0,1},{1,0,1,1}};
                        for(int i=0;i<mapa.length;i++)
                        {
                            for(int l=0;l<mapa[0].length;l++)
                            {
                                System.out.print(mapa[i][l]+" ");
                            }
                            System.out.println();
                        }
                        System.out.println();
                        Practico4.Ejercicio11(mapa, 0, 0,0);
                        for(int i=0;i<mapa.length;i++)
                        {
                            for(int l=0;l<mapa[0].length;l++)
                            {
                                System.out.print(mapa[i][l]+" ");
                            }
                            System.out.println();
                        }
                        break;
                    case 12:
                        int[] vectorr = {6,2,12,7,88,3,1};
                        System.out.println("El numero mas chiquito es: "+Practico4.Ejercicio12(vectorr, 0, 7)[0]);
                        System.out.println("El numero mas grande es: "+Practico4.Ejercicio12(vectorr, 0, 7)[1]);
                        break;
                }  
                break;
            default:
                break;
        }
    }
    public static void MenuPrincipal()
    {
        System.out.println("    Menu");
        System.out.println("");
        System.out.println("1-Practico 1");
        System.out.println("2-Pracitco 2");
        System.out.println("3-Practico 3");
        System.out.println("4-Practico 4");
        System.out.println("Seleccione un practico");
    }
    public static void MenuPractico1()
    {
        System.out.println("    Practico 1");
        System.out.println("");
        System.out.println("1-Ejercicio 1");
        System.out.println("2-Ejercicio 2");
        System.out.println("3-Ejercicio 3");
        System.out.println("4-Ejercicio 4");
        System.out.println("5-Ejercicio 5");
        System.out.println("6-Ejercicio 6");
        System.out.println("7-Ejercicio 7");
        System.out.println("Seleccione un ejercicio");
    }
    public static void MenuPractico2()
    {
        System.out.println("    Practico 2");
        System.out.println("");
        System.out.println("1-Ejercicio 1");
        System.out.println("2-Ejercicio 2");
        System.out.println("3-Ejercicio 3");
        System.out.println("4-Ejercicio 4");
        System.out.println("5-Ejercicio 5");
        System.out.println("6-Ejercicio 6");
        System.out.println("7-Ejercicio 7");
        System.out.println("8-Ejercicio 8");
        System.out.println("9-Ejercicio 9");
        System.out.println("10-Ejercicio 10");
        System.out.println("11-Ejercicio 11");
        System.out.println("12-Ejercicio 12");
        System.out.println("Seleccione un ejercicio");
    }
    public static void MenuPractico3()
    {
        System.out.println("    Practico 3");
        System.out.println("");
        System.out.println("1-Ejercicio 1");
        System.out.println("2-Ejercicio 2");
        System.out.println("3-Ejercicio 3");
        System.out.println("4-Ejercicio 4");
        System.out.println("Seleccione un ejercicio");
    }
    public static void MenuPractico4()
    {
        System.out.println("    Practico 4");
        System.out.println("");
        System.out.println("1-Ejercicio 1");
        System.out.println("2-Ejercicio 2");
        System.out.println("3-Ejercicio 3");
        System.out.println("4-Ejercicio 4");
        System.out.println("4-Ejercicio 5");
        System.out.println("4-Ejercicio 6");
        System.out.println("4-Ejercicio 7");
        System.out.println("4-Ejercicio 8");
        System.out.println("4-Ejercicio 9");
        System.out.println("4-Ejercicio 10");
        System.out.println("4-Ejercicio 11");
        System.out.println("4-Ejercicio 12");
        System.out.println("Seleccione un ejercicio");
    }
}
