using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimentando
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] notas = { "E2", "E2", "F2", "G2", "G2", "F2", "E2", "D2" , "C2" , "C2" ,"D2" };
            string[] tiempos = { "2", "2", "2", "2", "2", "2", "2", "2","2","2","1" };
            Cancion(1000,notas,tiempos);
            Console.ReadKey();
        }
        static void Cancion(int tiempoBase, string[] notas,string[] tiempos)
        {
            int dividir = 1;
            int frecuencia = 130;
            string nota;
            string nivel;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i].Length == 2)
                {
                    nota = notas[i].Substring(0, 1);
                    nivel = notas[i].Substring(1, 1);
                }
                else
                {
                    nota = notas[i].Substring(0, 2);
                    nivel = notas[i].Substring(2, 1);
                }
                switch (nota)
                {
                    case "C":
                        frecuencia = 65;
                        break;
                    case "C#":
                        frecuencia = 69;
                        break;
                    case "D":
                        frecuencia = 73;
                        break;
                    case "D#":
                        frecuencia = 77;
                        break;
                    case "E":
                        frecuencia = 82;
                        break;
                    case "F":
                        frecuencia = 87;
                        break;
                    case "F#":
                        frecuencia = 92;
                        break;
                    case "G":
                        frecuencia = 98;
                        break;
                    case "G#":
                        frecuencia = 103;
                        break;
                    case "A":
                        frecuencia = 110;
                        break;
                    case "A#":
                        frecuencia = 116;
                        break;
                    case "B":
                        frecuencia = 123;
                        break;
                }
                switch (nivel)
                {
                    case "1":
                        frecuencia *= 1;
                        break;
                    case "2":
                        frecuencia *= 2;
                        break;
                    case "3":
                        frecuencia *= 4;
                        break;
                    case "4":
                        frecuencia *= 8;
                        break;
                }
                switch (nivel)
                {
                    case "1":
                        frecuencia *= 1;
                        break;
                    case "2":
                        frecuencia *= 2;
                        break;
                    case "3":
                        frecuencia *= 4;
                        break;
                    case "4":
                        frecuencia *= 8;
                        break;
                }
                switch (tiempos[i])
                {
                    case "1":
                        dividir = 1;
                        break;
                    case "2":
                        dividir = 2;
                        break;
                    case "3":
                        dividir = 3;
                        break;
                    case "4":
                        dividir = 4;
                        break;
                }
                Console.Beep(frecuencia, tiempoBase / dividir);
            }
        }
    }
}
