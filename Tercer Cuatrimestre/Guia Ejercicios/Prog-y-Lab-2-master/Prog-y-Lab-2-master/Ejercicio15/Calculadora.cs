using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static int Calcular(int numeroA,int numeroB,string operacion)
        {
            int retorno=0;
            if (operacion == "+")
            {
                retorno = numeroA + numeroB;
            }
            if (operacion == "-")
            {
                retorno = numeroA - numeroB;
            }
            if (operacion == "*")
            {
                retorno = numeroA * numeroB;
            }
            if (operacion == "/"&&Validar(numeroB))
            {
                retorno = numeroA / numeroB;
            }
            return retorno;
        }
        private static bool Validar(int numero)
        {
            bool retorno = false;
            if (numero != 0)
            {
                retorno = true;
            }
            return retorno;
        }
        public static void Mostrar(int resultado)
        {
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();
        }
    }
}
