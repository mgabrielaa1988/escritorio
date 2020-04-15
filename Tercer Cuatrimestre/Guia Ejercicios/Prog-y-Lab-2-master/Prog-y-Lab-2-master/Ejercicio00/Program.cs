using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio00
{
    class Ejercicio00
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 00";
            /*string nombre = Console.ReadLine();
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre: {0:10} Edad: {1}",nombre,edad);
            Console.WriteLine(edad);
            Console.Write("Hola Mundo");
            Console.ReadLine();*/

            Sello.mensaje = "Gaby";
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
            //Sello.Borrar();
            //Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
            Sello.mensaje = "otro mensaje";
            Sello.color = ConsoleColor.DarkMagenta;
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
            Sello.ImprimirEnColor();
            Sello.mensaje = "Gaby";
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
        }
    }
}
