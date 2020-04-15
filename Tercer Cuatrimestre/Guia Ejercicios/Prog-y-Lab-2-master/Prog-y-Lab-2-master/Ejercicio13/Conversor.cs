using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        /// <summary>
        ///  Convierte un número de decimal a binario
        /// </summary>
        /// <param name="nroDecimal">Numero en decimal</param>
        /// <returns>Numero en binario</returns>
        public static string DecimalBinario(double nroDecimal)
        {
            string retorno="";
            while (nroDecimal >0)
            {
                if (nroDecimal % 2 == 0)
                {
                    retorno = "0" + retorno;
                }
                else
                {
                    retorno = "1" +retorno;
                }
                nroDecimal = (int)nroDecimal / 2;
            }
            return retorno;
        }

        /// <summary>
        /// Convierte un número binario a decimal
        /// </summary>
        /// <param name="nroBinario">Numero en binario</param>
        /// <returns>Numero en decimal</returns>
        public static double BinarioDecimal(string nroBinario)
        {
            double retorno;
            byte number = Convert.ToByte(nroBinario, 2);
            retorno = Convert.ToDouble(number);
            return retorno;
        }
    }
}
