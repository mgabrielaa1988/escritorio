using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2. Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/

namespace Ejercicio02
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio02";
            int numero;
            int cuadrado;
            int cubo;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
        }
    }
}
