import java.util.Scanner;
/**
 *
 * @author mauro
 */
public class Teta {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //esto sirve para ingresar cosas por pantalla
        Scanner console = new Scanner(System.in);
        //creamos un arreglo de un tamaño de 10
        int[] numeros=new int[10];
        //el for sirve para recorrer cosas
        for(int i=0;i<10;i++)
        {
         //ingresamos un numero por pantalla y lo metemos en el lugar i de numeros
            numeros[i] = console.nextInt();
            //le sumamos 5 al numero
            numeros[i] = numeros[i]+5;
        }
        //Usamos el for para recorrer el arreglo
        for(int i=0;i<10;i++)
        {
            //Mostramos por pantalla el lugar del arreglo
            System.out.print(numeros[i]+" ");
        }
        //saltamos la linea ;(
        System.out.print("\n");
        //creamos una variable boolean para almacenar si es o no es palindromo
        boolean Es_Palindromo=true;
        System.out.println("Ingresame una palabra");
        //creamos un arreglo de char de tamaño 15 ;(((
        char[] letras= new char[15];
        //creamos un contador para contar que tan grande es la palabra y saber en que lugar poner la letra
        int contador=0;
        //Creamos una variable char para almacenar la palabra que nos van a ingresar por pantalla.
        char letra;
        //ingresamos una letra por pantalla y la guardamos en letra
        letra = console.next().charAt(0);
        //hacemos lo que esta aca dentro mientras letra no sea igual a .
        while(letra!='.')
        {
            //ingresamos la letra en letras en el lugar contador
            letras[contador] = letra;
            //sumamos uno al contador
            contador++;
            //pedimos por pantalla otra letra
            letra=console.next().charAt(0);
        }
        //usamos este for para recorrer letras
        for(int i=0;i<contador/2;i++)
        {
            //verificamos si las posiciones no son iguales
            if(letras[i]!=letras[contador-1-i])
            {
                //si no son iguales ponemos false
                Es_Palindromo = false;
            }
        }
        //verificamos si Es_Palindromo es true o false
        if(Es_Palindromo==true)
        {
            System.out.println("La palabra es palindromo");
        }
        else
        {
            System.out.println("La palabra no es palindromo");
        }
        //creamos una variable para guardar cuantas vocales hay, empieza en cero.
        int vocales=0;
        //recorremos las letras.
        for(int i=0;i<contador;i++)
        {
            //si el lugar donde estamos bichando es una vocal entonces sumamos 1 a vocales.
            if(letras[i]=='a'||letras[i]=='e'||letras[i]=='i'||
                    letras[i]=='o'||letras[i]=='u')
            {
                vocales=vocales+1;
            }
        }
        System.out.println("Hay "+vocales+" vocales");
        
        
        /*
        System.out.println("Ingresame un palabra");
        String palabra = console.next();
        System.out.println(palabra);
        //anana
        //dasdas
        for(int i=0;i<palabra.length()/2;i++)
        {
            if(palabra.charAt(i)!=palabra.charAt(palabra.length()-1-i))
            {
                Es_Palindromo = false;
            }
        }
        if(Es_Palindromo==true)
        {
            System.out.println("La palabra es palindromo");
        }
        else
        {
            System.out.println("La palabra no es palindromo");
        }
        int vocales=0;
        for(int i=0;i<palabra.length();i++)
        {
            if(palabra.charAt(i)=='a'||palabra.charAt(i)=='e'||
                    palabra.charAt(i)=='i'||
                    palabra.charAt(i)=='o'||palabra.charAt(i)=='u')
            {
                vocales=vocales+1;
            }
        }
        System.out.println("Hay "+vocales+" vocales");
        */
    }
    
}