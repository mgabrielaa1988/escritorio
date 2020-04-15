using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos)
 * que realicen el cálculo del área que corresponda:  a. double CalcularCuadrado(double)
 * b. double CalcularTriangulo(double, double) c. double CalcularCirculo(double) 
 * El ingreso de los datos como la visualización se deberán realizar desde el método Main(). */

namespace Ejercicio14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            double numero=4;
            double cuadrado;
            double baseT=4;
            double alturaT=3;
            double aTriangulo;
            double radio=5;
            double aCirculo;
            Console.Title = "Ejercicio 14";
            cuadrado = CalculoDeArea.CalcularCuadrado(numero);
            Console.WriteLine("Calculo de Cuadrado de un numero");
            Console.WriteLine(" Numero: {0}   Cuadrado: {1}",numero,cuadrado);
            aTriangulo = CalculoDeArea.CalcularTriangulo(baseT, alturaT);
            Console.WriteLine("\nCalculo del Area de un Triangulo");
            Console.WriteLine("   Base: {0}     Altura: {1}      Area: {2}", baseT, alturaT, aTriangulo);
            aCirculo = CalculoDeArea.CalcularCirculo(radio);
            Console.WriteLine("\nCalculo del Area de un Circulo");
            Console.WriteLine("  Radio: {0}       Area: {1:#.##}", radio, aCirculo);
            Console.ReadLine();
        }
    }
}
