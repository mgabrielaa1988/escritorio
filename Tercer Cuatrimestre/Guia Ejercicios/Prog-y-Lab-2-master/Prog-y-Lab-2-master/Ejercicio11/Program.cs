using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*11. Ingresar 10 números enteros que pueden estar dentro de un rango de entre
 * -100 y 100. Para ello realizar una clase llamada Validacion que posea un método
 * estático llamado Validar, que posea la siguiente firma: bool Validar(int valor, 
 * int min, int max): a. valor: dato a validar b. min y max: rango en el cual 
 * deberá estar la variable valor.  
 * Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
 * Nota: Utilizar variables escalares, NO utilizar vectores. */

namespace Ejercicio11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo=0;
            int maximo=0;
            int acumulador=0;
            float promedio;
            bool flag=true;
            bool validar;

            Console.Title = "Ejercicio 11";

            Console.WriteLine("Ingrese 10 numeros: ");
            for(int i = 0; i < 10; i++)
            {
                Console.Write("{0}: ", i+1);
                numero = int.Parse(Console.ReadLine());
                validar = Validacion.Validar(numero, -100, 100);
                while (!validar)
                {
                    Console.Write("ERROR... Solo puede ingresar valores en -100 y 100\nReingrese. {0}: ",i+1);
                    numero = int.Parse(Console.ReadLine());
                    validar = Validacion.Validar(numero, -100, 100);
                }
                acumulador = acumulador + numero;
                if (flag)
                {
                    minimo = numero;
                    maximo = numero;
                    flag = false;
                }
                else
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                }
            }
            promedio = acumulador / 10f;
            Console.WriteLine("Valor minimo: {0} - Valor maximo: {1} - Promedio: {2}",minimo,maximo,promedio);
            Console.ReadLine();
        }
    }
}
