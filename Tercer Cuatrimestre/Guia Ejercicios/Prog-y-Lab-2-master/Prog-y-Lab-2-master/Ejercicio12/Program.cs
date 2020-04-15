using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*12. Realizar un programa que sume números enteros hasta que el usuario lo determine, 
 * por medio de un mensaje "¿Continuar? (S/N)". En el método estático ValidaS_N(char c)
 * de la clase ValidarRespuesta, se validará el ingreso de opciones.
 * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE 
 * si se ingresó cualquier otro valor. */

namespace Ejercicio12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int suma;
            int sumaTotal=0;
            string continuar="S";

            Console.Title = "Ejercicio 12";

            while (ValidarRespuesta.ValidarS_N(continuar))
            {
                Console.Write("        Ingrese un numero el primer numero: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.Write("                 Ingrese el segundo numero: ");
                numero2 = int.Parse(Console.ReadLine());
                suma = numero1 + numero2;
                sumaTotal = sumaTotal + suma;
                Console.WriteLine("               La suma es de los 2 numeros: " + suma);
                Console.WriteLine("La suma total de los numeros ingresados es: "+sumaTotal);
                Console.Write("            Desea sumar otros numeros? S/N  ");
                continuar = Console.ReadLine();
                Console.Write("\n");
            }
        }
    }
}
