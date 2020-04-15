using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5. Un centro numérico es un número que separa una lista de números enteros 
 * (comenzando en 1) en dos grupos de números, cuyas sumas son iguales. 
 * El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los 
 * grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
 * El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los 
 * grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595. 
 * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número
 * que el usuario ingrese por consola. Nota: Utilizar estructuras repetitivas y selectivas.*/

namespace Ejercicio05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {
            int numero;
            int centro=1;
            int acumulador1;
            int acumulador2;
            int i;
            int j;

            Console.Title = "Ejercicio 05";
            Console.WriteLine("Ingrese el numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Centro numerico: ");

            while (centro < numero)
            {
                centro++;
                acumulador1 = 0;
                acumulador2 = 0;
                for (i = 1; i < centro; i++)
                {
                    acumulador1 = acumulador1 + i;
                }
                for (j = centro + 1; j <= acumulador1; j++)
                {
                    if (acumulador1 == acumulador2 || acumulador1 < acumulador2)
                    {
                        break;
                    }
                    acumulador2 = acumulador2 + j;
                }
                if (acumulador1 == acumulador2)
                {
                    Console.Write(" - " + centro);
                }
            }
            Console.ReadLine();
        }
    }
}
