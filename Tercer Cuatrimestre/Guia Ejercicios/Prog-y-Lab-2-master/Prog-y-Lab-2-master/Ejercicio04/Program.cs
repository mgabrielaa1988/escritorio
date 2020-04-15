using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*4. Un número perfecto es un entero positivo, que es igual a la suma de
 * todos los enteros positivos (excluido el mismo) que son divisores del número. 
 * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. 
 * Escribir una aplicación que encuentre los 4 primeros números perfectos. 
 * Nota: Utilizar estructuras repetitivas y selectivas.*/

namespace Ejercicio04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";
            long perfecto;
            long contador;
            long i=1;
            long j;
            int maximos = 0;

            while (true)
            {
                contador = 0;
                i++;
                for (j = 1; j <= i-1; j++)
                {
                    if (i % j == 0)
                    {
                        contador = contador + j;
                    }
                }
                if (contador == i)
                {
                    perfecto = i;
                    maximos++;
                    Console.WriteLine("Numero Perfecto: " + perfecto);
                }
                if (maximos == 4)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
