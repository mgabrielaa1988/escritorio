using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*15. Realizar un programa que permita realizar operaciones matemáticas simples
 * (suma, resta, multiplicación y división). Para ello se le debe pedir al usuario que
 * ingrese dos números y la operación que desea realizar (pulsando el caracter +, -, * ó /).
 * El usuario decidirá cuándo finalizar el programa. Crear una clase llamada Calculadora 
 * que posea tres métodos estáticos (de clase): a. Calcular (público): Recibirá tres parámetros, 
 * el primer número, el segundo número y la operación matemática. El método devolverá el resultado
 * de la operación. b. Validar (privado): Recibirá como parámetro el segundo número. 
 * Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
 * Este método devolverá TRUE si el número es distinto de CERO. c. Mostrar (público): Este método
 * recibe como parámetro el resultado de la operación y lo muestra por pantalla. No posee valor de retorno. */

namespace Ejercicio15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            string caracter;
            string continuar = "s";

            Console.Title = "Ejercicio 15";
            Console.WriteLine(" - - - Calculadora - - - ");
            while (continuar == "s" || continuar == "S")
            {
                Console.Write(" Ingrese el primer numero: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el caracter de la operacion quiere realizar:");
                Console.Write("SUMA:(+)  RESTA:(-)  MULTIPLICACION:(*)  DIVISION:(/)   ");
                caracter = Console.ReadLine();
                resultado = Calculadora.Calcular(numero1, numero2, caracter);
                Calculadora.Mostrar(resultado);
                Console.Write("Desea continuar: S/N     ");
                continuar = Console.ReadLine();
            } 
        }
    }
}
