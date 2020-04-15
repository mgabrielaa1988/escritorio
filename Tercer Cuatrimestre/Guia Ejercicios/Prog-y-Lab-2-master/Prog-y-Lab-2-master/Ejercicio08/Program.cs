using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*8. Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años)
 * y la cantidad de horas trabajadas en el mes de N empleados de una fábrica. 
 * Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta
 * de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle
 * la cantidad de años trabajados multiplicados por $ 150, y al total de todas esas 
 * operaciones restarle el 13% en concepto de descuentos. Mostrar el recibo correspondiente
 * con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, el total de 
 * descuentos y el valor neto a cobrar de todos los empleados ingresados. 
 * Nota: Utilizar estructuras repetitivas y selectivas. */

namespace Ejercicio08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            #region Atributos
            float valorHora;
            int hsTrabajadas;
            float hsXValor;
            string nombre;
            float antiguedad=150f;
            int anioIngreso;
            int aniosTrab;
            float aniosXAntig;
            float subtotal;
            float descuento=0.13f;
            float valorDesc;
            float total;
            #endregion

            Console.Title = "Ejercicio 08";

            #region Toma de datos y calculos
            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Anio de ingreso: ");
            anioIngreso = int.Parse(Console.ReadLine());
            aniosTrab = DateTime.Now.Year - anioIngreso;
            aniosXAntig = antiguedad * aniosTrab;

            Console.Write("Horas trabajadas: ");
            hsTrabajadas = int.Parse(Console.ReadLine());

            Console.Write("Valor de la hora: ");
            valorHora = float.Parse(Console.ReadLine());
            hsXValor = hsTrabajadas * valorHora;

            subtotal = hsXValor + aniosXAntig;
            valorDesc = subtotal * descuento;
            total = subtotal - valorDesc;

            Console.WriteLine("A continuacio se mostrara la informacion del recibo");
            Console.ReadLine();
            #endregion

            #region Mostrar 
            Console.Clear();
            Console.WriteLine("\n\n     EMPLEADO: {0}",nombre);
            Console.WriteLine("  ANIO DE INGRESO: {0}",anioIngreso);
            Console.WriteLine("       ANTIGUEDAD: {0:C}-",aniosXAntig);
            Console.WriteLine(" HORAS TRABAJADAS: {0}HS",hsTrabajadas);
            Console.WriteLine(" SUBTOTAL x HORAS: {0:C}-",hsXValor);
            Console.WriteLine("      TOTAL BRUTO: {0:C}-",subtotal);
            Console.WriteLine("       DESCUENTOS: {0:C}-",valorDesc);
            Console.WriteLine("       TOTAL NETO: {0:C}-\n\n",total);
            #endregion

            Console.ReadLine();
        }
    }
}
