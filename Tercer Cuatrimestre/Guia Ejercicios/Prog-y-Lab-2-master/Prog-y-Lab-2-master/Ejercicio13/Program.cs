using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase 
 * (estáticos):string DecimalBinario(double). Convierte un número de decimal a binario. 
 * double BinarioDecimal(string). Convierte un número binario a decimal. */

namespace Ejercicio13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            double decimal1;
            double decimal2;
            string nroBinario1;
            string nroBinario2;

            Console.Title = "Ejercicio 13";
            decimal1 = 123;
            nroBinario1=Conversor.DecimalBinario(decimal1);
            Console.WriteLine("El numero decimal es: {0}\tSu equivalente en binario es: {1}", decimal1, nroBinario1);
            Console.ReadLine();

            nroBinario2="11101101";
            decimal2 = Conversor.BinarioDecimal(nroBinario2);
            Console.WriteLine("El numero binario es: {0}\tSu equivalente en decimal es: {1}", nroBinario2, decimal2);
            Console.ReadLine();
        }
    }
}
