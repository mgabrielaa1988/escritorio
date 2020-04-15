using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*19. Realizar una aplicación de consola. Agregar la clase Sumador.  
a. Crear dos constructores: i. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros. 
ii. Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
i. En el caso de Sumar(long, long) sumará los valores numéricos 
ii. En el de Sumar(string, string) concatenará las cadenas de texto. Antes de continuar, agregar un objeto
del tipo Sumador en el Main y probar el código. 
c. Generar una conversión explícita que retorne cantidadSumas. 
d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long con dicho valor. 
e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual cantidadSumas. 
Agregar un segundo objeto del tipo Sumador en el Main y probar el código. */

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";

            Sumador sumador1 = new Sumador();
            string retorno1 = sumador1.Sumar("a", "b");
            Sumador sumador2 = new Sumador(2);
            long retorno2 = sumador2.Sumar(2, 1);

            Console.WriteLine("Suma 1:{0}\tSuma 2:{1}", retorno1, retorno2.ToString());
            Console.ReadLine();

            Sumador sumador3 = new Sumador(2);
            long retorno3 = 2 + sumador3;
            bool retorno4 = sumador2 | sumador3;

            Console.WriteLine("Suma 3: " + retorno3.ToString());
            Console.WriteLine("Son iguales sumador 2 y sumador 3? " + retorno4.ToString());
            Console.ReadLine();
        }
    }
}
