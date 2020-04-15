using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*10. Partiendo de la base del ejercicio anterior, se pide realizar un programa
 * que imprima por pantalla una pirámide como la siguiente: 
 *     * 
 *    ***
 *   ***** 
 *  ******* 
 * ********* 
Nota: Utilizar estructuras repetitivas y selectivas.*/

namespace Ejercicio10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            int altura;
            int i;
            int j;
            int acumulador = 0;
            string asterisco = "*";

            Console.Title = "Ejercicio 10";
            Console.Write("Ingrese la altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());

            while (altura <= 0)
            {
                Console.WriteLine("ERROR... Ingrese solo enteros positivos\nReingrese: ");
                altura = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < altura; i++)
            {
                for ( j = 1; j <= altura - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= 2 * i; j++)
                {
                    Console.Write(asterisco); 
                }
                acumulador++;
                Console.Write("\n");
            }
            Console.ReadLine();
        }


    }
}
