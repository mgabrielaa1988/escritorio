using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*El método ValidarOperador será privado y estático. Deberá validar que el operador 
 * recibido sea +, -, / o *. Caso contrario retornará +.
 * 2. El método Operar validará y realizará la operación pedida entre ambos números. */

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida y realiza la operacion pedida entre dos objetos numero
        /// </summary>
        /// <param name="num1">primer operando de la clase Numero</param>
        /// <param name="num2">segundo operando de la clase Numero</param>
        /// <param name="operador">string a validar para deteminar la operacion a realizar</param>
        /// <returns>retorno: double con el resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            operador = ValidarOperador(operador);
            if (operador == "+") { retorno = num1 + num2; }
            else if (operador == "-") { retorno = num1 - num2; }
            else if (operador == "*"){ retorno = num1 * num2; }
            else if (operador == "/") { retorno = num1 / num2; }
            return retorno;
        }

        /// <summary>
        /// Valida que el operador recibido sea +, -,* o /
        /// </summary>
        /// <param name="operador">string a ser analizado</param>
        /// <returns>operador: string +,-,* o /, en caso contrario retorna +</returns>
        private static string ValidarOperador(string operador)
        {
            if ((operador != "-") && (operador != "*") && (operador != "/"))
            {
                operador = "+";
            }
            return operador;
        }
    }
}
