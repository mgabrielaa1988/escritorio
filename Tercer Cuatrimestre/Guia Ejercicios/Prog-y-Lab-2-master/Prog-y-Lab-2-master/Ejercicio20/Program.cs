using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

/*20. Generar un nuevo proyecto del tipo Console Application. Construir tres clases dentro de un
 * namespace llamado Billetes: Pesos, Euro y Dolar. 
 * a. Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí 
 * con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 
 * 1,3642 dólares y 1 dólar equivale a 17,55 pesos.
 * b. El atributo cotizRespectoDolar y el método GetCotizacion son estáticos. 
 * c. Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos
 * tipos de datos. d. Colocar dentro del Main el código necesario para probar todos los métodos.
 * e. Los constructores privados le darán una cotización respecto del dólar por defecto a las clases.
 * f. Los comparadores == compararan cantidades. 
 * g. Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido. 
 * Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.
 * h. Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso. */

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";

            Euro euro1 = new Euro(1);
            Euro euro2 = new Euro(1);
            Dolar dolar1 = new Dolar(1.3642);
            Dolar dolar2 = new Dolar(1.3642);
            Dolar dolar3 = new Dolar(1);
            Pesos peso1 = new Pesos(17.55);
            Pesos peso2 = new Pesos(17.55);

            Console.WriteLine("Cantidades: ");
            Console.WriteLine("Dolar 1: " + dolar1.GetCantidad());
            Console.WriteLine("Euro 1: " + euro1.GetCantidad());
            Console.WriteLine("Peso 1: " + peso1.GetCantidad());

            Console.WriteLine("\nSumar-Restar Dolar y Euro");
            dolar1 += euro1;
            Console.WriteLine(dolar1.GetCantidad());
            dolar1 -= euro1;
            Console.WriteLine(dolar1.GetCantidad());

            Console.WriteLine("\nSumar-Restar Dolar y Peso");
            dolar1 += peso1;
            Console.WriteLine(dolar1.GetCantidad());
            dolar1 -= peso1;
            Console.WriteLine(dolar1.GetCantidad());

            Console.WriteLine("\nSumar-Restar Euro y Dolar");
            euro1 += dolar1;
            Console.WriteLine(euro1.GetCantidad());
            euro1 -= dolar1;
            Console.WriteLine(euro1.GetCantidad());

            Console.WriteLine("\nSumar-Restar Euro y Peso");
            euro1 += peso1;
            Console.WriteLine(euro1.GetCantidad());
            euro1 -= peso1;
            Console.WriteLine(euro1.GetCantidad());

            Console.WriteLine("\nSumar-Restar Peso y Euro");
            peso1 += euro1;
            Console.WriteLine(peso1.GetCantidad());
            peso1 -= euro1;
            Console.WriteLine(peso1.GetCantidad());

            Console.WriteLine("\nSumar-Restar Peso y Dolar");
            peso1 += dolar1;
            Console.WriteLine(peso1.GetCantidad());
            peso1 -= dolar1;
            Console.WriteLine(peso1.GetCantidad());

            Console.WriteLine("\nComparar Peso a Otros");
            Console.WriteLine(peso1 == dolar3);
            Console.WriteLine(peso1 == euro1);
            Console.WriteLine(peso1 == peso2);

            Console.WriteLine("\nComparar Dolar a Otros");
            Console.WriteLine(dolar1 == dolar2);
            Console.WriteLine(dolar1 == euro1);
            Console.WriteLine(dolar3 == peso2);

            Console.WriteLine("\nComparar Peso a Otros");
            Console.WriteLine(euro1 == dolar1);
            Console.WriteLine(euro1 == euro2);
            Console.WriteLine(euro1 == peso2);
            Console.ReadLine();
        }
    }
}
