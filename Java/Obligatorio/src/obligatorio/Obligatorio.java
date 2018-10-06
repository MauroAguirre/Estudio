/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package obligatorio;

/**
 *
 * @author Mauro,Matias
 */
import java.util.Scanner;
public class Obligatorio {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        //creamos el tablero y lo inicializamos con ceros
        //0 esta vacio, 1 es del jugador uno y 2 es del jugador dos
        int[][] tab= {{0,0,0},{0,0,0},{0,0,0}};
        //El turno de jugador uno es 1, el turno de jugador dos es 2
        //Gana jugador uno es 3,Gana jugador dos es 4
        //Enpate es 0
        int turno=2;
        //usamos esta variable para saber si juega el jugador 2 o la INTELIGENCIA ARTIFICIAL
        boolean ia;
        //pregutamos si juega la IA o dos jugadores
        System.out.println("Ingrese 1 si juega contra la pc o 2 si juegan dos jugadores");
        if(sc.nextInt()==1)
        {
            ia=true;
        }
        else
        {
            ia=false;
        }
        do
        {
            MenuRecursivo(tab,0,0);
            System.out.print("\n");
            //Menu(tab);
            turno = VerificacionRecursiva(tab,turno,0);
            //turno = Verificacion(tab,turno);
            Ingreso(tab,turno,ia);
        }while(turno==1||turno==2);
    }
    //esta funcion es para mostrar el tablero segun si es 0 ,1 ,2 va a mostrar por pantalla -, X o O
    public static void MenuRecursivo(int[][] tablero,int a,int b)
    {
        switch(tablero[a][b])
        {
            case 0:
                System.out.print("-");
                break;
            case 1:
                System.out.print("X");
                break;
            case 2:
                System.out.print("O");
                break;
        }
        if(b+1<tablero[0].length)
        {
            MenuRecursivo(tablero,a,b+1);
        }
        else
        {
            if(a+1<tablero.length)
            {
                System.out.print("\n");
                MenuRecursivo(tablero,a+1,0);
            }
        }
    }
    public static void Menu(int[][] tablero)
    {
        String[][] tab = new String[3][3];
        for(int i=0;i<3;i++)
        {
            for(int l=0;l<3;l++)
            {
                switch(tablero[i][l])
                {
                    case 0:
                        tab[i][l] = " ";
                        break;
                    case 1:
                        tab[i][l] = "X";
                        break;
                    case 2:
                        tab[i][l] = "O";
                        break;
                }
            }
        }
        System.out.println("  1   2   3");
        System.out.println(" ┏━┳━┳━┓");
        System.out.println("a┃ "+tab[0][0]+"┃"+tab[0][1]+"┃ "+tab[0][2]+"┃");
        System.out.println(" ┣━╋━╋━┫");
        System.out.println("b┃ "+tab[1][0]+"┃"+tab[1][1]+"┃ "+tab[1][2]+"┃");
        System.out.println(" ┣━╋━╋━┫");
        System.out.println("c┃ "+tab[2][0]+"┃"+tab[2][1]+"┃ "+tab[2][2]+"┃");
        System.out.println(" ┗━┻━┻━┛");
    }
    //devuelve true si hay algun lugar en el tablero que este vacio todavia, esta vacio cuando hay un 0
    public static boolean HayLugar(int[][] mat,int a,int b)
    {
        boolean hay=true;
        if(mat[a][b]==0)
        {
            hay=true;
        }
        else
        {
            if(b+1<mat[0].length)
            {
                hay = HayLugar(mat,a,b+1);
            }
            else
            {
                if(a+1<mat.length)
                {
                    System.out.print("\n");
                    hay = HayLugar(mat,a+1,0);
                }
                else
                {
                    hay = false;
                }
            }
        }
        return hay;
    }
    //probando
    public static int VerificacionRecursiva(int[][] tablero,int turno,int lugar)
    {
        //Si terminamos de verificar todo el tablero
        if(lugar==3)
        {
            //Si no hay lugar donde poner algo
            if(!HayLugar(tablero,0,0))
            {
                //empate
                return 0;
            }
            else
            {
                //terminamos de verificar el tablero y hay lugar para poner algo
                if(turno==2)
                {
                    //era el turno del jugador 2, ahora le toca al 1
                    return 1;
                }
                else
                {
                    //era el turno del jugador 1, ahora le toca al 2
                    return 2;
                }
            }
        }
        else
        {
            //verificamos horizontalmente
            if(tablero[lugar][0]==1&&tablero[lugar][1]==1&&tablero[lugar][2]==1)
            {
                return 3;
            }
            if(tablero[lugar][0]==2&&tablero[lugar][1]==2&&tablero[lugar][2]==2)
            {
                return 4;
            }
            //verificamos verticalmente
            if(tablero[0][lugar]==1&&tablero[1][lugar]==1&&tablero[2][lugar]==1)
            {
                return 3;
            }
            if(tablero[0][lugar]==2&&tablero[1][lugar]==2&&tablero[2][lugar]==2)
            {
                return 4;
            }
            //verificamos diagonales
            if(tablero[0][0]==1&&tablero[1][1]==1&&tablero[2][2]==1)
            {
                return 3;
            }
            if(tablero[0][0]==2&&tablero[1][1]==2&&tablero[2][2]==2)
            {
                return 4;
            }
            if(tablero[0][2]==1&&tablero[1][1]==1&&tablero[2][0]==1)
            {
                return 3;
            }
            if(tablero[0][2]==2&&tablero[1][1]==2&&tablero[2][0]==2)
            {
                return 4;
            }
            //Si verificamos la columna,fila y diagonal(si es que estamos en una esquina) y todavia queda tablero para verificar llamamos la funcion de nuevo
            return VerificacionRecursiva(tablero,turno,lugar+1);
        }
    }
    public static int Verificacion(int[][] tablero,int turno)
    {
        //verificar horizontal
        for(int i=0;i<3;i++)
        {
            if(tablero[i][0]==1&&tablero[i][1]==1&&tablero[i][2]==1)
            {
                return 3;
            }
            if(tablero[i][0]==2&&tablero[i][1]==2&&tablero[i][2]==2)
            {
                return 4;
            }
        }
        //verificar vertical
        for(int i=0;i<3;i++)
        {
            if(tablero[0][i]==1&&tablero[1][i]==1&&tablero[2][i]==1)
            {
                return 3;
            }
            if(tablero[0][i]==2&&tablero[1][i]==2&&tablero[2][i]==2)
            {
                return 4;
            }
        }
        //verificar diagonales
        if(tablero[0][0]==1&&tablero[1][1]==1&&tablero[2][2]==1)
        {
            return 3;
        }
        if(tablero[0][0]==2&&tablero[1][1]==2&&tablero[2][2]==2)
        {
            return 4;
        }
        if(tablero[0][2]==1&&tablero[1][1]==1&&tablero[2][0]==1)
        {
            return 3;
        }
        if(tablero[0][2]==2&&tablero[1][1]==2&&tablero[2][0]==2)
        {
            return 4;
        }
        //si estan usados todos los lugares empate
        boolean libre = false;
        for(int i=0;i<3;i++)
        {
            for(int l=0;l<3;l++)
            {
                if(tablero[i][l]==0)
                {
                    libre = true;
                }
            }
        }
        if(!libre)
        {
            return 0;
        }
        //si no pasa nada cambia el turno al otro jugador
        if(turno==1)
        {
            return 2;
        }
        return 1;
    }
    //Se genera un numero aleatorio para poner en el tablero
    public static String JuegaCompu(int[][] tablero)
    {
        String res="";
        int num;
        boolean salgo=false;
        do
        {
            num = (int)Math.floor(Math.random()*9);
            switch(num)
            {
                case 0:
                    if(tablero[0][0]==0)
                    {
                        res="a1";
                        salgo=true;
                    }
                    break;
                case 1:
                    if(tablero[0][1]==0)
                    {
                        res="a2";
                        salgo=true;
                    }
                    break;
                case 2:
                    if(tablero[0][2]==0)
                    {
                        res="a3";
                        salgo=true;
                    }
                    break;
                case 3:
                    if(tablero[1][0]==0)
                    {
                        res="b1";
                        salgo=true;
                    }
                    break;
                case 4:
                    if(tablero[1][1]==0)
                    {
                        res="b2";
                        salgo=true;
                    }
                    break;
                case 5:
                    if(tablero[1][2]==0)
                    {
                        res="b3";
                        salgo=true;
                    }
                    break;
                case 6:
                    if(tablero[2][0]==0)
                    {
                        res="c1";
                        salgo=true;
                    }
                    break;
                case 7:
                    if(tablero[2][1]==0)
                    {
                        res="c2";
                        salgo=true;
                    }
                    break;
                case 8:
                    if(tablero[2][2]==0)
                    {
                        res="c3";
                        salgo=true;
                    }
                    break;
            }
        }while(!salgo);
        return res;
    }
    //Dependiendo del turno juega el jugador 1,2,muestra que empataron, muetra que gano el jugador 1 o muetra que gano el jugador 2
    //si juega un jugador este ingresara la fila que desea escribir con a,b,c y la columna con 1,2,3   ejemplo puede ser a2, 3c, 2b, etc
    public static void Ingreso(int[][] tablero,int turno,boolean ia)
    {
        boolean correcto=false;
        Scanner sc = new Scanner(System.in);
        String lugar=null;
        switch(turno)
        {
            case 0:
                System.out.println("Empate");
                break;
            case 1:
                System.out.println("Juega el jugador 1");
                lugar = sc.next();
                break;
            case 2:
                if(ia)
                {
                    System.out.println("Ingresa la pc");
                    lugar = JuegaCompu(tablero);
                }
                else
                {
                    System.out.println("Juega el jugador 2");
                    lugar = sc.next();
                }
                break;
            case 3:
                System.out.println("Gano el jugador 1");
                break;
            case 4:
                System.out.println("Gano el jugador 2");
                break;
        }
        if(lugar!=null)
        {
            do
            {
                correcto=true;
                switch(lugar)
                {
                    case "a1":
                    case "A1":
                    case "1a":
                    case "1A":
                        if(tablero[0][0]==0)
                        {
                            tablero[0][0] = turno;
                        }
                        else
                        {
                            correcto=false;
                            System.out.println("Error ingrese denuevo");
                            lugar = sc.next();
                        }
                        break;
                    case "a2":
                    case "A2":
                    case "2a":
                    case "2A":
                        if(tablero[0][1]==0)
                        {
                            tablero[0][1] = turno;
                        }
                        else
                        {
                            correcto=false;
                            System.out.println("Error ingrese denuevo");
                            lugar = sc.next();
                        }
                        break;
                    case "a3":
                    case "A3":
                    case "3a":
                    case "3A":
                        if(tablero[0][2]==0)
                        {
                            tablero[0][2] = turno;
                        }
                        else
                        {
                            correcto=false;
                            System.out.println("Error ingrese denuevo");
                            lugar = sc.next();
                        }
                        break;
                    case "b1":
                    case "B1":
                    case "1b":
                    case "1B":
                        if(tablero[1][0]==0)
                        {
                            tablero[1][0] = turno;
                        }
                        else
                        {
                            correcto=false;
                            System.out.println("Error ingrese denuevo");
                            lugar = sc.next();
                        }
                        break;
                    case "b2":
                    case "B2":
                    case "2b":
                    case "2B":
                        if(tablero[1][1]==0)
                        {
                            tablero[1][1] = turno;
                        }
                        else
                        {
                            correcto=false;
                            System.out.println("Error ingrese denuevo");
                            lugar = sc.next();
                        }
                        break;
                    case "b3":
                    case "B3":
                    case "3b":
                    case "3B":
                        if(tablero[1][2]==0)
                        {
                            tablero[1][2] = turno;
                        }
                        else
                        {
                            correcto=false;
                            System.out.println("Error ingrese denuevo");
                            lugar = sc.next();
                        }
                        break;
                    case "c1":
                    case "C1":
                    case "1c":
                    case "1C":
                        if(tablero[2][0]==0)
                        {
                            tablero[2][0] = turno;
                        }
                        else
                        {
                            correcto=false;
                            System.out.println("Error ingrese denuevo");
                            lugar = sc.next();
                        }
                        break;
                    case "c2":
                    case "C2":
                    case "2c":
                    case "2C":
                        if(tablero[2][1]==0)
                        {
                            tablero[2][1] = turno;
                        }
                        else
                        {
                            correcto=false;
                            System.out.println("Error ingrese denuevo");
                            lugar = sc.next();
                        }
                        break;
                    case "c3":
                    case "C3":
                    case "3c":
                    case "3C":
                        if(tablero[2][2]==0)
                        {
                            tablero[2][2] = turno;
                        }
                        else
                        {
                            correcto=false;
                            System.out.println("Error ingrese denuevo");
                            lugar = sc.next();
                        }
                        break;
                    default:
                        System.out.println("Error ingrese denuevo");
                        lugar = sc.next();
                        correcto=false;
                        break;
                }
            }while(!correcto);
        }
        
    }
}
