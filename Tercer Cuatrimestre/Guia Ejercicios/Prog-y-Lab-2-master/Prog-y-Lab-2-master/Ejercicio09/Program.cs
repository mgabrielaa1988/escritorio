using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*9. Escribir un programa que imprima por pantalla una pirámide como la siguiente:
 * * 
 * *** 
 * ***** 
 * ******* 
 * ********* 
 * El usuario indicará cuál será la altura de la pirámide ingresando un número 
 * entero positivo. Para el ejemplo anterior la altura ingresada fue de 5. 
 * Nota: Utilizar estructuras repetitivas y selectivas.*/

namespace Ejercicio09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            int altura;
            int i;
            int j;
            int acumulador=0;
            string asterisco = "*";

            Console.Title = "Ejercicio 09";
            Console.Write("Ingrese la altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());

            while (altura <= 0)
            {
                Console.WriteLine("ERROR... Ingrese solo enteros positivos\nReingrese: ");
                altura = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < altura; i++)
            {
                for (j = 0; j <= 2*i; j++)
                {
                    if (i == acumulador)
                    {
                        Console.Write(asterisco);
                    }
                }
                acumulador++;
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
