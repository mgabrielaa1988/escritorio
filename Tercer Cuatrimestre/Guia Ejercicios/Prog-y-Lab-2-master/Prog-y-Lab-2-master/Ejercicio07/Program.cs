using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*7. Hacer un programa que pida por pantalla la fecha de nacimiento de una persona
 * (día, mes y año) y calcule el número de días vividos por esa persona hasta 
 * la fecha actual (tomar la fecha del sistema con DateTime.Now). 
 * Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos. */

namespace Ejercicio07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            #region Atributos
            DateTime hoy = DateTime.Now;
            DateTime nacimiento;
            TimeSpan diasVividos;
            #endregion

            Console.Title = "Ejercicio 07";
            Console.WriteLine("Ingrese su fecha de nacimiento: DD/MM/AA");
            nacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("La fecha de hoy es: {0}", hoy.ToShortDateString());
            diasVividos = hoy - nacimiento;
            Console.WriteLine("Usted lleva vividos: {0} dias",diasVividos.Days);
            Console.ReadLine();
        }
    }
}
