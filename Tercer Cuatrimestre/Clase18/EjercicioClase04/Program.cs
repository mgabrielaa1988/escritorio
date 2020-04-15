using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 04";

            Cosa datos = new Cosa();
            Console.Write(Cosa.Mostrar(datos));

            Cosa otrosDatos = new Cosa("texto");
            Console.Write(Cosa.Mostrar(otrosDatos));

            datos.cadena = "cadena";
            datos.numero = 123456;
            datos.fecha = DateTime.Now;

            Console.Write(Cosa.Mostrar(datos));
            Console.ReadLine();
        }
    }
}
