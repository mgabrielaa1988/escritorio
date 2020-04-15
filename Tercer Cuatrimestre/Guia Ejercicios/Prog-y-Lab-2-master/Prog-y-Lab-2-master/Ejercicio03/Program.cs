using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3. Mostrar por pantalla todos los números primos que haya hasta el número
 * que ingrese el usuario por consola. Nota: Utilizar estructuras repetitivas,
 * selectivas y la función módulo (%).*/

namespace Ejercicio03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio03";
            int numero;
            int i;
            int j;
            int contador=0;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero <= 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número mayor a 1!");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numeros primos: ");

            for (i = 2; i <= numero; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador = contador + 1;
                    }
                }
                if (contador < 3)
                {
                    Console.Write("{0}, ", i);
                }
                contador = 0;
            }
            Console.ReadLine();
        }
    }
}
