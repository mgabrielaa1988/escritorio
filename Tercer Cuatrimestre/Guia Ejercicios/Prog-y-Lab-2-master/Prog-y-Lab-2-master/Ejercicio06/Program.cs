using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*6. Escribir un programa que determine si un año es bisiesto. 
 * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos,
 * salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto
 * pero 1900 no. Pedirle al usuario un año de inicio y otro de fin y mostrar todos los
 * años bisiestos en ese rango. Nota: Utilizar estructuras repetitivas, selectivas 
 * y la función módulo (%). */

namespace Ejercicio06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            int inicio;
            int fin;
            int i;

            Console.Title = "Ejercicio 06";
            Console.Write("Ingrese año de inicio: ");
            inicio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese año de finalizacion: ");
            fin = int.Parse(Console.ReadLine());
            Console.WriteLine("\nAños bisiestos:");

            for (i = inicio; i <= fin; i++)
            {
                //if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                if(DateTime.IsLeapYear(i))
                {
                    Console.Write("- {0} -", i);
                }
            }

            Console.ReadLine();
        }
    }
}
