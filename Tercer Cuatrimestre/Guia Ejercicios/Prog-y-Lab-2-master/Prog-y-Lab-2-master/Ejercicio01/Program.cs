using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
valor máximo, el valor mínimo y el promedio*/

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";

            #region Atributos
            int numero;
            int i;
            int cantidad = 5;
            int max=0;
            int min=0;
            int acumulador = 0;
            float promedio;
            #endregion

            #region Calculo
            for (i=0;i<cantidad;i++){
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                acumulador = acumulador + numero;
                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else
                {
                    if (numero > max)
                    {
                        max = numero;
                    }
                    else if (numero < min)
                    {
                        min = numero;
                    }
                }
            }
            #endregion

            promedio = ((float)acumulador / cantidad);
            Console.WriteLine("Minimo: {0} Maximo: {1} Promedio: {2:0.00}", min, max, promedio);
            Console.ReadLine();
        }
    }
}
