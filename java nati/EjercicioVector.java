import java.util.*;
public class EjercicioVector
{
   public static void main(String [] args)
	{
      //Aca vamos a guardar el lugar donde esta el caracter si lo encontramos
      int lugar=0;
      //Declaramos una variable que es true si esta el caracter y false si no esta
      boolean esta = false;
      //Creamos el scanner que sirve para agarrar valores por la consola
      Scanner console = new Scanner(System.in);
		//Creamos un vector con caracteres
      char[] vector = {'a','e','u','b'};
      //Ingresamos un caracter por consola
      char caracter = console.next().charAt(0);
      //recorremos el vector para ver si esta el caracter que ingresamos
      for(int i=0;i<vector.length;i++)
      {
         // Aca comparamos un lugar del vector con el numero que nos ingresaron
         if(vector[i]==caracter)
         {
            //Si el lugar y el caracter son iguales igualamos la variable a true y el break sirve para salir de for mas rapido asi es mas efectivo
            lugar = i;
            esta=true;
            break;
         }
      }
      //Mostramos por pantalla si esta o no
      if(esta)
      {
         System.out.println("El caracter ingresado esta en el vector");
         System.out.println("El lugar donde esta el vector es en el indice: "+lugar);
      }
      else
      {
         System.out.println("El caracter ingresado no esta en el vector");
      }
	}
}